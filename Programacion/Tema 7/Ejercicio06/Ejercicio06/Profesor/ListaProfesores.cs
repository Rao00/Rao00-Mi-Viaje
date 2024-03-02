﻿using Ejercicio06.Alumnos;
using Ejercicio06.Cursos;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06.Profesores
{
    public class ListaProfesores
    {
        List<Profesor> listaProfesores;

        public ListaProfesores()
        {
            listaProfesores = new List<Profesor>();
        }


        public int New(string dni)
        {
            Profesor profesor = new Profesor();
            profesor.DNI = dni;
            listaProfesores.Add(profesor);
            return 1;
        }

        public int Delete(string dni)
        {
            foreach (Profesor profesor in listaProfesores)
            {
                if (profesor.DNI == dni)
                {
                    listaProfesores.Remove(profesor);
                    return 1;
                }
            }
            return 0;
        }

        public string Show()
        {
            string salida = string.Empty;
            if (listaProfesores.Count > 0)
            {
                foreach (Profesor profesor in listaProfesores)
                {
                    salida += profesor.ToString() + "\n\n";
                }
            }
            return salida;
        }

        public string LookFor(string dni)
        {
            foreach (Profesor profesor in listaProfesores)
            {
                if (profesor.DNI == dni)
                {
                    return profesor.ToString();
                }
            }
            return string.Empty;
        }

        public void Sort()
        {
            listaProfesores = UtilidadesListas.Sort(listaProfesores);
        }

        public int Count()
        {
            return listaProfesores.Count;
        }

        public List<Profesor> List()
        {
            return listaProfesores;
        }

        public bool Contains(string dni)
        {
            foreach (Profesor profesor in listaProfesores)
            {
                if (profesor.DNI == dni)
                {
                    return true;
                }
            }
            return false;
        }

        public int FindIndex(string dni)
        {
            for (int i = 0; i < listaProfesores.Count(); i++)
            {
                if (listaProfesores[i].DNI == dni)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool CheckTutor(string curso)
        {
            foreach (Profesor profesor in listaProfesores)
            {
                if(profesor.TutorCurso == curso)
                {
                    return false;
                }
            }
            return true;
        }

        public string ToString(string dni)
        {
            string salida = "";
            int indice = -1 ;
            for (int i = 0; i < listaProfesores.Count() && indice == -1; i++)
            {
                if (listaProfesores[i].DNI == dni)
                {
                    indice = i;
                }
            }
            if (indice > -1)
            {
                foreach (string asignatura in listaProfesores[indice].Asignaturas)
                {
                    salida += $"{asignatura}\n";
                }
            }
            return salida;
        }
    }
}
