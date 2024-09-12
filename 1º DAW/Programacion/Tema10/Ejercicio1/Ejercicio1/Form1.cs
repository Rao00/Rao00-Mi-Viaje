using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarDatos(object sender = null, EventArgs e = null)
        {
            label1.Text = $"{profesoresBindingSource.Position + 1} / {profesoresBindingSource.Count}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Instituto__1_DataSet.Profesores' Puede moverla o quitarla según sea necesario.
            this.profesoresTableAdapter.Fill(this._Instituto__1_DataSet.Profesores);
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            profesoresBindingSource.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            profesoresBindingSource.MovePrevious();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            profesoresBindingSource.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            profesoresBindingSource.MoveLast();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            profesoresBindingSource.AddNew();
            MostrarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            profesoresBindingSource.EndEdit();
            profesoresTableAdapter.Update(_Instituto__1_DataSet);
            MostrarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            profesoresBindingSource.RemoveCurrent();
            profesoresTableAdapter.Update(_Instituto__1_DataSet);
            MostrarDatos();
        }
    }
}
