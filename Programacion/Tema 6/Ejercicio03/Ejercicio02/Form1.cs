﻿using System;
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
        List<int> prime = new List<int>();

        bool PrimeNum(int num)
        {
            bool primeNum = true;
            for(int i = 2; i < num; i++)
            {
                if(num%i == 0) { primeNum = false; break; }
            }
            return primeNum;
        }

        private void bExecute_Click(object sender, EventArgs e)
        {
            //Random rand = new Random();
            //while (values.Count() < NVALUES) { values.Add(rand.Next(1, 100)); }
            string output = null;
            int i = 0;
            DialogResult MoreValues = DialogResult.Yes;
            while (MoreValues == DialogResult.Yes) 
            {
                values.Add(int.Parse(Interaction.InputBox("")));
                MoreValues = MessageBox.Show("Do you want to add more values?", "", MessageBoxButtons.YesNo);
            }
            while (i < values.Count()) 
            {
                if (PrimeNum(values[i]))
                {
                    prime.Add(values[i]);
                    values.Remove(values[i]);  
                }
                i++;
            }
            foreach (int value in prime) { output += value + ","; }
            MessageBox.Show(output);
        }
    }
}
