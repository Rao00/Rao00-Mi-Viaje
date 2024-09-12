using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int NVALUES = 20;
        List<int> values = new List<int>();
        List<double> exponents = new List<double>();
        List<double> results = new List<double>();

        private void bExecute_Click(object sender, EventArgs e)
        {
            string output = null;
            int i = 0;
            DialogResult MoreValues = DialogResult.Yes;
            while (MoreValues == DialogResult.Yes && values.Count() <= 10) 
            {
                values.Add(int.Parse(Interaction.InputBox("Values")));
            }
            while (MoreValues == DialogResult.Yes && exponents.Count() <= 10)
            {
                exponents.Add(int.Parse(Interaction.InputBox("Exponents")));
            }
            while (i < values.Count()) 
            {
                results.Add(Math.Pow(values[i], exponents[i]));
                i++;
            }
            foreach (int value in results) { output += value + ","; }
            MessageBox.Show(output);
        }
    }
}
