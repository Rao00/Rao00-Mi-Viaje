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

        List<object> ListPersonas = new List<object>();

        private void bInsertar_Click(object sender, EventArgs e)
        {
            ListPersonas.Add(insertarPersona());
        }

        private object insertarPersona()
        {
            int edadTemp;
            string SexoTemp;
            Persona persona = new Persona();
            persona.Name = (Interaction.InputBox("Introduce tu nombre"));
            while (!Regex.IsMatch(persona.Name, @"^[a-zA-Z]+$"))
                persona.Name = (Interaction.InputBox("Introduce tu nombre"));

            edadTemp = int.Parse(Interaction.InputBox("Introduce una edad"));
            while (edadTemp > 127 || edadTemp < 0)
            {
                MessageBox.Show("Edad no valida, edades comprendidas entre 127 y 1");
                edadTemp = int.Parse(Interaction.InputBox("Introduce una edad"));
            }
            persona.Edad = edadTemp;
            while (persona.Telefono.Length != 9)
            {
                persona.Telefono = (Interaction.InputBox("Introduce tu numero de telefono"));
            }
            SexoTemp = Interaction.InputBox("Introduce la inicial de tu genero");
            while (SexoTemp.Length != 1)
            {
                MessageBox.Show("Introduce solo una letra");
                SexoTemp = Interaction.InputBox("Introduce la inicial de tu genero");
            }
            persona.Sexo = char.Parse(SexoTemp);
            persona.Casado = PreguntarEstadoCivil();
            return persona;
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
        private void LeerObjeto(List<object> PersonasList)
        {
            string salida = "";
            foreach (Persona persona in PersonasList)
            {
                salida += "Nombre: " + persona.Name;
                salida += $"\nEdad: {persona.Edad}";
                salida += $"\nTelefono: {persona.Telefono}";
                salida += $"\nSexo: {persona.Sexo}";
                if (persona.Casado)
                {
                    salida += $"\nCasado: Si\n\n";
                }
                else if (!persona.Casado)
                {
                    salida += $"\nCasado: No\n\n";
                }
            }
            MessageBox.Show(salida);
        }

        private void bLeer_Click(object sender, EventArgs e)
        {
            LeerObjeto(ListPersonas);
        }
    }
}
