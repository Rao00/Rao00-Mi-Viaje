using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;

namespace Ejercicio08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateNewWinners();
        }

        List<int> WinNums = new List<int>();
        List<int> UserNums = new List<int>();

        void GenerateNewWinners()
        {
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                WinNums.Add(rand.Next(1, 50));
            }
        }

        void ReadList(List<int> list)
        {
            string output = null;
            foreach (int value in list) { output += value + ", "; }
            MessageBox.Show(output);
        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            DialogResult AddMoreNum = DialogResult.Yes;
            int counter = 0;
            while (AddMoreNum == DialogResult.Yes)
            {
                int UserInput = int.Parse(Interaction.InputBox("Insert your number", "Insert your number"))
                if(UserInput < 50 && UserInput > 0)
                {
                    UserNums.Add(UserInput);
                    AddMoreNum = MessageBox.Show("Do you have more number", "", MessageBoxButtons.YesNo);
                }
                else { MessageBox.Show($"The number {UserInput} must be between 49 and 1"); }
                
            }
            foreach (int num in UserNums)
            {
                if (WinNums.Contains(num) && counter < 6)
                {
                    counter++;
                    MessageBox.Show($"The number {num} is a winner num, only {6 - counter} to win the prize");
                }
                if (counter == 6)
                {
                    MessageBox.Show($"You win the prize");
                }
            }
        }
    }
}
