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
using System.Dynamic;

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
        List<Tuple<float, float>> listaPuntos = new List<Tuple<float, float>>();
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
            GL.Color3(0f, 1.0f, 1.0f);
            DibujarListaPuntos();
            GL.End();

            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(1.0f, 1.0f, 0.5f);
            DibujarCursor(cursorX, cursorY);
            GL.End();

            this.SwapBuffers();
        }

        public Tuple<float, float> Rayo(float x, float y, float tiempo = 0, float direccion = 0, Tuple<float, float> vectorFinal = null)
        {
            float direccionX = vectorFinal.Item1;
            float direccionY = vectorFinal.Item2;
            
            if (vectorFinal == null)
            {
                //Conversion de grados a Vector Direccion
                float radianes = direccion * (float)(Math.PI / 180);
                direccionX = (float)Math.Cos(radianes);
                direccionY = (float)Math.Sin(radianes);

            }

            x += tiempo * direccionX;
            y += tiempo * direccionY;

            return Tuple.Create(x, y);
        }

        public bool Colision(float x1, float y1, out List<Tuple<float, float>> listaTriangulosPorRevisar)
        {
            listaTriangulosPorRevisar = new List<Tuple<float,float>>();
            var boundingBox = new Tuple<float, float>[3];
            //Registrar las hitboxes de todos los elementos
            for (int i = 0; i < listaElementos.Count; i += 3)
            {
                boundingBox[0] = listaElementos[i];
                boundingBox[1] = listaElementos[i + 1];
                boundingBox[2] = listaElementos[i + 2];

                float[] boundingAltura = new float[2];
                //Conseguir la altura maxima y minima del elemento
                boundingAltura[0] = listaElementos.GetRange(i, 3).Max(y => y.Item2);
                boundingAltura[1] = listaElementos.GetRange(i, 3).Min(y => y.Item2);

                float[] boundingAnchura = new float[2];
                //Conseguir la anchura maxima y minima del elemento
                boundingAnchura[0] = listaElementos.GetRange(i, 3).Max(x => x.Item1);
                boundingAnchura[1] = listaElementos.GetRange(i, 3).Min(x => x.Item1);

                //Recoger solo los triangulos posiblemente con colison
                if ((boundingAltura[0] > y1 && boundingAltura[1] < y1) || (boundingAnchura[0] > x1 && boundingAnchura[1] < x1))
                {
                    listaTriangulosPorRevisar.AddRange(boundingBox);
                }

                //Comprobar si el punto se puede colocar
                if ((boundingAltura[0] > y1 && boundingAltura[1] < y1) && (boundingAnchura[0] > x1 && boundingAnchura[1] < x1))
                {
                    return true;
                }
            }
            return false;
        }

        private bool Colision(float x1, float y1)
        {
            return Colision(x1, y1, out _);
        }
        private bool Colision(Tuple<float, float> vector)
        {
            return Colision(vector.Item1, vector.Item2, out _);
        }

        private void DibujarListaPuntos()
        {
            foreach (var item in listaPuntos)
            {
                GL.Vertex2(item.Item1, item.Item2);
            }
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
            List<Tuple<float, float>> seleccion;
            Colision(cursorX, cursorY, out seleccion);
            foreach (var item in seleccion)
            {
                GL.Vertex2(item.Item1, item.Item2);
            }
        }
        public void DibujarTriangulosAleatorios()
        {
            Random rnd = new Random();
            GL.ClearColor(1.0f, 1.0f, 1.0f, 1.0f);
            for (int i = 0; i < 10; i++)
            {
                float orientacion = rnd.Next(0, 2);
                float tama = rnd.Next(20, 100);
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
            Tuple<float, float> vertice;
            if (!Colision(cursorX, cursorY))
            {
                vertice = new Tuple<float, float>(cursorX, cursorY);
                listaTemporalElementos.Add(vertice);
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
