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

        int longitud = 1000;
        List<double> ListaPrincipal = new List<double>();

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < longitud; i++)
            {
                ListaPrincipal.Add(rand.Next(0, 9999));
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
            ListaPrincipal = Sort(ListaPrincipal, ListaPrincipal.Count()-1);
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

        private List<double> Sort(List<double> lista, int max)
        {
            if (max <= 1)
            {
                return lista;
            }

            Random rnd = new Random();
            int pivot = rnd.Next(0, max);

            for (int i = 0; i < max; i++)
            {
                if (lista[i] > lista[pivot])
                {
                    lista = Swap(lista, pivot, pivot + 1);
                    lista = Swap(lista, i, pivot - 1);
                }
            }

            // Recursive calls with reduced range
            List<double> leftPart = Sort(lista.GetRange(0, pivot), pivot);
            List<double> rightPart = Sort(lista.GetRange(pivot + 1, max - (pivot + 1)), max - (pivot + 1));

            // Combine the sorted parts
            List<double> result = new List<double>();
            result.AddRange(leftPart);
            result.Add(lista[pivot]);
            result.AddRange(rightPart);

            return result;
        }
    }
}
/*
Random rnd = new Random();
int pivot = rnd.Next(0, max);
if (lista.Count() > 2)
{
    int j = 0;
    for (int i = 0; i < max; i++)
    {
        if (lista[i] == lista[pivot]) { continue; }
        if (lista[i] < lista[pivot])
        {
            lista = Swap(lista, j, i);
            j++;
        }
    }
    lista = Swap(lista, j, pivot);
    return QuickSort(lista, lista.Count());
}
else { return lista; 
*/