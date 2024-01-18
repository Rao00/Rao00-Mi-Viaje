using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeVoyASuicidarjijijijiji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //TiposLibrosClienteRel = List[][][], 
        //Primer indice = Libros
        //Segundo indice = Clientes
        //Tercer indice = Clase libro
        List<int[][][]> TipoLibrosClientesRel = new List<int[][][]>();

        private void AddCliente(string NomCliente)
        {
            int x = 0; int y = 0; int z = 0;
            while(x < TipoLibrosClientesRel.Count)

        }
    }
}
