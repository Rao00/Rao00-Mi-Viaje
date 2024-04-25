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


namespace Pacman
{
    public partial class Menu : Form
    {
        List<Tuple<int, int>> datosEntrenamiento = new List<Tuple<int, int>>();

        int valor = 20;

        double neurona1 = 1;

        public Menu()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < datosEntrenamiento.Count; i++)
            {
                if (datosEntrenamiento[i].Item1 * neurona1 > datosEntrenamiento[i].Item2)
                {
                    neurona1 -= (datosEntrenamiento[i].Item2 - datosEntrenamiento[i].Item1) / 100;
                    continue;
                }
                if (datosEntrenamiento[i].Item1 * neurona1 < datosEntrenamiento[i].Item2)
                {
                    neurona1 += (datosEntrenamiento[i].Item2 - datosEntrenamiento[i].Item1) / 100;
                    continue;
                }
            }
            MessageBox.Show("Entrenado");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                int temp = rnd.Next(100);
                Tuple<int, int> datos = new Tuple<int, int>(temp, temp * valor);
                datosEntrenamiento.Add(datos);
            }
            MessageBox.Show("Datos generados");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int entrada = int.Parse(Interaction.InputBox("Inserta la entrada"));
            MessageBox.Show(entrada + " * " + valor + " = " + (entrada * neurona1).ToString());
            
        }
    }
}
