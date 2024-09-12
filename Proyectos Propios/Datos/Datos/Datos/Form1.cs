using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Net;
using HtmlAgilityPack;

namespace Datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProcesarReceta(string urlReceta, XmlDocument xmlDoc)
        {
            // Realizar la solicitud web y cargar el documento HTML de la receta
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(urlReceta);

            // Extraer los datos de la receta
            string nombreReceta = doc.DocumentNode.SelectSingleNode("//h1").InnerText.Trim();
            string calorias = doc.DocumentNode.SelectSingleNode("//span[contains(text(), 'calories')]/following-sibling::span").InnerText.Trim();
            string proteina = doc.DocumentNode.SelectSingleNode("//span[contains(text(), 'protein')]/following-sibling::span").InnerText.Trim();
            string grasas = doc.DocumentNode.SelectSingleNode("//span[contains(text(), 'fat')]/following-sibling::span").InnerText.Trim();
            string azucares = doc.DocumentNode.SelectSingleNode("//span[contains(text(), 'sugars')]/following-sibling::span").InnerText.Trim();

            // Crear nodo de receta
            XmlElement recetaNode = xmlDoc.CreateElement("receta");
            xmlDoc.DocumentElement.AppendChild(recetaNode);

            // Agregar atributos de la receta
            recetaNode.SetAttribute("nombre", nombreReceta);
            recetaNode.SetAttribute("calorias", calorias);
            recetaNode.SetAttribute("proteina", proteina);
            recetaNode.SetAttribute("grasas", grasas);
            recetaNode.SetAttribute("azucares", azucares);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // URL de la página de recetas
            string url = "https://www.allrecipes.com";

            // Crear documento XML
            XmlDocument xmlDoc = new XmlDocument();
            XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDoc.AppendChild(xmlDeclaration);

            // Crear elemento raíz
            XmlElement raiz = xmlDoc.CreateElement("recetas");
            xmlDoc.AppendChild(raiz);

            // Realizar la solicitud web y cargar el documento HTML
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);

            // Obtener enlaces de recetas
            var enlacesRecetas = doc.DocumentNode.SelectNodes("//a[@class='tout__titleLink']");
            if (enlacesRecetas != null)
            {
                foreach (var enlace in enlacesRecetas)
                {
                    string enlaceReceta = enlace.GetAttributeValue("href", "");
                    ProcesarReceta(url + enlaceReceta, xmlDoc);
                }
            }

            // Guardar el documento XML
            xmlDoc.Save("recetas.xml");
            MessageBox.Show("Archivo XML creado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}