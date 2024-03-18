using Ejercicio06.Alumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06
{
    public class ListaPersonas
    {
        List<Persona> listaGlobal;

        public ListaPersonas()
        {
            listaGlobal = new List<Persona>();
        }

        public override string ToString()
        {
            string salida = string.Empty;

            foreach (Persona persona in listaGlobal)
            {
                salida += persona.ToString() + "\n";
            }

            if (salida == string.Empty)
            {
                throw new ArgumentNullException("No hay datos en la lista");
            }
            else
            {
                return salida;
            }
        }

        public string ToString(string TipoDeDato)
        {
            string salida = string.Empty;

            foreach (Persona persona in listaGlobal)
            {
                if (persona.GetType() == TipoDeDato)
                {
                    salida += persona.ToString() + "\n";
                }
            }

            if(salida == string.Empty)
            {
                throw new ArgumentNullException($"No hay datos de {TipoDeDato} en la lista");
            }
            else
            {
                return salida;
            }
        }

        public List<Alumno> GetAlumnos()
        {
            List<Alumno> listaAlumnos = new List<Alumno>();
            foreach(Persona persona in listaGlobal)
            {
                if(persona.GetType() == "Alumno")
                {
                    listaAlumnos.Add((Alumno)persona);
                }
            }
            return listaAlumnos;
        }

        public List<Profesor> GetProfesores()
        {
            List<Profesor> listaProfesores = new List<Profesor>();
            foreach (Persona persona in listaGlobal)
            {
                if (persona.GetType() == "Profesor")
                {
                    listaProfesores.Add((Profesor)persona);
                }
            }
            return listaProfesores;
        }

        public int New(string dni)
        {
            Alumno alumno = new Alumno();
            alumno.DNI = dni;
            listaGlobal.Add(alumno);
            return 1;
        }

        public int Delete(string dni)
        {
            foreach(Persona persona in listaGlobal)
            {
                if (persona.DNI == dni)
                {
                    listaGlobal.Remove(persona);
                    return 1;
                }
            }
            return 0;
        }

        public string Show(string tipo = null)
        {
            string salida = string.Empty;
            if (listaGlobal.Count > 0)
            {
                foreach (Persona persona in listaGlobal)
                {
                    if (persona.GetType() == tipo || tipo == null)
                    {
                        salida += persona.ToString() + "\n\n";
                    }
                }
            }
            return salida;
        }

        public string LookFor(string dni)
        {
            foreach (Persona persona in listaGlobal)
            {
                if (persona.DNI == dni)
                {
                    return persona.ToString();
                }
            }
            return string.Empty;
        }

        public void Sort()
        {
            listaGlobal = UtilidadesListas.Sort(listaGlobal);
        }

        public int Count()
        {
            return listaGlobal.Count;
        }

        public bool Contains(string dni)
        {
            foreach (Alumno alumno in listaGlobal)
            {
                if (alumno.DNI == dni)
                {
                    return true;
                }
            }
            return false;
        }

        public int FindIndex(string dni)
        {
            for (int i = 0; i < listaGlobal.Count(); i++)
            {
                if (listaGlobal[i].DNI == dni)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool CheckTutor(string curso)
        {
            foreach (Persona profesor in listaGlobal)
            {
                if(profesor.GetType() == "Profesor")
                {
                    Profesor tempProfesor = (Profesor)profesor;
                    
                    if (tempProfesor.TutorCurso == curso)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public Profesor RemoveSubjects(Profesor profesor, List<string> lAsignaturas)
        {
            bool continuar = true;
            for (int i = 0; i < lAsignaturas.Count(); i++)
            {
                for (int j = 0; j < profesor.Asignaturas.Count() && continuar; j++)
                {
                    if (lAsignaturas.Contains(profesor.Asignaturas[j]))
                    {
                        profesor.Asignaturas.Remove(lAsignaturas[i]);
                        continuar = false;
                    }
                }
                continuar = true;
            }
            return profesor;
        }

        public Profesor AddSubjects(Profesor profesor, List<string> lAsignaturas)
        {
            foreach (string asignatura in lAsignaturas)
            {
                if (!profesor.Asignaturas.Contains(asignatura))
                {
                    profesor.Asignaturas.Add(asignatura);
                }
                else { MessageBox.Show($"El profesor con DNI {profesor.DNI} ya tiene asignada la asignatura de {asignatura}"); }
            }
            return profesor;
        }
    }
}
