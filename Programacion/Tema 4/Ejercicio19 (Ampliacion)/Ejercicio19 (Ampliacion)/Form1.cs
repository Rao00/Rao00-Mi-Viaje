using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio19__Ampliacion_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bEmpezar_Click(object sender, EventArgs e)
        {
            
            int input = int.Parse(Interaction.InputBox("Introduce numeros, cuando quieras ver el resultado introduce un 0", "Pestaña Principal", "Introduce un numero"));
            int secGrande = input;
            int cantidadGrande = 0;
            int secNueva = 0;
            int cantidadNueva = 0;
            while (input != 0)
            {
                if (input == secGrande)
                {
                    cantidadGrande++;
                }
                else if (input == secNueva)
                {
                    cantidadNueva++;
                    if (cantidadNueva > cantidadGrande)
                    {
                        cantidadGrande = cantidadNueva;
                        secGrande = secNueva;
                    }
                }
                else if (input != secNueva)
                {
                    secNueva = input;
                    cantidadNueva = 1;
                }
                input = int.Parse(Interaction.InputBox("Introduce numeros, cuando quieras ver el resultado introduce un 0", "Pestaña Principal", "Introduce un numero"));
            }
            MessageBox.Show($"El numero mas repetido ha sido el {secGrande} y se ha escrito {cantidadGrande}");
        }
    }
}
