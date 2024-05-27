using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Persona
    {
        string _dni, _nombre, _apellido, _telefono, _email;
        Image _fotoPerfil;

        public string DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public Image FotoPerfil
        {
            get { return _fotoPerfil; }
            set { _fotoPerfil = value;}
        }

        public Persona(string DNI, string Nombre, string Apellido, string Telefono, string Email, Image fotoPerfil = null)
        {
            _dni = DNI;
            _nombre = Nombre;
            _apellido = Apellido;
            _telefono = Telefono;
            _email = Email;
            _fotoPerfil = fotoPerfil;
        }
    }
}
