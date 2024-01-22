using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeQuieroMorirBaseDeDatos
{
public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<List<string[][]>> ListaPrincipal = new List<List<string[][]>>();//Lista de bases de datos

        void LeerDatos(string ruta, string BD)
        {
            try
            {
                StreamReader sr = new StreamReader($"C:\\Users\\Carles\\source\\repos\\DAW_1-_rep\\Programacion\\Me aburro jijijijiji\\MeQuieroMorirBaseDeDatos\\data\\{BD}.txt");
                string line = sr.ReadLine();
                while(line != null)
                {

                }
            }
        }

        private void bAñadirDatos_Click(object sender, EventArgs e)
        {

        }
    }
    public static class ListExtensions
    {
        public static (int x, int y, int z) CountDimension<T>(this List<T[][][]> list)
        {
            int countX = 0;
            int countY = 0;
            int countZ = 0;
            try
            {
                while (list[countX][0][0] != null)
                {
                    countX++;
                }
            }
            catch { }
            try
            {
                while (list[0][countY][0] != null)
                {
                    countY++;
                }
            }
            catch { }
            try
            {
                while (list[0][0][countZ] != null)
                {
                    countZ++;
                }
            }
            catch { }
            return (countX, countY, countZ);
        }
    }
}
