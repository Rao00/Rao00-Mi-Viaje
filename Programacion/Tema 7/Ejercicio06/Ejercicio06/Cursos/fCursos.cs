using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06.Cursos
{
    public partial class fCursos : Form
    {
        Cursos cursos;
        ListaCursos listaCursos;
        public fCursos(Cursos cursos)
        {
            InitializeComponent();
            this.cursos = cursos;
            Eje06.listaCursos = listaCursos;
        }
    }
}
