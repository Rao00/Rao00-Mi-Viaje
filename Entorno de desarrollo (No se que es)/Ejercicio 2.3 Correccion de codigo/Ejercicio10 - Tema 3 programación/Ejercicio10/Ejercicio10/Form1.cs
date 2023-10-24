using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            double cantidad;
            int billetes, monedas, centimos;

            cantidad = double.Parse(tCantidad.Text); //Ejemplo: 768,89

            lResultado.Text = ""; 


            if (cantidad >= 500) // Si 768,89 > 500
            {
                billetes = (int)cantidad / 500; // billetes=768/500 =1

                lResultado.Text = lResultado.Text + billetes + " billetes de 500\n";
                cantidad = cantidad % 500; //768,89 % 500 = 268,89
                
            }
            if (cantidad >= 200)
            {
                billetes = (int)cantidad / 200;
                lResultado.Text = lResultado.Text + billetes + " billetes de 200\n";
                cantidad = cantidad % 200;
            }
            if (cantidad >= 100)
            {
                billetes = (int)cantidad / 100;
                lResultado.Text = lResultado.Text + billetes + " billetes de 100\n";
                cantidad = cantidad % 100;
            }
            if (cantidad >= 50)
            {
                billetes = (int)cantidad / 50;
                lResultado.Text = lResultado.Text + billetes + " billetes de 50 euros\n";
                cantidad = cantidad % 50;
            }
            if (cantidad >= 20)
            {
                billetes = (int)cantidad / 50;
                lResultado.Text = lResultado.Text + billetes + " billetes de 20 euros\n";
                cantidad = cantidad % 50;
            }
            if (cantidad >= 10)
            {
                billetes = (int)cantidad / 10;
                lResultado.Text = lResultado.Text + billetes + " billetes de 10 euros\n";
                cantidad = cantidad % 10;
            }
            if (cantidad >= 5)
            {
                billetes = (int)cantidad / 5;
                lResultado.Text = lResultado.Text + billetes + " billetes de 5 euros\n";
                cantidad = cantidad % 5;
            }
            if (cantidad >= 2)
            {
                monedas = (int)cantidad / 2;
                lResultado.Text = lResultado.Text + monedas + " monedas de 2 euros\n";
                cantidad = cantidad % 2;
            }
            if (cantidad >= 1)
            {
                monedas = (int)cantidad / 1;
                lResultado.Text = lResultado.Text + monedas + " monedas de 1 euro\n";
                cantidad = cantidad % 1;
            }
            if (cantidad > 0) // hay decimales
            {
                cantidad = (int)Math.Round(cantidad * 100); // redondeo para obtener los decimales. Ejemplo: 0,889999.. se redondea a 89

                if (cantidad >= 50)
                {
                    centimos = (int)cantidad / 50;
                    lResultado.Text = lResultado.Text + centimos + " monedas de 50 centimos\n";
                    cantidad = cantidad % 50;
                }

                if (cantidad >= 20)
                {
                    centimos = (int)cantidad / 20;
                    lResultado.Text = lResultado.Text + centimos + " monedas de 20 centimos\n";
                    cantidad = cantidad % 20;
                }
                if (cantidad >= 10)
                {
                    centimos = (int)cantidad / 10;
                    lResultado.Text = lResultado.Text + centimos + " monedas de 10 centimos\n";
                    cantidad = cantidad % 10;
                }
                if (cantidad >= 5)
                {
                    centimos = (int)cantidad / 5;
                    lResultado.Text = lResultado.Text + centimos + " monedas de 5 centimos\n";
                    cantidad = cantidad % 5;
                }
                if (cantidad >= 2)
                {
                    centimos = (int)cantidad / 2;
                    lResultado.Text = lResultado.Text + centimos + " monedas de 2 centimos\n";
                    cantidad = cantidad % 2;
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
