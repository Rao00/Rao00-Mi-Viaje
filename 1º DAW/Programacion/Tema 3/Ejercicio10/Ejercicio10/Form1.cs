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

        private void bCalcular_Click(object sender, EventArgs e)
        {
            double Euros = double.Parse(txtEntrada.Text);
            Euros *= 100;
            int numEuros = (int)Euros;
            int num500 = numEuros/50000;
            numEuros -= num500*50000;
            int num200 = numEuros/20000;
            numEuros -= num200*20000;
            int num100 = numEuros/10000;
            numEuros -= num100*10000;
            int num50 = numEuros/5000;
            numEuros -= num50*5000;
            int num20 = numEuros/2000;
            numEuros -= num20*2000;
            int num10 = numEuros/1000;
            numEuros -= num10*1000;
            int num5 = numEuros/500;
            numEuros -= num5*500;
            int num2 = numEuros/200;
            numEuros -= num2*200;
            int num1 = numEuros/100;
            numEuros -= num1*100;
            int num050 = numEuros/50;
            numEuros -= num050*50;
            int num020 = numEuros/20;
            numEuros -= num020*20;
            int num010 = numEuros/10;
            numEuros -= num010*10;
            int num005 = numEuros/5;
            numEuros -= num005*5;
            int num002 = numEuros/2;
            numEuros -= num002*2;
            int num001 = numEuros/1;

            string output = "Resultado";
            if (num500 > 0)
            {
                output += "\n" + num500 + " billetes de 500 euros";
            }
            if (num200 > 0)
            {
                output += "\n" + num200 + " billetes de 200 euros";
            }
            if (num100 > 0)
            {
                output += "\n" + num100 + " billetes de 100 euros";
            }
            if (num50 > 0)
            {
                output += "\n" + num50 + " billetes de 50 euros";
            }
            if (num20 > 0)
            {
                output += "\n" + num20 + " billetes de 20 euros";
            }
            if (num10 > 0)
            {
                output += "\n" + num10 + " billetes de 10 euros";
            }
            if (num5 > 0)
            {
                output += "\n" + num5 + " billetes de 5 euros";
            }
            if (num2 > 0)
            {
                output += "\n" + num2 + " monedas de 2 euros";
            }
            if (num1 > 0)
            {
                output += "\n" + num1 + " monedas de 1 euro";
            }
            if (num050 > 0)
            {
                output += "\n" + num050 + " monedas de 50 centimos";
            }
            if (num020 > 0)
            {
                output += "\n" + num020 + " monedas de 20 centimos";
            }
            if (num010 > 0)
            {
                output += "\n" + num010 + " monedas de 10 centimos";
            }
            if (num005 > 0)
            {
                output += "\n" + num005 + " monedas de 5 centimos";
            }
            if (num002 > 0)
            {
                output += "\n" + num002 + " monedas de 2 centimos";
            }
            if (num001 > 0)
            {
                output += "\n" + num001 + " monedas de 1 centimos";
            }

            lResultado.Text = output;

        }
    }
}
