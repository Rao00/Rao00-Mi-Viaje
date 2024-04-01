using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Programa_de_Gestion_de_Camas
{
    class Paneles
    {
        public static System.Windows.Forms.Control General(int posx, int posy, int alto, int largo, string nombre, Color background, List<int[]> servicios,int padding = 0)
        {
            System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label numCantidadCamasUnidad = new System.Windows.Forms.Label();
            System.Windows.Forms.Label textoCantidadCamasUnidad = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lTotalCamas = new System.Windows.Forms.Label();
            System.Windows.Forms.Panel pGeneral = new System.Windows.Forms.Panel();
            System.Windows.Forms.Label lPlanta = new System.Windows.Forms.Label();

            lTotalCamas.Font = new System.Drawing.Font("Monospac821 BT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lTotalCamas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lTotalCamas.Location = new System.Drawing.Point(286, 129);
            lTotalCamas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lTotalCamas.Name = "lTotalCamas";
            lTotalCamas.Size = new System.Drawing.Size(112, 75);
            lTotalCamas.TabIndex = 1;
            lTotalCamas.Text = "70";

            pGeneral.BackColor = background;

            pGeneral.Controls.Add(label5);
            pGeneral.Controls.Add(label4);
            pGeneral.Controls.Add(label2);
            pGeneral.Controls.Add(label3);
            pGeneral.Controls.Add(lPlanta);
            pGeneral.Controls.Add(lTotalCamas);
            pGeneral.Controls.Add(label1);

            pGeneral.Location = new System.Drawing.Point(posy, posx);
            pGeneral.Margin = new System.Windows.Forms.Padding(padding);
            pGeneral.Name = nombre;
            pGeneral.Size = new System.Drawing.Size(largo, alto);
            pGeneral.TabIndex = 4;
            
            return pGeneral;
        }
    }
}
