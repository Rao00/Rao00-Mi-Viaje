using System;
using System.Collections;
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

        int longitud = 5000;
        List<double> ListaPrincipal = new List<double>();

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < longitud; i++)
            {
                ListaPrincipal.Add(rand.Next(0, 999999999));
            }
            MessageBox.Show("Lista creada");
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            string salida = string.Empty;
            foreach (int i in ListaPrincipal)
            {
                salida += i.ToString() + ", ";
            }
            MessageBox.Show(salida);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            ListaPrincipal = Sort(ListaPrincipal);
        }

        private List<double> Swap(List<double> lista, int i, int j)
        {
            if (i >= 0 && i < lista.Count && j >= 0 && j < lista.Count)
            {
                double temp = lista[i];
                lista[i] = lista[j];
                lista[j] = temp;
            }
            return lista;
        }

        private List<double> Sort(List<double> lista, int Miguelito = 10)
        {
            int i = 0;
            int pivot;
            if(Miguelito <= 0)
            {
                return lista;
            }
            while (i < lista.Count())
            {
                pivot = i;
                int rightIndex;
                int k = 0;
                for (int j = 0; j < pivot; j++)
                {
                    rightIndex = pivot * 2 > lista.Count() - 1 ? lista.Count() - 1 : pivot * 2 - k;
                    if (lista[j] > lista[rightIndex])
                    {
                        Swap(lista, j, rightIndex);
                        k++;
                        continue;
                    }
                    if (lista[j] > lista[pivot])
                    {
                        double temp = lista[j];
                        lista.RemoveAt(j);
                        lista.Insert(pivot, temp);
                        continue;
                    }
                    if (lista[rightIndex] < lista[pivot])
                    {
                        double temp = lista[rightIndex];
                        lista.RemoveAt(rightIndex);
                        lista.Insert(pivot - 1, temp);
                        k++;
                        continue;
                    }
                }
                i++;
            }
            return Sort(lista, Miguelito-1);
        }
    }
}