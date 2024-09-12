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

namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 10;

        (int index, bool data)searchData(int[] array, int lookData)
        {
            for(int i = 0; i < TAM; i++)
            {
                if (array[i] == lookData)
                    return (i, true);
            }
            return (-1, false);
        }

        private void bEjecutar_Click(object sender, EventArgs e)
        {
            int[] v1 = new int[TAM];
            var rand = new Random();
            for (int i = 0; i < TAM; i++)
            {
                v1[i] = rand.Next(0,11);
            }
            int buscar = int.Parse(Interaction.InputBox("Data", "Data", "Data"));
            MessageBox.Show("Encontrado = " + searchData(v1, buscar).data.ToString() + "\nIndice = " + searchData(v1,buscar).index.ToString());
        }
    }
}
