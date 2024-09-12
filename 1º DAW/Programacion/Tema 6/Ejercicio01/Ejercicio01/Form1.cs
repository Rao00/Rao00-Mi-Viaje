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

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> PData = new List<int>();

        void Confirmation()
        {
            MessageBox.Show("Operation Succesfull");
        } //Confirmation MessageBox

        //Elements GroupBox
        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                PData.Add(int.Parse(Interaction.InputBox("", "Add an Element", "Introduce your element")));
                Confirmation();
            }
            catch(Exception) { MessageBox.Show("Not valid element"); }
        } //Add Button

        private void bInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int position = int.Parse(Interaction.InputBox("", "Select position", "Introduce the position"));
                int element = int.Parse(Interaction.InputBox("", "Introduce an Element", "Introduce your element to introduce"));
                PData.Insert(position, element);
                Confirmation();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Not an existing position"); }
            catch (FormatException) { MessageBox.Show("Not an integer value"); }
        } //Insert Button

        private void bShow_Click(object sender, EventArgs e)
        {
            string output = string.Empty;
            foreach(int value in PData) { output += $"{value}, "; }
            MessageBox.Show(output);
        } //Show Button

        private void bFirstPosition_Click(object sender, EventArgs e)
        {
            try
            {
                int element = int.Parse(Interaction.InputBox("", "Add an Element", "Introduce your element"));
                if (PData.Contains(element)) { MessageBox.Show($"First time the value apeard is {PData.IndexOf(element)} index"); }
                else { MessageBox.Show("Not an existing value"); }
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Not an existing value"); }
            catch (FormatException) { MessageBox.Show("Not an integer value"); }
        } //First Position of a value Button

        private void bPositionValue_Click(object sender, EventArgs e)
        {
            try
            {
                string output = string.Empty;
                int value = int.Parse(Interaction.InputBox("", "Add an Element", "Introduce your element"));
                for(int i = 0; i < PData.Count(); i++)
                {
                    if (PData[i] == value)
                        output += $"Value {value} in the Index {i}\n";
                }
                MessageBox.Show(output);
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Not an existing value"); }
            catch (FormatException) { MessageBox.Show("Not an integer value"); }
        } //Position of a value Button

        //Sort and Remove GroupBox
        private void bRemoveFirst_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(Interaction.InputBox("", "Add an Element", "Introduce your element"));
                if (PData.Contains(value)) { PData.Remove(value); }
                else { throw new ArgumentOutOfRangeException(); }
                Confirmation();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Not an existing value"); }
            catch (FormatException) { MessageBox.Show("Not an integer value"); }
        } //Remove (first) value Button

        private void bRemoveAllValues_Click(object sender, EventArgs e)
        {
            try
            {
                if (PData.Count > 0) { PData.Clear(); Confirmation(); }
                else { throw new Exception("List already empty"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        } //Clear list Button

        private void bRemovePosition_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(Interaction.InputBox("", "Add an Element", "Introduce your element"));
                PData.RemoveAt(index);
                Confirmation();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Not an existing value"); }
            catch (FormatException) { MessageBox.Show("Not an integer value"); }
        } //Remove Especific Position

        private void bRemoveAllElements_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(Interaction.InputBox("", "Element to clean", "Insert your element"));
                if (PData.Count > 0 && PData.Contains(value)) 
                {
                    PData.RemoveAll(i => i == value);
                    Confirmation();
                }
                else { throw new Exception("List already empty"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        } //Remove ALL Elements Button

        private void bSort_Click(object sender, EventArgs e)
        {
            try
            {
                if (PData.Count > 0) { PData.Sort(); Confirmation(); }
                else { throw new Exception("List is empty"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        } //Sort list Button
    }
}
