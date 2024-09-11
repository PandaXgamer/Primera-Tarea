using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            Escuela escuela = new Escuela();

            Estudiante estudiante1 = new Estudiante("Orlando", 1);
            Estudiante estudiante2 = new Estudiante("María", 2);

            Profesor profesor1 = new Profesor("Profesor Francis");
            Profesor profesor2 = new Profesor("Profesor Orison");

         
            Curso curso1 = new Curso("P2", 4, 2);
            Curso curso2 = new Curso("Fundamentos de P", 5, 3);

         
            profesor1.AgregarCurso(curso1);
            profesor2.AgregarCurso(curso2);

            
            Clase clase1 = new Clase("Clase A");
            clase1.AgregarEstudiante(estudiante1);
            clase1.AgregarEstudiante(estudiante2);
            clase1.AgregarProfesor(profesor1);
            clase1.AgregarProfesor(profesor2);

            
            escuela.AgregarClase(clase1);

            for (int i = 0; i < escuela.Clases.Count; i++)
            {
                Clase clase = escuela.Clases[i];
                Console.WriteLine("Clase: " + clase.Identificador);

                Console.WriteLine("Estudiantes:");
                for (int j = 0; j < clase.Estudiantes.Count; j++)
                {
                    Estudiante estudiante = clase.Estudiantes[j];
                    Console.WriteLine("- " + estudiante.Nombre + ", Número: " + estudiante.NumeroUnico);
                }

                Console.WriteLine("Profesores:");
                for (int k = 0; k < clase.Profesores.Count; k++)
                {
                    Profesor profesor = clase.Profesores[k];
                    Console.WriteLine("- " + profesor.Nombre);

                    Console.WriteLine("Cursos impartidos:");
                    for (int l = 0; l < profesor.Cursos.Count; l++)
                    {
                        Curso curso = profesor.Cursos[l];
                        Console.WriteLine("  * " + curso.Nombre + ", Clases: " + curso.RecuentoClases + ", Ejercicios: " + curso.RecuentoEjercicios);
                    }

                }

            }
            
            Console.ReadLine();
        }

       
    }
}

