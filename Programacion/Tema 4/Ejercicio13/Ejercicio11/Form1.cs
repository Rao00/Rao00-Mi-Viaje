using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool esBisiesto(int anio)
        {
            bool esBisiesto = true;

            if (anio%4 == 0)
            {
                if (anio%100 == 0 && anio%400 == 0)
                {
                    esBisiesto = true;
                }
                else if (anio%100 == 0)
                {
                    esBisiesto= false;
                }
            }
            else if (anio%4 != 0)
            {
                esBisiesto = false;
            }
            return esBisiesto;
        }

        bool comprobar(int dia, int mes, int año)
        {
            int diaMax = 0;
            bool bisiesto = esBisiesto(año);
            if(mes == 2)
            {
                if (bisiesto == true)
                {
                    diaMax = 29;
                }
                else if (bisiesto == false)
                {
                    diaMax = 28;
                }
            }
            else if (mes < 8 && mes != 2)
            {
                if (mes % 2 == 0)
                {
                    diaMax = 30;
                }
                else
                {
                    diaMax = 31;
                }
            }
            else if (mes >= 8 && mes != 2)
            {
                if (mes % 2 == 0)
                {
                    diaMax = 31;
                }
                else
                {
                    diaMax = 30;
                }   
            }
            if (dia <= diaMax && mes < 13 && mes > 0 && año > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        (int, int, int) sumarX(int dia, int mes, int anio, int sum)
        {
            if (comprobar(dia + sum, mes, anio) == false)
            {
                dia = 1;
                mes += 1;
                if (comprobar(dia, mes, anio) == false)
                {
                    mes = 1;
                    anio += 1;
                }
            }
            else dia += 1;
            return (dia,mes,anio);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anio = int.Parse(txtAnio.Text);
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            bool comp = comprobar(dia, mes, anio);
            if (comp == true)
            {
                MessageBox.Show("Resultado: " + sumarX(dia, mes, anio, 1));
            }
            else MessageBox.Show("Error");
            
        }
    }
}
