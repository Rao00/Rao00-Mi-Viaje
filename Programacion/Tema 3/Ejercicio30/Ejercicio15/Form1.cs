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
            for (int i = 4; i>=0; i--)
            {
                string nombreUsuario = Interaction.InputBox("Introduce tu usuario", "Nombre del usuario", "Introduce un usuario");
                string passUsuario = Interaction.InputBox("Introduce tu contraseña", "Contraseña del usuario", "Introduce una contraseña");
                if (nombreUsuario == "root" && passUsuario == "1234")
                {
                    MessageBox.Show("Acceso permitido");
                    return;
                }
                else if (i == 0)
                {
                    MessageBox.Show($"Error\nNo te quedan intentos");
                }
                else MessageBox.Show($"Error\nTe quedan {i} intentos");
            }
        }
    }
}
