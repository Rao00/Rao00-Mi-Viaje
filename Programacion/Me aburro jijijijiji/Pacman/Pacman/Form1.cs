using OpenTK.WinForms;
using Hanoi;
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
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

namespace Pacman
{
    public partial class fPacman : Form
    {
        Ventana ventana;
        int angulo = 180;

        public fPacman()
        {
            InitializeComponent();
        }

        private void LoadGlControl(object sender, EventArgs e)
        {
            ventana = new(GLControl, Color.Black);

            ventana.LoadMap("C:\\Users\\Pablo\\Desktop\\Rao00-Mi-Viaje\\Programacion\\Me aburro jijijijiji\\Pacman\\maps\\map1.bmp");

            ventana.AddQuad(20, 20, 50, 50, Color.Yellow); //Pacman

            ventana.AddQuad(80, 20, 50, 50, Color.Red); //Blinky
            ventana.AddQuad(140, 20, 50, 50, Color.Cyan); //Inky
            ventana.AddQuad(200, 20, 50, 50, Color.LightPink); //Pinky
            ventana.AddQuad(260, 20, 50, 50, Color.DarkOrange); //Clyde   
        }

        private void PaintGLControl(object sender, PaintEventArgs e)
        {
            GLControl.Focus();
            for (int i = 0; i < 10; i++)
            {
                ventana.RenderFrame();
                Thread.Sleep(5);
            }
            ventana.RenderFrame();
        }

        private void KeyPressed(object sender, KeyEventArgs e)
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
                ventana.Move(1, 5, angulo);
                ventana.RenderFrame();
                Thread.Sleep(5);
            }
        }
    }
}