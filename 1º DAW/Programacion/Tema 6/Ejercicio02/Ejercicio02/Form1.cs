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
        List<int> even = new List<int>();

        private void bExecute_Click(object sender, EventArgs e)
        {
            string output = null;
            DialogResult MoreValues = DialogResult.Yes;
            int i = 0;
            //Random rand = new Random();
            //while (values.Count() < NVALUES) { values.Add(rand.Next(1, 100)); }
            while (MoreValues == DialogResult.Yes) 
            {
                values.Add(int.Parse(Interaction.InputBox("")));
                MoreValues = MessageBox.Show("Do you want to add more values?", "", MessageBoxButtons.YesNo);
            }
            while (i < values.Count()) 
            {
                if (values[i] % 2 == 0) { even.Add(values[i]); values.RemoveAt(i); }
                else { i++; }
            }
            foreach (int value in even) { output += value + ","; }
            MessageBox.Show(output);
        }
    }
}
