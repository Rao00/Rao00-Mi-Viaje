using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 10;

        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        List<int> list3 = new List<int>();

        void ReadList(List<int> list)
        {
            string output = null;
            foreach (int value in list) { output += value + ", "; }
            MessageBox.Show(output);
        }

        //void AddNum(List<int> list)
        //{
        //    int value = int.Parse(Interaction.InputBox("", $"Value to add in {list}"));
        //    list.Add(value);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //DialogResult MoreValues = DialogResult.Yes;
            //while (MoreValues == DialogResult.Yes)
            //{
            //    AddNum(list1);
            //    MoreValues = MessageBox.Show("Do you want more values?", "", MessageBoxButtons.YesNo);
            //}

            Random rand = new Random();
            for(int i = 0; i < TAM; i++)
            {
                list1.Add(rand.Next(0, 40));
            }
            list1.Sort();
            ReadList(list1);
        }

        private void bNewList2_Click(object sender, EventArgs e)
        {
            //DialogResult MoreValues = DialogResult.Yes;
            //while (MoreValues == DialogResult.Yes)
            //{
            //    AddNum(list2);
            //    MoreValues = MessageBox.Show("Do you want more values?", "", MessageBoxButtons.YesNo);
            //}

            Random rand = new Random();
            for (int i = 0; i < TAM; i++)
            {
                list2.Add(rand.Next(0, 40));
            }
            list2.Sort();
            ReadList(list2);
        }

        private void bList3_Click(object sender, EventArgs e)
        {
            foreach(int value in list1)
            {
                list3.Add(value);
            }
            foreach (int value in list2)
            {
                if (!list3.Contains(value))
                    list3.Add(value);
            }
            list3.Sort();
            ReadList(list3);
        }

        private void bCleanList_Click(object sender, EventArgs e)
        {
            list1.Clear();
            list2.Clear();
            list3.Clear();
        }
    }
}
