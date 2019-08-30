using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            int cantidad, aprobados = 0, RNota = 0, RAsistencia = 0, reprobados = 0;
            double nota, asistencia;
            Console.WriteLine("Por favor ingrese la cantidad de alumnos");
            int.TryParse(Console.ReadLine(), out cantidad);
            for (int i = 0; i < cantidad; i++)
            {
                Console.Clear();
                Console.WriteLine("Ingrese la calificacion del alumno  (1-10)");
                double.TryParse(Console.ReadLine(), out nota);
                Console.WriteLine("Ingrese la asistencia del estudiante  (1-100)");
                double.TryParse(Console.ReadLine(), out asistencia);


                if (nota >= 7.0 && asistencia >= 75)
                {
                    Console.WriteLine("Alumno aprobado");
                    Console.ReadKey();
                    aprobados = aprobados + 1;
                }
                else
                {
                    if (asistencia < 75)
                    {
                        Console.WriteLine("Alumno reprobado por asistencia");
                        Console.ReadKey();
                        RAsistencia = RAsistencia + 1;
                    }
                    else
                    {
                        if (nota < 7.0)
                        {
                            Console.WriteLine("Alumno reprobado por calificacion");
                            Console.ReadKey();
                            RNota = RNota + 1;
                        }
                    }
                    reprobados = RAsistencia + RNota;

                }

            }
            Console.WriteLine("La cantidad de aprobados es de {0} estudiantes", aprobados);
            Console.WriteLine("La cantidad de reprobados es de {0} estudiantes", reprobados);
            Console.ReadKey();
        }
    }
}
