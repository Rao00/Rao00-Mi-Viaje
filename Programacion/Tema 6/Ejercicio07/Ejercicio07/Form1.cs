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

namespace Ejercicio07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> words = new List<string>();

        (string Word, DialogResult IResult) MoreWords()
        {
            string result;
            result = Interaction.InputBox("Insert your word");
            DialogResult more = MessageBox.Show("Do you want more words", "Insert your word", MessageBoxButtons.YesNo);
            return (result, more);
        }

        List<string> AddValuesInOrder(List<string> list, string WordToAdd)
        {
            bool execute = true;
            for (int i = 0; i < list.Count() && execute; i++) 
            {
                int result = String.Compare(list[i], WordToAdd);
                if (result > 0)
                {
                    list.Insert(i, WordToAdd);
                    execute = false;
                }
            }
            return list;
        }

        void ReadList <T>(List<T> list)
        {
            string output = null;
            foreach (T value in list) { output += value + ", "; }
            MessageBox.Show(output);
        }

        private void bNewWords_Click(object sender, EventArgs e)
        {
            DialogResult comparison = DialogResult.Yes;
            while (comparison == DialogResult.Yes)
            {
                var WordNew = MoreWords();
                comparison = WordNew.IResult;
                words = AddValuesInOrder(words, WordNew.Word);
            }
        }

        private void bSortWords_Click(object sender, EventArgs e)
        {
            ReadList<string>(words);
        }
    }
}
