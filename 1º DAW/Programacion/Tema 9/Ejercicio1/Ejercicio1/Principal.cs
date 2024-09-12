using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.VisualBasic;

namespace Ejercicio1
{
    public partial class Principal : Form
    {
        Color colorError = Color.FromArgb(255, 255, 192, 192);
        Color colorBlanco = Color.FromArgb(255, 255, 255, 255);

        DataSet dataProfesores;
        SqlDataAdapter adapterProfesores;
        SqlConnection sql;

        int pos = 0;
        bool registroDNI = false;
        bool registroNombre = false;
        bool registroApellidos = false;
        bool registroTelefono = false;
        bool registroEmail = false;

        List<TextBox> txts = new List<TextBox>();

        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sql = new SqlConnection(CargarRuta());
            sql.Open();
            string consuta = "SELECT * FROM Profesores";
            dataProfesores = new DataSet();
            adapterProfesores = new SqlDataAdapter(consuta, sql);
            adapterProfesores.Fill(dataProfesores, "Profesores");
            if (dataProfesores.Tables["Profesores"].Rows.Count > 0)
            {
                CambiarDatos(dataProfesores.Tables["Profesores"].Rows[pos]);
            }
            else
            {
                foreach (TextBox txt in txts)
                {
                    txt.Text = string.Empty;
                }
                lblNumRegistro.Text = "Sin Registros";
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
            }
            ComprobarBotones();
            sql.Close();
            btnLimpiar.Enabled = HabilitarLimpiar();
            
            txts.Add(txtDni);
            txts.Add(txtNombre);
            txts.Add(txtApellidos);
            txts.Add(txtTelefono);
            txts.Add(txtEmail);

        }

        private void CambiarDatos(DataRow dataFila)
        {
            lblNumRegistro.Text = $"Registro = {pos + 1} | {dataProfesores.Tables["Profesores"].Rows.Count}";
            txtDni.Text = dataFila[0].ToString();
            txtNombre.Text = dataFila[1].ToString();
            txtApellidos.Text = dataFila[2].ToString();
            txtTelefono.Text = dataFila[3].ToString();
            txtEmail.Text = dataFila[4].ToString();
        }

        private string CargarRuta()
        {
            string relPath = @"..\..\..\..\Base de Datos\Instituto.mdf";
            relPath = Path.GetFullPath(relPath);
            string path = @"Data Source = (LocalDB)\MSSQLLocalDB;" +
                          $"Initial Catalog = {relPath};" +
                          "Integrated Security = True;" +
                          "Connect Timeout = 60";
            return path;
        }

        private bool HabilitarLimpiar()
        {
            if ((txtDni.Text.Length, txtNombre.Text.Length, txtApellidos.Text.Length, txtTelefono.Text.Length, txtEmail.Text.Length) == (0, 0, 0, 0, 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void LeerBaseDeDatos(int _pos)
        {
            sql.Open();
            DataRow dataFila = dataProfesores.Tables["Profesores"].Rows[_pos];
            CambiarDatos(dataFila);
            sql.Close();
        }

        private void ComprobarBotones()
        {
            if (pos <= 0)
            {
                btnAnterior.Enabled = false;
                btnAnterior.BackColor = SystemColors.ControlLight;
                btnPrincipio.Enabled = false;
                btnPrincipio.BackColor = SystemColors.ControlLight;
            }
            else
            {
                btnAnterior.Enabled = true;
                btnAnterior.BackColor = SystemColors.ButtonHighlight;
                btnPrincipio.Enabled = true;
                btnPrincipio.BackColor = SystemColors.ButtonHighlight;
            }

            if (pos >= dataProfesores.Tables["Profesores"].Rows.Count - 1)
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.BackColor = SystemColors.ControlLight;
                btnFinal.Enabled = false;
                btnFinal.BackColor = SystemColors.ControlLight;
            }
            else
            {
                btnSiguiente.Enabled = true;
                btnSiguiente.BackColor = SystemColors.ButtonHighlight;
                btnFinal.Enabled = true;
                btnFinal.BackColor = SystemColors.ButtonHighlight;
            }
        }

        private bool ComprobarValidez()
        {
            if (registroDNI && registroNombre && registroApellidos && registroTelefono && registroEmail)
            {
                return true;
            }
            else { return false; }
        }

        private bool ComprobarValidezSinDNI()
        {
            if (registroNombre && registroApellidos && registroTelefono && registroEmail)
            {
                return true;
            }
            else { return false; }
        }

        private bool ExisteDNI(string dni)
        {
            foreach (DataRow row in dataProfesores.Tables["Profesores"].Rows)
            {
                if (row[0].ToString() == txtDni.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private bool ComprobarCambios()
        {
            bool cambio = false;
    
            for(int i = 0; i < 5; i++) 
            { 
                if (dataProfesores.Tables["Profesores"].Rows[pos][i].ToString() != txts[i].Text)
                {
                    cambio = true;
                }
            }

            return cambio;
        }

        private void Actualizar()
        {
            if (ExisteDNI(txtDni.Text))
            {
                if (ComprobarValidezSinDNI())
                {
                    DataRow nuevoRegistro = dataProfesores.Tables["Profesores"].Rows[pos];
                    nuevoRegistro[0] = txtDni.Text;
                    nuevoRegistro[1] = txtNombre.Text;
                    nuevoRegistro[2] = txtApellidos.Text;
                    nuevoRegistro[3] = txtTelefono.Text;
                    nuevoRegistro[4] = txtEmail.Text;
                    SqlCommandBuilder cb = new SqlCommandBuilder(adapterProfesores);
                    adapterProfesores.Update(dataProfesores, "Profesores");
                    ComprobarBotones();
                    CambiarDatos(dataProfesores.Tables["Profesores"].Rows[pos]);
                }
                else
                {
                    MessageBox.Show("Hay campos erroneos");
                }
            }
            else
            {
                MessageBox.Show($"El profesor con DNI {txtDni.Text} no existe");
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            btnLimpiar.Enabled = HabilitarLimpiar();
            if (!Regex.IsMatch(txtDni.Text.ToUpper(), @"^[0-9]{8}[A-Z]{1}$") && txtDni.Text.Length != 0)
            {
                registroDNI = false;
                txtDni.BackColor = colorError;
            }
            else
            {
                registroDNI = (txtDni.Text.Length > 0) ? true : false;
                txtDni.BackColor = colorBlanco;
            }
            foreach (DataRow row in dataProfesores.Tables["Profesores"].Rows)
            {
                if (row[0].ToString() == txtDni.Text)
                {
                    registroDNI = false;
                    txtDni.BackColor = colorError;
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            btnLimpiar.Enabled = HabilitarLimpiar();
            if (!Regex.IsMatch(txtNombre.Text, @"^[A-Z][a-z]+$") && txtNombre.Text.Length != 0)
            {
                registroNombre = false;
                txtNombre.BackColor = colorError;
            }
            else
            {
                registroNombre = (txtNombre.Text.Length > 0) ? true : false;
                txtNombre.BackColor = colorBlanco;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            btnLimpiar.Enabled = HabilitarLimpiar();
            if (!Regex.IsMatch(txtTelefono.Text, @"^[0-9]{9}$") && txtTelefono.Text.Length != 0)
            {
                registroTelefono = false;
                txtTelefono.BackColor = colorError;
            }
            else
            {
                registroTelefono = (txtTelefono.Text.Length > 0) ? true : false;
                txtTelefono.BackColor = colorBlanco;
            }
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            btnLimpiar.Enabled = HabilitarLimpiar();
            if (!Regex.IsMatch(txtApellidos.Text, @"^[A-Z][a-z]+$") && txtApellidos.Text.Length != 0)
            {
                registroApellidos = false;
                txtApellidos.BackColor = colorError;
            }
            else
            {
                registroApellidos = (txtApellidos.Text.Length > 0) ? true : false;
                txtApellidos.BackColor = colorBlanco;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            btnLimpiar.Enabled = HabilitarLimpiar();
            if (!Regex.IsMatch(txtEmail.Text.ToLower(), @"^[a-z]+[0-9-._]*[@]{1}[a-z.]+\.{1}[a-z]{2,}$") && txtEmail.Text.Length != 0)
            {
                registroEmail = false;
                txtEmail.BackColor = colorError;
            }
            else
            {
                registroEmail = (txtEmail.Text.Length > 0) ? true : false;
                txtEmail.BackColor = colorBlanco;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDni.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            btnLimpiar.Enabled = HabilitarLimpiar();
        }

        private void btnPrincipio_Click(object sender, EventArgs e)
        {
            if (ComprobarCambios())
            {
                DialogResult cambios = DialogResult.No;
                cambios = MessageBox.Show("Desea guardar los cambios?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cambios == DialogResult.Yes) { Actualizar(); }
            }
            pos = 0;
            LeerBaseDeDatos(pos);
            ComprobarBotones();
            btnLimpiar.Enabled = HabilitarLimpiar();   
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                if (ComprobarCambios())
                {
                    DialogResult cambios = DialogResult.No;
                    cambios = MessageBox.Show("Desea guardar los cambios?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cambios == DialogResult.Yes) { Actualizar(); }
                }
                pos--;
                LeerBaseDeDatos(pos);
                ComprobarBotones();
                btnLimpiar.Enabled = HabilitarLimpiar();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (pos < dataProfesores.Tables["Profesores"].Rows.Count-1)
            {
                if (ComprobarCambios())
                {
                    DialogResult cambios = DialogResult.No;
                    cambios = MessageBox.Show("Desea guardar los cambios?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cambios == DialogResult.Yes) { Actualizar(); }
                }
                pos++;
                LeerBaseDeDatos(pos);
                ComprobarBotones();
                btnLimpiar.Enabled = HabilitarLimpiar();
            }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            if (ComprobarCambios())
            {
                DialogResult cambios = DialogResult.No;
                cambios = MessageBox.Show("Desea guardar los cambios?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cambios == DialogResult.Yes) { Actualizar(); }
            }
            pos = dataProfesores.Tables["Profesores"].Rows.Count - 1;
            LeerBaseDeDatos(pos);
            ComprobarBotones();
            btnLimpiar.Enabled = HabilitarLimpiar();
        }

        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            if (ComprobarValidez() && !ExisteDNI(txtDni.Text))
            {
                DataRow nuevoRegistro = dataProfesores.Tables["Profesores"].NewRow();
                nuevoRegistro[0] = txtDni.Text;
                nuevoRegistro[1] = txtNombre.Text;
                nuevoRegistro[2] = txtApellidos.Text;
                nuevoRegistro[3] = txtTelefono.Text;
                nuevoRegistro[4] = txtEmail.Text;
                dataProfesores.Tables["Profesores"].Rows.Add(nuevoRegistro);
                SqlCommandBuilder cb = new SqlCommandBuilder(adapterProfesores);
                adapterProfesores.Update(dataProfesores, "Profesores");
                pos = dataProfesores.Tables["Profesores"].Rows.Count-1;
                ComprobarBotones();
                CambiarDatos(dataProfesores.Tables["Profesores"].Rows[dataProfesores.Tables["Profesores"].Rows.Count - 1]);
                txtDni.BackColor = colorError;
            }
            else
            {
                if (ExisteDNI(txtDni.Text))
                {
                    MessageBox.Show("El profesor con el DNI ya existe");
                }
                else
                {
                    MessageBox.Show("Hay campos erroneos");
                }
            }
            if (dataProfesores.Tables["Profesores"].Rows.Count > 0)
            {
                btnEliminar.Enabled = true;
                btnActualizar.Enabled = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();   
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ExisteDNI(txtDni.Text))
            {
                if(MessageBox.Show("¿Esta seguro de que desea eliminar el registro actual?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dataProfesores.Tables["Profesores"].Rows[pos].Delete();
                    adapterProfesores.Update(dataProfesores, "Profesores");
                    if (pos - 1 >= 0)
                    {
                        pos--;
                    }
                    ComprobarBotones();
                    if (dataProfesores.Tables["Profesores"].Rows.Count > 0)
                    {
                        CambiarDatos(dataProfesores.Tables["Profesores"].Rows[pos]);
                    }
                    else
                    {
                        foreach(TextBox txt in txts)
                        {
                            txt.Text = string.Empty;
                        }
                        lblNumRegistro.Text = "Sin Registros";
                        btnEliminar.Enabled = false;
                        btnActualizar.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Operacion abortada");
                }
            }
            else
            {
                MessageBox.Show($"El profesor con DNI {txtDni.Text} no existe");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            btnLimpiar.Enabled = HabilitarLimpiar();
        }

        private void btnFiltrarProfesores_Click(object sender, EventArgs e)
        {
            Filtro filtroForm = new Filtro(sql);
            filtroForm.ShowDialog();
            dataProfesores = filtroForm.DataText;
            pos = 0;
            ComprobarBotones();
            if (dataProfesores.Tables["Profesores"].Rows.Count > 0)
            {
                CambiarDatos(dataProfesores.Tables["Profesores"].Rows[pos]);
            }
            else
            {
                foreach (TextBox txt in txts)
                {
                    txt.Text = string.Empty;
                }
                lblNumRegistro.Text = "Sin Registros";
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
            }
        }
    }
}
