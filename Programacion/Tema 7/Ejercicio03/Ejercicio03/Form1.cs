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
            if (fechaList.Last().Day == 0)
            {
                fechaList.Remove(fechaList.Last());
                MessageBox.Show("Dia no valido");
            }
            if (fechaList.Last().Month == 0)
            {
                fechaList.Remove(fechaList.Last());
                MessageBox.Show("Mes no valido");
            }
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
            bool cont = true;
            for (int i = 0; i < fechaList.Count(); i++)
            {
                for (int j = 0; j < fechaList.Count() && cont; j++)
                {
                    if (fechaList[j].Year < fechaList[i].Year) 
                    {
                        fechaList = MoveFechas(fechaList, i, j);
                        cont = false;
                    }
                    else if (fechaList[j].Month < fechaList[i].Month)
                    {
                        fechaList = MoveFechas(fechaList, i, j);
                        cont = false;
                    }
                    else if (fechaList[j].Day < fechaList[i].Day)
                    {
                        fechaList = MoveFechas(fechaList, i, j);
                        cont = false;
                    }
                }
                cont = true;
            }
            MessageBox.Show("Fechas ordenadas");
        }

        private List<Fecha> MoveFechas(List<Fecha>fechaList, int i, int j)
        {
            Fecha fechaTemp;
            fechaTemp = fechaList[j];
            fechaList[j] = fechaList[i];
            fechaList[i] = fechaTemp;
            return fechaList;
        }
    }
}
