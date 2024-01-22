using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace MeVoyASuicidarjijijijiji
{
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //TiposLibrosClienteRel = List[][][], 
        //Primer indice = Libros
        //Segundo indice = Clientes
        //Tercer indice = Tienda
        List<string[][][]> TipoLibrosClientesRel = new List<string[][][]>();

        void Initialize()
        {
            
        }    

        void pruebas()
        {
            var result = TipoLibrosClientesRel.CountDimension();
            string[] hola = { "Prueba" };
            for (int i = 0; i < 10; i++) { hola.ToArray(); TipoLibrosClientesRel[i][0][0] = hola; }
            MessageBox.Show(result.x.ToString());
        }
    }
}
