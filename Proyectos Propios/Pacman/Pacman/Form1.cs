using OpenTK.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Threading;
using System.Windows.Input;
using System.Printing;

namespace Pacman
{
    public partial class fPacman : Form
    {
        Ventana ventana;
        int angulo = 180;
        GameObject[,] mapa;

        public fPacman()
        {
            InitializeComponent();
        }

        private void LoadGlControl(object sender, EventArgs e)
        {
            ventana = new(GLControl, Color.Black);

            mapa = FormatMap(ventana.LoadMap("..\\..\\..\\maps\\map1.bmp"));

            ventana.AddQuad(BufferUsageHint.StreamDraw, 20, 20, ventana.HeightPixel, ventana.WidthPixel, Color.Yellow); //Pacman

            ventana.AddQuad(BufferUsageHint.StreamDraw, 80, 20, 50, 50, Color.Red); //Blinky
            ventana.AddQuad(BufferUsageHint.StreamDraw, 140, 20, 50, 50, Color.Cyan); //Inky
            ventana.AddQuad(BufferUsageHint.StreamDraw, 200, 20, 50, 50, Color.LightPink); //Pinky
            ventana.AddQuad(BufferUsageHint.StreamDraw, 260, 20, 50, 50, Color.DarkOrange); //Clyde
        }

        private void PaintGLControl(object sender, PaintEventArgs e)
        {
            GLControl.Focus();
            ventana.RenderFrame();
        }

        private void KeyPressed(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.W))
                angulo = 90;
            if (Keyboard.IsKeyDown(Key.S))
                angulo = 270;
            if (Keyboard.IsKeyDown(Key.A))
                angulo = 180;
            if (Keyboard.IsKeyDown(Key.D))
                angulo = 0;

            for (int i = 0; i < 10; i++)
            {
                ventana.Move(0, 5, angulo);
                ventana.RenderFrame();
                Thread.Sleep(5);
            }
        }

        private GameObject[,] FormatMap(Color[,] map)
        {
            int xLength = map.GetLength(0);
            int yLength = map.GetLength(1);

            GameObject[,] mapaFormateado = new GameObject[xLength, yLength];

            Dictionary<Color, GameObject> coloresMapa = new Dictionary<Color, GameObject>
            {
                { Color.White, GameObject.None },
                { Color.Black, GameObject.Wall },
                { Color.Pink, GameObject.Door },
                { Color.Yellow, GameObject.GamePoint },
                { Color.Orange, GameObject.GamePoint2 }
            };

            for (int i = 0; i < yLength; i++)
            {
                for (int j = 0; j < xLength; j++)
                {
                    Color color = map[j, i];

                    mapaFormateado[j, i] = coloresMapa.TryGetValue(color, out GameObject objetoAsignado) 
                        ? objetoAsignado : GameObject.None;
                }
            }

            return mapaFormateado;
        }

        private void LoadPacman()
        {
            
        }
    }
}
