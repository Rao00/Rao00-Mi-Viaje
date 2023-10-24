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
            double pesoBajo = 0;
            double pesoMedioBajo = 0;
            double pesoMedioAlto = 0;
            double pesoAlto = 0;
            double pesoNew = 0;
            double totalAlumnos = 0;
            pesoNew = int.Parse(Interaction.InputBox("Introduce un peso", "Peso nuevo", "Peso"));
            while (pesoNew>=0)
            {
                if (pesoNew<=50)
                {
                    pesoBajo++;
                }
                if (pesoNew>50 && pesoNew<=65)
                {
                    pesoMedioBajo++;
                }
                if (pesoNew>65 && pesoNew<=80)
                {
                    pesoMedioAlto++;
                }
                if (pesoNew>80)
                {
                    pesoAlto++;
                }
                pesoNew = double.Parse(Interaction.InputBox("Introduce un peso", "Peso nuevo", "Peso"));
            }
            totalAlumnos = pesoBajo+pesoMedioBajo+pesoMedioAlto+pesoAlto;
            pesoBajo = pesoBajo/totalAlumnos*100;
            pesoMedioBajo = pesoMedioBajo/totalAlumnos*100;
            pesoMedioAlto = pesoMedioAlto/totalAlumnos*100;
            pesoAlto = pesoAlto/totalAlumnos*100;
            MessageBox.Show($"Peso alto: {Math.Round(pesoAlto,2)}%\nPeso medio alto: {Math.Round(pesoMedioAlto,2)}%\nPeso Medio Bajo: {Math.Round(pesoMedioBajo,2)}%\nPeso bajo: {Math.Round(pesoBajo,2)}%\n");
        }
    }
}
