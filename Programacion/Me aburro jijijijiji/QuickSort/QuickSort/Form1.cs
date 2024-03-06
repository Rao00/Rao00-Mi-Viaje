using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private (string Nombre, int Edad, string Direccion) Ciudadano(int codigoCiudadano, int edad = 0)
        {
            if (edad != 0)
            {
                switch (codigoCiudadano)
                {
                    case 0:
                        return ("Manuel", edad, "Calle Alberto");
                    case 1:
                        return ("Hector", edad, "Calle Dudosa Orientacion");
                    case 2:
                        return ("Santiago", edad, "Calle Apaga el Movil");
                }
            }
            else
            {
                switch (codigoCiudadano)
                {
                    case 0:
                        return ("Manuel", 4, "Calle Alberto");
                    case 1:
                        return ("Hector", 87, "Calle Dudosa Orientacion");
                    case 2:
                        return ("Santiago", 45, "Calle Apaga el Movil");
                }
            }
            return (string.Empty, 0, string.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ciudadano1 = Ciudadano(2);
            var ciudadano2 = Ciudadano(3, 27);

            MessageBox.Show($"{ciudadano1.Nombre}\n{ciudadano1.Edad.ToString()}\n{ciudadano1.Direccion}");
            MessageBox.Show(ciudadano2.Edad.ToString());
        }
    }
}
