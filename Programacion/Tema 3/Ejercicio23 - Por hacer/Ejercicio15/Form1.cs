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
            int numMayor = 0;
            int numMenor = 0; 
            int numeroUsuario = 0;
            while (numeroUsuario>=0)
            {
                if (numeroUsuario>numMayor)
                {
                    numMayor = numeroUsuario;
                }
                else if (numeroUsuario<numMenor || numMenor == 0)
                {
                    numMenor = numeroUsuario;
                }
                numeroUsuario = int.Parse(Interaction.InputBox("Introduce un numero mayor que 0", "Numero del usuario", "Introduce un numero mayor que 0"));
            }
            MessageBox.Show("Numero mayor = "+numMayor+"\nNumero menor = "+numMenor);
        }
    }
}
