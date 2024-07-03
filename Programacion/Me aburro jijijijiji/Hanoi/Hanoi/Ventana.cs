using OpenTK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using OpenTK.Input;

namespace Hanoi
{
    public class Ventana : GameWindow
    {
        int ancho, alto;
        float cursorX, cursorY;
        float tamCursor = 15f;
        bool mousePresionado = false;

        Color background;
        List<Tuple<float, float>> listaElementos = new List<Tuple<float, float>>();
        List<Tuple<float, float>> listaLineas = new List<Tuple<float, float>>();
        List<Tuple<float, float>> listaTemporalElementos = new List<Tuple<float, float>>();

        public Ventana(int _ancho, int _alto, string titulo, Color? _background) : base(_ancho, _alto, GraphicsMode.Default, titulo)
        {
            ancho = _ancho;
            alto = _alto;
            background = _background != null ? (Color)_background : Color.Black ;
            this.Resize += DimensionesVentana;
            this.Load += this.Carga;
            this.RenderFrame += this.ActualizarFrame;
            this.MouseMove += this.OnCursorMove;
            this.MouseDown += this.MouseClick;
            this.MouseUp += this.MouseRelease;
            this.CursorVisible = false;
            DibujarTriangulosAleatorios();
            this.Run(1 / 60.0);
        }

        public void ActualizarFrame(object obj, EventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(1.0f, 1.0f, 1.0f);
            //Especificar vertices aqui            
            for(int i = 0; i < listaElementos.Count; i++)
            {
                float x = listaElementos[i].Item1;
                float y = listaElementos[i].Item2;
                GL.Vertex2(x, y);
            }
            GL.End();

            GL.PointSize(5.0f);
            GL.Begin(PrimitiveType.Points);
            GL.Color3(1.0f, 0f, 0f);
            DibujarListaTemporal();
            GL.End();

            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(1.0f, 1.0f, 0.5f);
            DibujarCursor(cursorX, cursorY);
            GL.End();

            this.SwapBuffers();
        }

        public bool Colision(float x1, float y1, float x2, float y2, out Tuple<float, float> primerContacto)
        {
            for (int i = 0; i < listaElementos.Count-1; i++)
            {
                float x3 = listaElementos[i].Item1;
                float y3 = listaElementos[i].Item2;
                float x4 = listaElementos[i + 1].Item1;
                float y4 = listaElementos[i + 1].Item2;
                
                float denominador = (x4 - x3) * (y2 - y1) - (x2 - x1) * (y4 - y3);
                if (denominador == 0) { continue; }
                
                float t = ((y1 - y3) * (x4 - x3) + (x3 - x1) * (y4 - y3)) / denominador;
                float s = ((y1 - y3) * (x2 - x1) + (x3 - x1) * (y2 - y1)) / denominador;
                if (t < 0 || t > 1) { continue; }
                if (s < 0 || s > 1) { continue; }

                float resultadoX = x1 + t * (x2 - x1);
                float resultadoY = y1 + t * (y2 - y1);

                primerContacto = new Tuple<float, float> ( resultadoX, resultadoY );

                return true;
            }

            primerContacto = null;
            return false;
        }
        private bool Colision(float x1, float y1, float x2, float y2)
        {
            return Colision(x1, y1, x2, y2, out _);
        }

        private void DibujarListaTemporal()
        {
            foreach(var item in listaTemporalElementos)
            {
                GL.Vertex2(item.Item1, item.Item2);
            }
            if (listaTemporalElementos.Count % 3 == 0)
            {
                foreach (var item in listaTemporalElementos)
                {
                    listaElementos.Add(item);
                }
                listaTemporalElementos.Clear();
            }
        }
        public void DibujarCursor(float x, float y)
        {
            float offset = mousePresionado ? 0 : tamCursor / 10;
            float tempTamCursor = tamCursor;
            GL.PointSize(tamCursor);
            GL.ClearColor(1.0f, 1.0f, 1.0f, 1.0f);
            for (int i = 0; i < 1; i++)
            {
                GL.Vertex2(cursorX + offset, cursorY - offset);
                GL.Vertex2((cursorX + offset) + tempTamCursor, (cursorY - offset));
                GL.Vertex2((cursorX + offset), (cursorY - offset) - tempTamCursor);
                offset *= -1;
                tempTamCursor *= -1;
            }
        }
        public void DibujarTriangulosAleatorios()
        {
            Random rnd = new Random();
            GL.ClearColor(1.0f, 1.0f, 1.0f, 1.0f);
            for (int i = 0; i < 10; i++)
            {
                float orientacion = rnd.Next(0, 2);
                float tama = rnd.Next(5, 200);
                float y = rnd.Next(0, alto);
                float x = rnd.Next(0, ancho);
                if (orientacion == 0)
                {
                    tama *= -1;
                }
                Tuple<float, float> vertice1 = new Tuple<float, float>(x + tama, y + tama);
                Tuple<float, float> vertice2 = new Tuple<float, float>(x, y + tama);
                Tuple<float, float> vertice3 = new Tuple<float, float>(x + tama, y);
                listaElementos.Add(vertice1);
                listaElementos.Add(vertice2);
                listaElementos.Add(vertice3);
            }
        } 
        public void OnCursorMove(object obj, MouseMoveEventArgs eventoCursor)
        {
            cursorX = eventoCursor.X;
            cursorY = alto - eventoCursor.Y;
        }
        public void MouseClick(object obj, MouseButtonEventArgs e)
        {
            mousePresionado = e.Button == MouseButton.Left ? true : false;
            switch (listaTemporalElementos.Count)
            {
                case 0:
                    Tuple<float, float> vertice = new Tuple<float, float>(cursorX, cursorY);
                    listaTemporalElementos.Add(vertice);
                    break;
                case 1:
                    if (!Colision(cursorX, cursorY, listaTemporalElementos[0].Item1, listaTemporalElementos[0].Item2))
                    {
                        vertice = new Tuple<float, float>(cursorX, cursorY);
                        listaTemporalElementos.Add(vertice);
                    }
                    else { listaTemporalElementos.Clear(); }
                    break;
                case 2:
                    if (!Colision(cursorX, cursorY, listaTemporalElementos[1].Item1, listaTemporalElementos[1].Item2))
                    {
                        vertice = new Tuple<float, float>(cursorX, cursorY);
                        listaTemporalElementos.Add(vertice);
                    }
                    else { listaTemporalElementos.Clear(); }
                    break;
            }
        }
        public void MouseRelease(object obj, MouseButtonEventArgs e)
        {
            mousePresionado = false;
        }
        public void Carga(object obj, EventArgs e)
        {
            float canalRed = background.R / 255f;
            float canalGreen = background.G / 255f;
            float canalBlue = background.B / 255f;
            float canalAlpha = background.A / 255f;
            GL.ClearColor(canalRed, canalGreen, canalBlue, canalAlpha);
        }
        public void DimensionesVentana(object obj, EventArgs e)
        {
            //Necesito explicacion de esto que el indio no explica tan bien
            GL.Viewport(0, 0, ancho, alto);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0.0, ancho, 0.0, alto, -1.0, 1.0);
            GL.MatrixMode(MatrixMode.Modelview);
        }
    }
}
