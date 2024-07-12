using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    public static class Trigonometria
    {
        public static float Area(Vertex va, Vertex vb, Vertex vc)
        {
            return (va.X * (vb.Y - vc.Y) + vb.X * (vc.Y - va.Y) + vc.X * (va.Y - vb.Y)) / 2;
        }
    }
}
