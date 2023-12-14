using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BCalcular_Click(object sender, EventArgs e)
        {
            int billetes, monedas, centimos;

            double cantidad = double.Parse(tCantidad.Text); //Ejemplo: 768,89

            lResultado.Text = ""; 

            if (cantidad >= 500) // Si 768,89 > 500
            {
                billetes = (int)cantidad / 500; // billetes=768/500 =1
                lResultado.Text = lResultado.Text + billetes + " billetes de 500\n";
                cantidad -= 500 * billetes; //768,89 - 500 = 268,89  
            }
            if (cantidad >= 200)
            {
                billetes = (int)cantidad / 200;
                lResultado.Text = lResultado.Text + billetes + " billetes de 200\n";
                cantidad -= 200 * billetes; //268,89 - 200 = 68,89
            }
            if (cantidad >= 100)
            {
                billetes = (int)cantidad / 100;
                lResultado.Text = lResultado.Text + billetes + " billetes de 100\n";
                cantidad -= 100 * billetes;
            }
            if (cantidad >= 50)
            {
                billetes = (int)cantidad / 50;
                lResultado.Text = lResultado.Text + billetes + " billetes de 50 euros\n";
                cantidad -= 50 * billetes;
            }
            if (cantidad >= 20)
            {
                billetes = (int)cantidad / 20; //48
                lResultado.Text = lResultado.Text + billetes + " billetes de 20 euros\n";
                cantidad -= 20 * billetes;
            }
            if (cantidad >= 10)
            {
                billetes = (int)cantidad / 10;
                lResultado.Text = lResultado.Text + billetes + " billetes de 10 euros\n";
                cantidad -= 10 * billetes;
            }
            if (cantidad >= 5)
            {
                billetes = (int)cantidad / 5;
                lResultado.Text = lResultado.Text + billetes + " billetes de 5 euros\n";
                cantidad -= 5 * billetes;
            }
            if (cantidad >= 2)
            {
                monedas = (int)cantidad / 2;
                lResultado.Text = lResultado.Text + monedas + " monedas de 2 euros\n";
                cantidad -= 2 * monedas;
            }
            if (cantidad >= 1)
            {
                monedas = (int)cantidad / 1;
                lResultado.Text = lResultado.Text + monedas + " monedas de 1 euro\n";
                cantidad -= 1 * monedas;
            }
            if (cantidad > 0) // hay decimales
            {
                cantidad = (int)Math.Round(cantidad * 100); // redondeo para obtener los decimales. Ejemplo: 0,889999.. se redondea a 89

                if (cantidad >= 50)
                {
                    centimos = (int)cantidad / 50;
                    lResultado.Text = lResultado.Text + centimos + " monedas de 50 centimos\n";
                    cantidad -= 50 * centimos;
                }

                if (cantidad >= 20)
                {
                    centimos = (int)cantidad / 20;
                    lResultado.Text = lResultado.Text + centimos + " monedas de 20 centimos\n";
                    cantidad -= 20 * centimos;
                }
                if (cantidad >= 10)
                {
                    centimos = (int)cantidad / 10;
                    lResultado.Text = lResultado.Text + centimos + " monedas de 10 centimos\n";
                    cantidad -= 10 * centimos;
                }
                if (cantidad >= 5)
                {
                    centimos = (int)cantidad / 5;
                    lResultado.Text = lResultado.Text + centimos + " monedas de 5 centimos\n";
                    cantidad -= 5 * centimos;
                }
                if (cantidad >= 2)
                {
                    centimos = (int)cantidad / 2;
                    lResultado.Text = lResultado.Text + centimos + " monedas de 2 centimos\n";
                    cantidad -= 2 * centimos;
                }
                if (cantidad >= 1)
                {
                    centimos = (int)cantidad / 1;
                    lResultado.Text = lResultado.Text + centimos + " monedas de 1 centimos\n";

                }
            }
        }
    }
}
