using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

/*
 * 
 * -0.1f = error
 * 0.0f = Salto de Tabla (Siguiente tabla)
 * 0.1f = Titulo Base Datos
 * 0.2f = Titulo Tabla
 * 0.3f = Columna
 * 0.4f = Registro (Fila)
 * 
 */

namespace MeQuieroMorirBaseDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> ListaPrincipal = new List<string>();//Lista de bases de datos

        string DataBase = null;
        string Table = null;

        private void initTreeView(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(".\\data\\JARDINERIA.txt");

            string line = sr.ReadLine();

            while (line != null)
            {
                string[] split = line.Split('~');
                switch (split[0])
                {
                    case "/bd":
                        NewDataBase(split[1]);
                        break;
                    case "/t":
                        NewTable(DataBase, split[1]);
                        break;
                    case "/c":
                        switch (split.Length)
                        {
                            case 3:
                                NewColumn(DataBase, Table, split[1], split[2]);
                                break;
                            case 4:
                                NewColumn(DataBase, Table, split[1], split[2], int.Parse(split[3]));
                                break;
                            default:
                                NewColumn(DataBase, Table, split[1]);
                                break;
                        }
                        break;
                    case "/f":

                    case "/s":
                        Table = split[1];
                        break;
                }
                line = sr.ReadLine();
            }
            catch { }
        }

        private void NewDataBase(string dataBase) 
        { 
            trV.Nodes.Add(dataBase);
            DataBase = dataBase;
        }
        private void NewTable(string dataBase, string table) 
        {
            trV.Nodes[0].Nodes.Add(table);
            Table = table;
        }
        private void NewColumn(string dataBase, string table, string column, string typeColumn = "null", int autoAdd = 0) { }
    }
}
