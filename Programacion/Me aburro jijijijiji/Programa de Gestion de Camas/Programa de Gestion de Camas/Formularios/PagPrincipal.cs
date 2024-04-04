using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Programa_de_Gestion_de_Camas
{
    public partial class PagPrincipal : Form
    {
        List<Plantas> ListaPlantas = new List<Plantas>();
        public PagPrincipal()
        {
            InitializeComponent();
            ReadXml();
        }

        private void ReadXml()
        {
            int i = 0;
            string nombrePlanta = String.Empty;
            string path = "..\\..\\Data\\DatosPlantas.xml";
            XmlReader xml = XmlReader.Create(path);
            while (xml.Read())
            {
                nombrePlanta = (xml.Name == "piso") ? xml.ReadElementContentAsString() : nombrePlanta;
                nombrePlanta = (xml.Name == "orientacion") ? nombrePlanta += $" {xml.ReadElementContentAsString().ToUpper()}" : nombrePlanta;
                if (nombrePlanta.Length >= 4)
                {
                    MessageBox.Show(nombrePlanta);
                    Plantas planta = new Plantas(nombrePlanta);
                    ListaPlantas.Add(planta);
                    
                }

                if (xml.Name == "servicio")
                {
                    XmlReader xmlTemp = xml.ReadSubtree();
                    Servicio servicio = new Servicio();
                    while (xmlTemp.Read()) 
                    { 
                        if (xml.Name == "nombre")
                        {
                            servicio.Nombre = xml.ReadElementContentAsString();
                            servicio.MediaAnual = int.Parse(xml.GetAttribute(0));
                        }
                        if (xml.Name == "camas")
                        {
                            servicio.NumCamasActuales = int.Parse(xml.ReadElementContentAsString());
                        }
                    }
                    ListaPlantas[i].Add(servicio);
                    xml.Skip();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
