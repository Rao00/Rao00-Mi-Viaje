using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06.Cursos
{
    internal class ListaCursos
    {
        List<Cursos> listaCursos;

        public ListaCursos()
        {
             listaCursos = new List<Cursos>();
        }

        public List<Cursos> List
        {
            get { return listaCursos; }
        }

        public void New()
        {
            try 
            {
                Cursos cursos = new Cursos();
                cursos.nombre = Interaction.InputBox("Nombre de la asignatura");
                cursos.codigo = int.Parse(Interaction.InputBox("Codigo de la asignatura"));
                listaCursos.Add(cursos);
            }
            catch { MessageBox.Show("Inserta un parametro correcto"); }
            
        }
    }
}
