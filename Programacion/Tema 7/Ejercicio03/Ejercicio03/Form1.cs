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

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Fecha> fechaList = new List<Fecha>();

        private void btnNewFecha_Click(object sender, EventArgs e)
        {
            int day = int.Parse(Interaction.InputBox("Introduce el dia"));
            int month = int.Parse(Interaction.InputBox("Introduce el mes"));
            int year = int.Parse(Interaction.InputBox("Introduce el año"));

            Fecha fecha = new Fecha();
            fecha.Year = year;
            fecha.Month = month;
            fecha.Day = day;
            fechaList.Add(fecha);
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string salida = string.Empty;
            foreach (Fecha fecha in fechaList)
            {
                salida += $"{fecha.Day} - {fecha.Month} - {fecha.Year}\n";
            }
            MessageBox.Show(salida);
        }

        private void btnSortFechas_Click(object sender, EventArgs e)
        {
            List<Fecha> salida = new List<Fecha>();
            bool cont = true;
            salida.Add(fechaList[0]); 
            for (int i = 1; i < fechaList.Count(); i++)
            {
                
            }
        }
    }
}
