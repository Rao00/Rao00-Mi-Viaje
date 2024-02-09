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
using System.Net.Mail;

/*
 * 
 * -0.1f = error
 * 0.0f = Salto de Tabla (Siguiente tabla)
 * 0.1f = Titulo Base Datos
 * 0.2f = Titulo Tabla
 * 0.3f = Columna
 * 0.4f = Registro (Fila)
 * 
 */

namespace MeQuieroMorirBaseDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> ListaPrincipal = new List<string>();//Lista de bases de datos
        string[,] tabla = new string[0,0];

        float TipoDeDato(string linea)
        {
            if (linea.Contains("/s")) { return 0.0f; }
            if (linea.Contains("/b")) { return 0.1f; }
            if (linea.Contains("/t")) { return 0.2f; }
            if (linea.Contains("/c")) { return 0.3f; }
            if (linea.Contains("/f")) { return 0.4f; }
            return -0.1f;
        }

        string[] AddDatastring<T>(string[] matriz, T data, bool fila = true)
        {
            matriz.CountDimension();
            return matriz;
        }

        void LeerDatos(string ruta, string BD)
        {
            try
            {
                StreamReader sr = new StreamReader($"C:\\Users\\Carles\\source\\repos\\DAW_1-_rep\\Programacion\\Me aburro jijijijiji\\MeQuieroMorirBaseDeDatos\\data\\{BD}.txt");
                string line = sr.ReadLine();
                while (line != null)
                {
                    if (TipoDeDato(line) == 0.1f)
                    {
                        continue;
                    }
                }
            }
            catch { }
        }

        private void bAñadirDatos_Click(object sender, EventArgs e)
        {

        }
    }

    public static class ListExtensions
    {
        public static (int x, int y, int z) CountDimension(this string[] list)
        {
            int countX = 0;
            int countY = 0;
            int countZ = 0;
            try
            {
                while (list != null)
                {
                    countX++;
                }
            }
            catch { }
            try
            {
                while (list != null)
                {
                    countY++;
                }
            }
            catch { }
            return (countX, countY, countZ);
        }
        
    }
}
