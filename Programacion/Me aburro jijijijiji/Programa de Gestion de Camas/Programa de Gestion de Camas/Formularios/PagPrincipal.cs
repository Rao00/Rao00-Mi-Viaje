using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace Programa_de_Gestion_de_Camas
{
    public partial class PagPrincipal : Form
    {
        List<Plantas> ListaPlantas = new List<Plantas>();
        List<Servicio> ServiciosExtras = new List<Servicio>();
        List<Tuple<List<Label>, List<Label>>> ListaLabels = new List<Tuple<List<Label>, List<Label>>>();

        public PagPrincipal()
        {
            InitializeComponent();
            LeerXml();
            AgruparLabels();
            ReiniciarLabels();
            AlghoritmoDeOrdenacion();
        }

        private void LeerXml()
        {
            string path = "..\\..\\Data\\DatosPlantas.xml";
            string pathExtras = "..\\..\\Data\\DatosServiciosExtras.xml";
            XmlReader xml = XmlReader.Create(path);
            XmlReader xmlExtras = XmlReader.Create(pathExtras);
            while (xml.Read())
            {
                if (xml.Name == "planta")
                {
                    XmlReader xmlPlanta = xml.ReadSubtree();
                    ListaPlantas.Add(LeerPlanta(xmlPlanta));
                    xml.Skip();
                }
            }
            ServiciosExtras = LeerServiciosExtra(xmlExtras);
        }

        private Plantas LeerPlanta(XmlReader xml)
        {
            string nombrePlanta = String.Empty;
            Plantas planta = new Plantas(nombrePlanta);
            Servicio servicio = new Servicio();
            while (xml.Read())
            {
                nombrePlanta = (xml.Name == "piso") ? xml.ReadElementContentAsString() : nombrePlanta;
                nombrePlanta = (xml.Name == "orientacion") ? nombrePlanta += $" {xml.ReadElementContentAsString().ToUpper()}" : nombrePlanta;
                planta.Nombre = (nombrePlanta.Length >= 4 && planta.Nombre.Length < 4) ? nombrePlanta : planta.Nombre;
                planta.MaxCamas = (xml.Name == "totalcamas") ? xml.ReadElementContentAsInt() : planta.MaxCamas;
                servicio.Nombre = (xml.Name == "nombre") ? xml.ReadElementContentAsString() : servicio.Nombre;
                servicio.MediaAnual = (xml.Name == "camas") ? int.Parse(xml.ReadInnerXml()) : servicio.MediaAnual;
                if (servicio.Nombre.Length > 0 && servicio.MediaAnual > 0)
                {
                    planta.List.Add(servicio);
                    nombrePlanta = string.Empty;
                    servicio = new Servicio();
                }
            }
            return planta;
        }

        private List<Servicio> LeerServiciosExtra(XmlReader xml)
        {
            List<Servicio> listaServicios = new List<Servicio>();
            Servicio servicio = new Servicio();
            while (xml.Read())
            {
                if (xml.Name == "servicio")
                {
                    servicio = new Servicio();
                }
                if (xml.Name == "nombre")
                {
                    servicio.Nombre = xml.ReadElementContentAsString();
                }
                if (xml.Name == "camas")
                {
                    servicio.MediaAnual = xml.ReadElementContentAsInt();
                    listaServicios.Add(servicio);
                }
            }
            return listaServicios;
        }

        private void AgruparLabels()
        {
            for(int i = 0; i < 3; i++)
            {
                Tuple<List<Label>, List<Label>> tuple = new Tuple<List<Label>, List<Label>>(new List<Label>(), new List<Label>());
                ListaLabels.Add(tuple);
            }

            ListaLabels[0].Item1.AddRange(new List<Label> { lbCamasN1, lbCamasN2, lbCamasN3 });
            ListaLabels[0].Item2.AddRange(new List<Label> { lbNumCamasN1, lbNumCamasN2, lbNumCamasN3 });
            ListaLabels[1].Item1.AddRange(new List<Label> { lbCamasC1, lbCamasC2, lbCamasC3 });
            ListaLabels[1].Item2.AddRange(new List<Label> { lbNumCamasC1, lbNumCamasC2, lbNumCamasC3 });
            ListaLabels[2].Item1.AddRange(new List<Label> { lbCamasS1, lbCamasS2, lbCamasS3 });
            ListaLabels[2].Item2.AddRange(new List<Label> { lbNumCamasS1, lbNumCamasS2, lbNumCamasS3 });
        }

        private void SeleccionarPlantaBoton(string numPlanta)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            foreach (Plantas planta in ListaPlantas)
            {
                if (planta.Nombre.StartsWith(numPlanta))
                {
                    foreach (Servicio servicio in planta.List)
                    {
                        switch (planta.Nombre.Substring(2).ToLower())
                        {
                            case "norte":
                                ListaLabels[0].Item1[i].Text = $"Camas en {servicio.Nombre} :";
                                ListaLabels[0].Item2[i].Text = servicio.NumCamasActuales.ToString();
                                lbTotalN.Text = planta.TotalCamas.ToString();
                                lbRTotalN.Text = planta.TotalCamas.ToString();
                                i++;
                                break;
                            case "centro":
                                ListaLabels[1].Item1[j].Text = $"Camas en {servicio.Nombre} :";
                                ListaLabels[1].Item2[j].Text = servicio.NumCamasActuales.ToString();
                                lbTotalC.Text = planta.TotalCamas.ToString();
                                lbRTotalC.Text = planta.TotalCamas.ToString();
                                j++;
                                break;
                            case "sur":
                                ListaLabels[2].Item1[k].Text = $"Camas en {servicio.Nombre} :";
                                ListaLabels[2].Item2[k].Text = servicio.NumCamasActuales.ToString();
                                lbTotalS.Text = planta.TotalCamas.ToString();
                                lbRTotalS.Text = planta.TotalCamas.ToString();
                                k++;
                                break;
                        }
                    }
                }
                lbTotalCamas.Text = (int.Parse(lbRTotalN.Text) + int.Parse(lbRTotalC.Text) + int.Parse(lbRTotalS.Text)).ToString();
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < ListaLabels[i].Item1.Count; j++)
                {
                    if (ListaLabels[i].Item1[j].Text.EndsWith(" -- :"))
                    {
                        ListaLabels[i].Item2[j].Hide();
                        ListaLabels[i].Item1[j].Hide();
                    }
                    else
                    {
                        ListaLabels[i].Item2[j].Show();
                        ListaLabels[i].Item1[j].Show();
                    }
                }
            }
        }

        private void ReiniciarLabels()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < ListaLabels[i].Item1.Count; j++)
                {
                    ListaLabels[i].Item2[j].Show();
                    ListaLabels[i].Item1[j].Show();
                    ListaLabels[i].Item2[j].Text = "0";
                    ListaLabels[i].Item1[j].Text = "Camas en -- :";
                }
            }
        }

        private void btnSegundaP_Click(object sender, EventArgs e)
        {
            ReiniciarLabels();
            string numPlanta = "2";
            lPlanta.Text = "Segunda Planta";
            SeleccionarPlantaBoton(numPlanta);
        }

        private void btnTerceraP_Click(object sender, EventArgs e)
        {
            ReiniciarLabels();
            string numPlanta = "3";
            lPlanta.Text = "Tercera Planta";
            SeleccionarPlantaBoton(numPlanta);
        }

        private void btnCuartaP_Click(object sender, EventArgs e)
        {
            ReiniciarLabels();
            string numPlanta = "4";
            lPlanta.Text = "Cuarta Planta";
            SeleccionarPlantaBoton(numPlanta);
        }

        private void AlghoritmoDeOrdenacion()
        {
            int MaxCamasPorPlanta;
            foreach (Plantas planta in ListaPlantas)
            {
                MaxCamasPorPlanta = planta.MaxCamas;
                foreach (Servicio servicio in planta.List)
                {
                    if (MaxCamasPorPlanta - servicio.MediaAnual < 0)
                    {
                        servicio.NumCamasActuales = MaxCamasPorPlanta;
                        servicio.MediaAnual -= MaxCamasPorPlanta;
                        MaxCamasPorPlanta = 0;
                    }
                    else
                    {
                        MaxCamasPorPlanta -= servicio.MediaAnual;
                        servicio.NumCamasActuales = servicio.MediaAnual;
                    }
                }
            }
            foreach (Servicio servicioExtra in ServiciosExtras)
            {
                AlghoritmoDeDistribucion(servicioExtra);
            }
        }

        private void AlghoritmoDeDistribucion(Servicio servicio)
        {
            bool cont = true;
            int temp = int.MaxValue;
            Plantas plantaTemp = new Plantas("temp");
            for (int i = 0; i < ListaPlantas.Count; i++)
            {
                if (ListaPlantas[i].TotalCamas < temp)
                {
                    plantaTemp = ListaPlantas[i];
                    temp = ListaPlantas[i].TotalCamas;
                }
            }
            
            for (int i = 0; i < ListaPlantas.Count && cont; i++)
            {
                if (ListaPlantas[i].Nombre == plantaTemp.Nombre)
                {
                    int MaxCamasPorPlanta = ListaPlantas[i].MaxCamas;
                    if (MaxCamasPorPlanta - servicio.MediaAnual < 0)
                    {
                        servicio.NumCamasActuales = MaxCamasPorPlanta;
                        servicio.MediaAnual -= MaxCamasPorPlanta;
                    }
                    else
                    {
                        servicio.NumCamasActuales = servicio.MediaAnual;
                    }
                    ListaPlantas[i].Add(servicio);
                    cont = false;
                }
            }
            cont = true; 
        }
    }
}
