using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06.Cursos
{
    public class ListaCursos
    {
        List<Curso> listaCursos;

        public ListaCursos()
        {
             listaCursos = new List<Curso>();
        }

        public List<Curso> List
        {
            get { return listaCursos; }
        }

        public void New()
        {
            try 
            {
                Curso cursos = new Curso();
                cursos.nombre = Interaction.InputBox("Nombre del curso");
                cursos.codigo = int.Parse(Interaction.InputBox("Codigo del curso"));
                listaCursos.Add(cursos);
            }
            catch { MessageBox.Show("Inserta un parametro correcto"); }
            
        }
    }
}
