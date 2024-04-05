using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace Programa_de_Gestion_de_Camas
{
    public partial class PagPrincipal : Form
    {
        List<Plantas> ListaPlantas = new List<Plantas>();
        List<List<Label>> ListaLabels = new List<List<Label>>();

        public PagPrincipal()
        {
            InitializeComponent();
            ListaPlantas = LeerXml();
            AgruparLabels();
        }

        private List<Plantas> LeerXml()
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
                    Plantas planta = new Plantas(nombrePlanta);
                    ListaPlantas.Add(planta);
                    nombrePlanta = string.Empty;
                }

                if (xml.Name == "servicio" && !xml.IsEmptyElement)
                {
                    XmlReader xmlTemp = xml.ReadSubtree();
                    Servicio servicio = new Servicio();
                    while (xmlTemp.Read())
                    {
                        if (xmlTemp.Name == "nombre")
                        {
                            servicio.Nombre = xmlTemp.ReadElementContentAsString();
                        }
                        if (xmlTemp.Name == "media")
                        {
                            MessageBox.Show("gferwhiubjoqwefoibghuwegt hiouygq3gr iohpuy");
                            servicio.MediaAnual = int.Parse(xmlTemp.ReadElementContentAsString());
                        }
                        if (xmlTemp.Name == "camas")
                        {
                            servicio.NumCamasActuales = int.Parse(xmlTemp.ReadElementContentAsString());
                        }
                        if (servicio.Nombre.Length > 0 && servicio.MediaAnual > 0 && servicio.NumCamasActuales > 0)
                        {
                            MessageBox.Show(servicio.Nombre);
                            MessageBox.Show(servicio.MediaAnual.ToString());
                            MessageBox.Show(servicio.NumCamasActuales.ToString());
                            ListaPlantas[i].List.Add(servicio);
                            servicio = new Servicio();
                        }
                    }
                    i++;
                }
            }
            return ListaPlantas;
        }

        private void AgruparLabels()
        {
            ListaLabels.Add(new List<Label> { lbCamasN1, lbCamasN2, lbCamasN3 });
            ListaLabels.Add(new List<Label> { lbCamasC1, lbCamasC2, lbCamasC3 });
            ListaLabels.Add(new List<Label> { lbCamasS1, lbCamasS2, lbCamasS3 });
        }

        private void btnSegundaP_Click(object sender, EventArgs e)
        {
            string numPlanta = "2";
            int i;
            lPlanta.Text = "Segunda Planta";
            foreach(Plantas planta in ListaPlantas)
            {
                MessageBox.Show(planta.List.Count.ToString());
                if (planta.Nombre.StartsWith(numPlanta))
                {
                    i = 0;
                    foreach (Servicio servicio in planta.List)
                    {
                        switch (planta.Nombre.Substring(1))
                        {
                            case "norte":
                                ListaLabels[0][i].Text = $"Camas en {servicio.Nombre} :";
                                MessageBox.Show($"Camas en {servicio.Nombre} :");
                                i++;
                                break;
                            case "centro":
                                ListaLabels[1][i].Text = $"Camas en {servicio.Nombre} :";
                                MessageBox.Show($"Camas en {servicio.Nombre} :");
                                i++;
                                break;
                            case "sur":
                                ListaLabels[2][i].Text = $"Camas en {servicio.Nombre} :";
                                MessageBox.Show($"Camas en {servicio.Nombre} :");
                                i++;
                                break;
                        }
                    }
                }
            }
            for(i = 0; i < 3; i++)
            {
                foreach(Label label in ListaLabels[i])
                {
                    if (label.Text.EndsWith("--"))
                    {
                        label.Hide();
                    }
                    else
                    {
                        label.Show();
                    }
                }
            }
        }
    }
}
