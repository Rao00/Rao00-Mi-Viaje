using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06.Profesores
{
    public partial class fProfesores : Form
    {
        Profesores profesores;
        public fProfesores(Profesores profesores)
        {
            InitializeComponent();
            this.profesores = profesores;
        }
    }
}
