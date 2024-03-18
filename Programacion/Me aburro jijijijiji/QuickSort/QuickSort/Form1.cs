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
                ListaPrincipal.Add(rand.Next(0, 99));
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
            MessageBox.Show("Ordenado");
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

        private List<double> Sort(List<double> listaPrincipal, int Miguelito = 10)
        {
            int i = 0;
            int pivot;
            if(Miguelito <= 0)
            {
                return listaPrincipal;
            }
            while (i < listaPrincipal.Count())
            {
                pivot = i;
                int rightIndex;
                int k = 0;
                for (int j = 0; j < pivot; j++)
                {
                    rightIndex = pivot * 1.5 > listaPrincipal.Count() - 1 ? listaPrincipal.Count() - 1 : pivot + (pivot/2) - k;
                    if (listaPrincipal[j] > listaPrincipal[rightIndex])
                    {
                        Swap(listaPrincipal, j, rightIndex);
                        k++;
                    }
                    else if (listaPrincipal[j] > listaPrincipal[pivot])
                    {
                        double temp = listaPrincipal[j];
                        listaPrincipal.RemoveAt(j);
                        listaPrincipal.Insert(pivot, temp);
                    }
                    else if (listaPrincipal[rightIndex] < listaPrincipal[pivot])
                    {
                        double temp = listaPrincipal[rightIndex];
                        listaPrincipal.RemoveAt(rightIndex);
                        listaPrincipal.Insert(pivot - 1, temp);
                        k++;
                    }
                }
                i++;
            }
            return Sort(listaPrincipal, Miguelito-1);
        }
    }
}