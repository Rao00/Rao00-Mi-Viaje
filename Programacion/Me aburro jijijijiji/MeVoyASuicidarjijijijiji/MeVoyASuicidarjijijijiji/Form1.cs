using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeVoyASuicidarjijijijiji
{
    public static class ModLista
    {
        public static (int x, int y, int z) CountDimension<T>(this List<T[,,]> list, List<T[,,]>target)
        {
            int countX = 0;
            int countY = 0;
            int countZ = 0;

            

            try
            {
                target = list;
                while (target(countX,0,0) != null)
                {
                    countX++;
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
        List<string[,,]> TipoLibrosClientesRel = new List<string[,,]>();

        void Initialize()
        {

        }
            
        

        void pruebas()
        {
            
        }
    }
}
