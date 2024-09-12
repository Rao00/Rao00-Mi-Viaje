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
using System.Text.RegularExpressions;

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Persona PersonaData = new Persona();

        private void bInsertar_Click(object sender, EventArgs e)
        {
            int edadTemp;
            string SexoTemp;
            PersonaData.Name = (Interaction.InputBox("Introduce tu nombre"));
            while (!Regex.IsMatch(PersonaData.Name, @"^[a-zA-Z]+$"))
                PersonaData.Name = (Interaction.InputBox("Introduce tu nombre"));

            edadTemp = int.Parse(Interaction.InputBox("Introduce una edad"));
            while (edadTemp > 127 || edadTemp < 0)
            {
                MessageBox.Show("Edad no valida, edades comprendidas entre 127 y 1");
                edadTemp = int.Parse(Interaction.InputBox("Introduce una edad"));
            }
            PersonaData.Edad = edadTemp;
            while (PersonaData.Telefono.Length != 9)
            {
                PersonaData.Telefono = (Interaction.InputBox("Introduce tu numero de telefono"));
            }
            SexoTemp = Interaction.InputBox("Introduce la inicial de tu genero");
            while (SexoTemp.Length != 1)
            {
                MessageBox.Show("Introduce solo una letra");
                SexoTemp = Interaction.InputBox("Introduce la inicial de tu genero");
            }
            PersonaData.Sexo = char.Parse(SexoTemp);
            PersonaData.Casado = PreguntarEstadoCivil();
        }
        private bool PreguntarEstadoCivil()
        {
            DialogResult temp = MessageBox.Show("Estas casad#?", "", MessageBoxButtons.YesNo);
            switch (temp)
            {
                case DialogResult.Yes:
                    return true;
                case DialogResult.No:
                    return false;
                default: return false;
            }
        }
        private void LeerObjeto()
        {
            string salida = "Nombre: " + PersonaData.Name;
            salida += $"\nEdad: {PersonaData.Edad}";
            salida += $"\nTelefono: {PersonaData.Telefono}";
            salida += $"\nSexo: {PersonaData.Sexo}";
            if (PersonaData.Casado)
            {
                salida += $"\nCasado: En efecto querido caballere";
            }
            else if (!PersonaData.Casado)
            {
                salida += $"\nCasado: Tengo dinero y tu no";
            }

            MessageBox.Show(salida);
        }

        private void bLeer_Click(object sender, EventArgs e)
        {
            LeerObjeto();
        }
    }
}
