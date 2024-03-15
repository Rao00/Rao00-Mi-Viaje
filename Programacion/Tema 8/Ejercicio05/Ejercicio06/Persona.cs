using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio06
{
    public interface IPersona
    {
        string DNI { get; set; }
        string Nombre { get; set; }
        string Telefono { get; set; }
        
        bool SetDNI(string dni);
        bool SetNombre(string nombre);
        bool SetTelefono(string telefono);
    }
}

