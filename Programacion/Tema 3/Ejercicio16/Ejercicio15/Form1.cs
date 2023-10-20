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
            int numeroUsuario = int.Parse(Interaction.InputBox("Introduce un numero entre 1 y 9", "Numero del usuario", "Introduce un numero")); ;
            while (numeroUsuario>=0 && numeroUsuario<=9)
            {
                salida += numeroUsuario;
                numeroUsuario = int.Parse(Interaction.InputBox("Introduce un numero entre 1 y 9", "Numero del usuario", "Introduce un numero"));
            }
            MessageBox.Show("Suma total = "+salida);
        }
    }
}
