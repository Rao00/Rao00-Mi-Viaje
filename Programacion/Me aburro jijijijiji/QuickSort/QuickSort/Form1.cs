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
                ListaPrincipal.Add(rand.Next(0, 1000));
            }
            MessageBox.Show("Lista creada");
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            string salida = "";
            for(int i = 0; i < ListaPrincipal.Count(); i++)
            {
                salida += ListaPrincipal[i] + ", ";
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

        new private List<double> Move(List<double> lista, int i, int j)
        {
            if (i >= 0 && i < lista.Count && j >= 0 && j < lista.Count)
            {
                double temp = lista[i];
                lista.RemoveAt(i);
                lista.Insert(j, temp);
            }
            return lista;
        }

        private List<double> Sort(List<double> listaPrincipal)
        {
            if (listaPrincipal.Count() <= 1)
            {
                return listaPrincipal;
            }

            int pivot = listaPrincipal.Count() / 2;
            double pivotValor = listaPrincipal[pivot];

            List<double> left = new List<double>();
            List<double> right = new List<double>();

            for (int i = 0; i < listaPrincipal.Count(); i++)
            {
                if (i == pivot)
                {
                    continue;
                }
                if (listaPrincipal[i] >= listaPrincipal[pivot])
                {
                    right.Add(listaPrincipal[i]);
                }
                else if (listaPrincipal[i] <= listaPrincipal[pivot])
                {
                    left.Add(listaPrincipal[i]);
                }
            }

            left = Sort(left);
            right = Sort(right);

            left.Add(pivotValor);
            left.AddRange(right);

            return left;
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            bool check = true;
            for(int i = 0; i < ListaPrincipal.Count()-1; i++)
            {
                if (ListaPrincipal[i+1] < ListaPrincipal[i]) 
                {
                    MessageBox.Show("Error numero" + ListaPrincipal[i-1]);
                    check = false;
                    break;
                }
            }
            if (check) { MessageBox.Show("Correcto"); }
        }
    }
}