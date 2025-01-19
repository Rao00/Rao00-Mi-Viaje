using OpenTK.Windowing.Common.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pacman2
{
    public class Object
    {
        private int id;
        private Vector2 xymin;
        private Vector2 xymax;
        private Image? texture;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Vector2 Min
        {
            get { return xymin; }
            set { xymin = value; }
        }

        public Vector2 Max
        {
            get { return xymax; }
            set { xymax = value; }
        }

        public Image? Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        public Object()
        {
            id = 0;
            xymin = new Vector2();
            xymax = new Vector2();
            texture = null;
        }

        public void Mover(float sumX, float sumY)
        {
            this.xymin.X += sumX;
            this.xymin.Y += sumY;

            this.xymax.X += sumX;
            this.xymax.Y += sumY;
        }
    }
}
