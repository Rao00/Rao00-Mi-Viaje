using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Windows.Forms;

namespace Ejercicio1
{
    public class SqlDBHelper
    {
        // DataSet para almacenar los datos de la base de datos
        DataSet dataSet = new DataSet();
        // Adaptador para conectar con la base de datos
        SqlDataAdapter adapter;
        // Conexión SQL
        SqlConnection sql;
        // DNI del usuario actual
        string DNIIniciado;

        // Posición actual
        int pos = 0;

        // Método para cargar la ruta de la base de datos
        private string LoadPath()
        {
            string relPath = @"..\..\..\..\Base de Datos\Instituto.mdf";
            relPath = Path.GetFullPath(relPath);
            string path = @"Data Source = (LocalDB)\MSSQLLocalDB;" +
                          $"Initial Catalog = {relPath};" +
                          "Integrated Security = True;" +
                          "Connect Timeout = 60";
            return path;
        }

        // Propiedad para obtener o establecer la posición actual
        public int ActPos
        {
            get { return pos; }
            set { pos = value; }
        }

        // Método para obtener la última posición en una tabla
        public int LastPos(string table = "Personas")
        {
            return dataSet.Tables[table].Rows.Count;
        }

        // Propiedad para obtener o establecer el DNI del usuario
        public string DNIUsuario
        {
            get { return DNIIniciado; }
            set { DNIIniciado = value; }
        }

        // Constructor
        public SqlDBHelper()
        {
            sql = new SqlConnection(LoadPath());
        }

        // Método para leer toda una tabla
        public void ReadTable(string tabla = "Personas")
        {
            sql.Open();
            string consuta = $"SELECT * FROM {tabla}";
            adapter = new SqlDataAdapter(consuta, sql);
            if (dataSet.Tables.Contains(tabla)) { dataSet.Tables[tabla].Reset(); }
            adapter.Fill(dataSet, tabla);
            sql.Close();
        }

        // Método para obtener una tabla
        public DataTable GetTable(string tabla = "Personas")
        {
            return dataSet.Tables[tabla];
        }

        // Método para ejecutar una consulta SQL en una tabla específica
        public void QueryTable(string tabla, string query)
        {
            sql.Open();
            SqlCommand procedure = new SqlCommand(query, sql);
            if (dataSet.Tables.Contains(tabla)) { dataSet.Tables[tabla].Reset(); }
            adapter = new SqlDataAdapter(procedure);
            adapter.Fill(dataSet, tabla);
            sql.Close();
        }

        // Método para actualizar los datos de una persona en la base de datos
        public void UpdatePersona<T>(T persona) where T : Persona
        {
            SqlCommand procedure = new SqlCommand("UpdatePersona", sql);
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.AddWithValue("@DNI", persona.DNI);
            procedure.Parameters.AddWithValue("@nombre", persona.Nombre);
            procedure.Parameters.AddWithValue("@apellido", persona.Apellido);
            procedure.Parameters.AddWithValue("@telefono", persona.Telefono);
            procedure.Parameters.AddWithValue("@email", persona.Email);
            sql.Open();
            procedure.ExecuteNonQuery();
            sql.Close();
        }

        // Método para leer una fila específica de una tabla
        public DataRow ReadRow(int position, string tabla = "Personas")
        {
            return dataSet.Tables[tabla].Rows[position];
        }

        // Método para obtener el tipo de persona (Administrador, Profesor, Alumno)
        public string GetType(string DNI)
        {
            if (Contains(DNI, "Administradores"))
            {
                return "Administrador";
            }
            else if (Contains(DNI, "Profesores"))
            {
                return "Profesor";
            }
            else if (Contains(DNI, "Alumnos"))
            {
                return "Alumno";
            }
            return null;
        }

        // Método para añadir una persona a la base de datos
        public void AddPersona<T>(T persona) where T : Persona
        {
            SqlCommand procedure = new SqlCommand("AddPersona", sql);
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.AddWithValue("@DNI", persona.DNI);
            procedure.Parameters.AddWithValue("@nombre", persona.Nombre);
            procedure.Parameters.AddWithValue("@apellido", persona.Apellido);
            procedure.Parameters.AddWithValue("@telefono", persona.Telefono);
            procedure.Parameters.AddWithValue("@email", persona.Email);
            sql.Open();
            procedure.ExecuteNonQuery();
            sql.Close();
        }

        // Método para filtrar personas en la base de datos según un criterio
        public string Filter(string txtFiltro, string tipoFiltro, string tablaTipo)
        {
            // Abre la conexión con la base de datos
            sql.Open();
            // Consulta SQL inicial
            string consulta;
            string filtro = txtFiltro.ToLower();
            int tamFiltro = filtro.Length;
            string salida = string.Empty;
            if (tamFiltro <= 0)
            {
                // Si no se proporciona un filtro, se seleccionan todos los registros
                consulta = $"SELECT {tipoFiltro}, DNI FROM Personas WHERE DNI = ANY(SELECT DNI FROM {tablaTipo})";
            }
            else if (tipoFiltro == "DNI")
            {
                // Si el filtro es el DNI, se busca coincidencia exacta
                consulta = $"SELECT DNI, Nombre FROM Personas WHERE LEFT(DNI, {tamFiltro}) = '{filtro}' AND DNI = ANY(SELECT DNI FROM {tablaTipo})";
            }
            else
            {
                // Si el filtro es otro campo, se busca coincidencia parcial
                consulta = $"SELECT {tipoFiltro}, DNI FROM Personas WHERE LEFT({tipoFiltro}, {tamFiltro}) = '{filtro}' AND DNI = ANY(SELECT DNI FROM {tablaTipo})";
            }
            // Ejecuta la consulta
            adapter = new SqlDataAdapter(consulta, sql);
            // Reinicia la tabla en el DataSet
            dataSet.Tables["Personas"].Reset();
            // Llena la tabla en el DataSet con los resultados de la consulta
            adapter.Fill(dataSet, "Personas");
            // Genera una salida con los resultados de la consulta
            foreach (DataRow fila in dataSet.Tables["Personas"].Rows)
            {
                salida += ($"{fila[0]} - {fila[1]}\n");
            }
            // Reinicia la tabla en el DataSet
            dataSet.Tables["Personas"].Reset();
            // Cierra la conexión con la base de datos
            sql.Close();
            // Ejecuta la misma consulta pero llena la tabla en el DataSet para futuros usos
            QueryTable("Personas", $"SELECT * FROM Personas WHERE LEFT({tipoFiltro}, {tamFiltro}) = '{filtro}' AND DNI = ANY(SELECT DNI FROM {tablaTipo})");
            return salida;
        }

        // Método para verificar si un valor existe en una tabla
        public bool Contains(string value, string table = "Personas")
        {
            // Recorre todas las filas y columnas de la tabla
            for (int i = 0; i < dataSet.Tables[table].Rows.Count; i++)
            {
                for (int j = 0; j < dataSet.Tables[table].Columns.Count; j++)
                {
                    // Comprueba si el valor coincide con algún valor en la tabla
                    if (dataSet.Tables[table].Rows[i][j].ToString() == value)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Método para actualizar los datos de un profesor en la base de datos
        public void AlterProfesores(string dni, string curso, string asignatura1, string asignatura2, string cursoAsignado)
        {
            SqlCommand procedure = new SqlCommand("AlterProfesor", sql);
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.AddWithValue("@DNI", dni);
            procedure.Parameters.AddWithValue("@curso", curso);
            procedure.Parameters.AddWithValue("@asignatura1", asignatura1);
            procedure.Parameters.AddWithValue("@asignatura2", asignatura2);
            procedure.Parameters.AddWithValue("@cursoAsignado", cursoAsignado);
            sql.Open();
            procedure.ExecuteNonQuery();
            sql.Close();
        }

        // Método para actualizar los datos de un alumno en la base de datos
        public void AlterAlumnos(string dni, string curso, double notaMedia)
        {
            SqlCommand procedure = new SqlCommand("AlterAlumno", sql);
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.AddWithValue("@DNI", dni);
            procedure.Parameters.AddWithValue("@curso", curso);
            procedure.Parameters.AddWithValue("@nota", notaMedia);
            sql.Open();
            procedure.ExecuteNonQuery();
            sql.Close();
        }

        // Método para actualizar los datos de un administrador en la base de datos
        public void AlterAdministradores(string dni, string ordenador, string horas, string piso)
        {
            SqlCommand procedure = new SqlCommand("AlterAlumno", sql); // ¡Debería ser "AlterAdministrador"!
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.AddWithValue("@DNI", dni);
            procedure.Parameters.AddWithValue("@ordenador", ordenador);
            procedure.Parameters.AddWithValue("@horas", horas);
            procedure.Parameters.AddWithValue("@piso", piso);
            sql.Open();
            procedure.ExecuteNonQuery();
            sql.Close();
        }

        public void DeletePersona(string dni)
        {
            SqlCommand procedure = new SqlCommand("DeletePersona", sql);
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.AddWithValue("@DNI", dni);
            sql.Open();
            procedure.ExecuteNonQuery();
            sql.Close();
            ReadTable();
        }
    }
}