using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;


namespace Hanoi
{
    public class Ventana
    {
        readonly GLControl Viewport;
        private List<float[]> listaElementos = new List<float[]>();

        int VertexBufferObject;
        int VertexArrayObject;
        int shader;

        public Ventana(GLControl viewport, Color _background)
        {
            Viewport = viewport;
            Viewport.MakeCurrent();
            GL.Viewport(0, 0, Viewport.Width, Viewport.Height);

            GL.ClearColor(_background);

            VertexBufferObject = GL.GenBuffer();
            VertexArrayObject = GL.GenVertexArray();

            LoadShader();
        }

        private void LoadShader()
        {
            string sVertexShader = @"#version 330 core 
                                        layout (location = 0) in vec2 aPosition;
                                        layout (location = 1) in vec3 aColor;
                                        out vec4 vertexColor;
                                        void main() 
                                        { 
                                            vertexColor = vec4(aColor, 1.0f);
                                            gl_Position = vec4(aPosition, 0, 1.0);
                                        }";
            string sFragmentShader = @"#version 330 core 
                                        in vec4 vertexColor; 
                                        out vec4 FragColor; 
                                        void main() 
                                        { 
                                            FragColor = vertexColor;
                                        }";

            int vertexShader = GL.CreateShader(ShaderType.VertexShader);
            GL.ShaderSource(vertexShader, sVertexShader);
            GL.CompileShader(vertexShader);

            int fragmentShader = GL.CreateShader(ShaderType.FragmentShader);
            GL.ShaderSource(fragmentShader, sFragmentShader);
            GL.CompileShader(fragmentShader);

            shader = GL.CreateProgram();

            GL.AttachShader(shader, vertexShader);
            GL.AttachShader(shader, fragmentShader);

            GL.LinkProgram(shader);

            GL.DetachShader(shader, vertexShader);
            GL.DetachShader(shader, fragmentShader);
            GL.DeleteShader(vertexShader);
            GL.DeleteShader(fragmentShader);
        }

        private void LoadVertexBufferObject()
        {
            try
            {
                GL.BindBuffer(BufferTarget.ArrayBuffer, VertexBufferObject);

                float[] bufferElements = new float[listaElementos.Count * listaElementos[0].Length];

                int offset = 0;
                foreach (float[] objeto in listaElementos)
                {
                    Array.Copy(objeto, 0, bufferElements, offset, objeto.Length);
                    offset += objeto.Length;
                }

                GL.BufferData(BufferTarget.ArrayBuffer, bufferElements.Length * sizeof(float), bufferElements, BufferUsageHint.StaticDraw);
            }
            catch { }
        }

        private void LoadVertexArrayObject()
        {
            GL.BindVertexArray(VertexArrayObject);

            GL.VertexAttribPointer(0, 2, VertexAttribPointerType.Float, false, 5 * sizeof(float), 0);
            GL.EnableVertexAttribArray(0);

            GL.VertexAttribPointer(1, 3, VertexAttribPointerType.Float, false, 5 * sizeof(float), 2 * sizeof(float));
            GL.EnableVertexAttribArray(1);
        }

        public void RenderFrame()
        {
            LoadVertexArrayObject();
            LoadVertexBufferObject();

            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.UseProgram(shader);
            GL.BindVertexArray(VertexArrayObject);

            GL.DrawArrays(PrimitiveType.Triangles, 0, listaElementos.Count * 3);
            GL.DrawArrays(PrimitiveType.Triangles, 0, listaElementos.Count * 6);

            Viewport.SwapBuffers();
        }

        public void AddTriangle(float _x, float _y, float _height, float _width, Color? color) 
        {
            float x = (_x / (Viewport.Width / 2.0f)) - 1.0f;
            float y = (_y / (Viewport.Height / 2.0f)) - 1.0f;

            float height = _height / (Viewport.Height / 2.0f);
            float width = _width / (Viewport.Width / 2.0f);

            color = color ?? Color.Black;

            Vector3 vec1 = new Vector3(x, y, 0.0f);
            Vector3 vec2 = new Vector3(x + width, y, 0.0f);
            Vector3 vec3 = new Vector3(x, y + height, 0.0f);

            float[] vertices =
            {
                vec1.X, vec1.Y, color.Value.R / 255f, color.Value.G / 255f, color.Value.B / 255f,
                vec2.X, vec2.Y, color.Value.R / 255f, color.Value.G / 255f, color.Value.B / 255f,
                vec3.X, vec3.Y, color.Value.R / 255f, color.Value.G / 255f, color.Value.B / 255f
            };

            listaElementos.Add(vertices);

            LoadVertexBufferObject();
        }

        public void AddQuad(float _x, float _y, float _height, float _width, Color? color)
        {
            float x = (_x / (Viewport.Width / 2.0f)) - 1.0f;
            float y = (_y / (Viewport.Height / 2.0f)) - 1.0f;

            float height = _height / (Viewport.Height / 2.0f);
            float width = _width / (Viewport.Width / 2.0f);

            color = color ?? Color.Black;

            Vector3 vec1 = new Vector3(x, y, 0.0f);
            Vector3 vec2 = new Vector3(x + width, y, 0.0f);
            Vector3 vec3 = new Vector3(x, y + height, 0.0f);

            Vector3 vec4 = new Vector3(x + width, y + height, 0.0f);
            Vector3 vec5 = new Vector3(x + width, y, 0.0f);
            Vector3 vec6 = new Vector3(x, y + height, 0.0f);

            float[] vertices =
            {
                vec1.X, vec1.Y, color.Value.R / 255f, color.Value.G / 255f, color.Value.B / 255f,
                vec2.X, vec2.Y, color.Value.R / 255f, color.Value.G / 255f, color.Value.B / 255f,
                vec3.X, vec3.Y, color.Value.R / 255f, color.Value.G / 255f, color.Value.B / 255f,

                vec4.X, vec4.Y, color.Value.R / 255f, color.Value.G / 255f, color.Value.B / 255f,
                vec5.X, vec5.Y, color.Value.R / 255f, color.Value.G / 255f, color.Value.B / 255f,
                vec6.X, vec6.Y, color.Value.R / 255f, color.Value.G / 255f, color.Value.B / 255f
            };

            listaElementos.Add(vertices);

            LoadVertexBufferObject();
        }

        public void Move(int index, int _distancia, float _orientation)
        {
            float orientation = (float)(_orientation * (Math.PI / 180));

            for (int i = 0; i < listaElementos[index].Length; i+=5)
            {
                float x = listaElementos[index][i];
                float y = listaElementos[index][i + 1];

                float distancia = _distancia / ((Viewport.Width / 2.0f) - 1.0f);

                listaElementos[index][i] = (float)(x + (distancia * Math.Cos(orientation)));
                listaElementos[index][i + 1] = (float)(y + (distancia * Math.Sin(orientation)));
            }
        }
        
        public void LoadMap(string ruta)
        {
            FileStream map = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            BinaryReader data = new BinaryReader(map);
            for (int i = 0; i < map.Length; i++)
            {
                MessageBox.Show(data.Read().ToString());
            }
        }
    }
}