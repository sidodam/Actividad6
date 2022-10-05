using System;
using System.Collections.Generic;
using System.Linq;

namespace Actividad6
{
    public class Alumno
    {
        static void Main(string[] args)
        {
        }

        public string Nombre { get; set; }
        public int Nota { get; set; }

        public static List<string> getNombres(List<Alumno> alumnos)
        {




            var losNombres = alumnos.Select(n => n.Nombre).ToList();


   
            return losNombres;

            throw new NotImplementedException();
        }

        public static Alumno getListadoNota(List<Alumno> alumnos, int nota)
        {

            // var Datos = alumnos.OrderByDescending(al => new { al.Nombre, al.Nota }).ToList();


            var Datos = alumnos.Where(n => n.Nota == nota);

         var dichoAlumno =  Datos.ToList().First();


            return dichoAlumno; 


            throw new NotImplementedException();
        }

        public static Alumno getPrimerAlumno(List<Alumno> alumnos)

        {

            Alumno Primero = alumnos.First();


            return Primero; 

            throw new NotImplementedException();
        }

        public static Alumno getUltimoAlumno(List<Alumno> alumnos)
        {

            Alumno Ultimo = alumnos.Last();


            return Ultimo;
            throw new NotImplementedException();
        }

        public static int getSumaNota(List<Alumno> alumnos)
        {


            return alumnos.Sum(al => al.Nota);


         

            throw new NotImplementedException();
        }

        public static int getNotaMaxima(List<Alumno> alumnos)
        {

            return  alumnos.Max(al => al.Nota);


            throw new NotImplementedException();
        }

        public static int getNotaMinima(List<Alumno> alumnos)
        {

            return alumnos.Min(al => al.Nota);

            throw new NotImplementedException();
        }

        public static int getNotaPorNombre(List<Alumno> alumnos, string v)
        {

            return alumnos.Single(x => x.Nombre.Equals(v)).Nota;

          
            throw new NotImplementedException();
        }

        public static double getNotaMedia(List<Alumno> alumnos)
        {

            return  alumnos.Average(al => al.Nota);

            throw new NotImplementedException();
        }
    }
}
