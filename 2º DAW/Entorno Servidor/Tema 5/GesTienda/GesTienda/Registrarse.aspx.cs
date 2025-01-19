using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GesTienda
{
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            lblMensajes.Text = "";
            if (txtPassword1.Text == txtPassword2.Text)
            {
                string strLogin, strPassword, strRol, strFechaAlta;
                DateTime dtFechaAlta;
                string strIdCliente, strNomCli, strDirCli, strPobCli, strCpoCli, strTelCli, strCorCli;
                strLogin = txtCorCli.Text;
                strPassword = txtPassword1.Text;
                strRol = "U";
                dtFechaAlta = System.DateTime.Now; // Carga fecha y hora del sistema
                strFechaAlta = String.Format("{0:yyyy/MM/dd HH:mm:ss}", dtFechaAlta);
                strIdCliente = txtIdCliente.Text;
                strNomCli = txtNomCli.Text;
                strDirCli = txtDirCli.Text;
                strPobCli = txtPobCli.Text;
                strCpoCli = txtCpoCli.Text;
                strTelCli = txtTelCli.Text;
                strCorCli = txtCorCli.Text;
                string StrCadenaConexion =
                ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                string strComandoSql_1 = "INSERT USUARIO " +
                "(Login,Password, Rol, FechaAlta) VALUES (" +
                "'" + strLogin + "','" + strPassword + "','" + strRol + "','" + strFechaAlta + "');";
                string strComandoSql_2 = "INSERT CLIENTE " +
                "(IdCliente,NomCli,DirCli,PobCli,CpoCli,TelCli,CorCli) VALUES (" +
                "'" + strIdCliente + "','" + strNomCli + "','" + strDirCli + "','" + strPobCli +
                "','" + strCpoCli + "','" + strTelCli + "','" + strCorCli + "');";
                SqlConnection conexion = new SqlConnection(StrCadenaConexion);
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                SqlTransaction tran = conexion.BeginTransaction();
                comando.Transaction = tran;
                try
                {
                    comando.CommandText = strComandoSql_1;
                    comando.ExecuteNonQuery();
                    comando.CommandText = strComandoSql_2;
                    comando.ExecuteNonQuery();
                    tran.Commit();
                    lblMensajes.Text = "Usuario registrado correctamente";
                }
                catch (SqlException ex)
                {
                    tran.Rollback();
                    string StrError = "<p>Se han producido errores durante el registro</p>";
                    StrError = StrError + "<div>Código: " + ex.Number + "</div>";
                    StrError = StrError + "<div>Descripción: " + ex.Message + "</div>";
                    lblMensajes.Text = StrError;
                }
                finally
                {
                    conexion.Close();
                }
            }
            else
            {
                lblMensajes.Text = "Se ha producido un error. Valores de contraseña no coincidentes";
            }
        }
    }
}