using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double media(string[] notas)
        {
            var notasList = new List<double>();
            foreach(string nota in notas)
            {
                if(double.Parse(nota) > 0 && double.Parse(nota)<10)
                {
                    notasList.Add(double.Parse(nota));
                }
                else
                {
                    double error = -1;
                    MessageBox.Show("Notas comprendidas entre el 0 y el 10, Error " + error);
                    return error;
                }
            }
            int total = notasList.Count;
            double notaTotal = 0;
            foreach(double nota in notasList)
            {
                notaTotal += nota;
            }
            double salida = notaTotal/total;
            return salida;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            string entrada = txtNotas.Text;
            string[] notasArray;
            notasArray = entrada.Split(' ');
            double notaMedia = Math.Round(media(notasArray),1);
            if (notaMedia > 0)
            {
                string salidaFinal = "Nota media = " + notaMedia;
                MessageBox.Show(salidaFinal);
            }
        }
    }
}
