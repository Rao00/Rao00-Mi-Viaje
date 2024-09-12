using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    static class Aritmetica
    {
        public static int MediaAngulosPlanoCartesiano(List<int> angulos)
        {
            float x = 0;
            float y = 0;

            foreach (int angulo in angulos)
            {
                x += (float)Math.Cos(angulo * (Math.PI / 180));
                y += (float)Math.Sin(angulo * (Math.PI / 180));
            }

            x /= angulos.Count;
            y /= angulos.Count;

            return (int)(Math.Atan2(y, x) * (180/Math.PI));
        }
    }
}
