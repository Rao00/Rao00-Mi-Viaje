using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bInputBox_Click(object sender, EventArgs e)
        {
            int salida = 0;
            for (int i = 1; i=<5; i++)
            {
                int nombreUsuario = int.Parse(Interaction.InputBox("Introduce tu usuario", "Nombre del usuario", "Introduce un usuario"));
                int passUsuario = int.Parse(Interaction.InputBox("Introduce tu contraseña", "Contraseña del usuario", "Introduce una contraseña"));
                if (nombreUsuario == "root" && passUsuario == "1234")
                {
                    break;
                }
            }
                
        }
    }
}
