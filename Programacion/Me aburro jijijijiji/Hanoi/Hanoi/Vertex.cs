using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    public class Vertex
    {
        float x, y;
        Color color;

        public float X
        {
            get { return x; }
            set { x = value; }
        }
        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public Vertex(float _x = 0, float _y = 0, Color? _color = null)
        { 
            x = _x; 
            y = _y;
            color = _color != null ? _color.Value : Color.White;
        }
    }
}
