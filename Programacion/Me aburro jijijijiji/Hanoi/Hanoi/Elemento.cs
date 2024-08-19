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
    public class Elemento
    {
        List<Vertex> vertices;
        PrimitiveType type;

        public List<Vertex> Vertices
        {
            get { return vertices; }
            set { vertices = value; }
        }

        public PrimitiveType Type
        {
            get { return type; }
            set { type = value; }
        }

        public void AddVertex(Vertex vertice)
        {
            vertices.Add(vertice);
        }

        public void RemoveVertex(Vertex vertice)
        {
            vertices.Remove(vertice);
        }
    }
}
