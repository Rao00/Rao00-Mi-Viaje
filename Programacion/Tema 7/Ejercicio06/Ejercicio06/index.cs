using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio06.Alumnos;
using Ejercicio06.Profesores;
using Ejercicio06.Cursos;

namespace Ejercicio06
{
    public partial class Eje06 : Form
    {
        Alumnos.Alumnos alumnos;
        Profesores.Profesores profesores;
        ListaCursos listaCursos;

        public Eje06(Alumnos.Alumnos alumnos, Profesores.Profesores profesores)
        {
            InitializeComponent();
            this.alumnos = alumnos;
            this.profesores = profesores;
        }


    }
}
