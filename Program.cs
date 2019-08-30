using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            decimal sueldo = 0, total = 0, promedio = 0;
            for (int i = 1; i < 20; i++) 
            {
                Console.WriteLine("Ingrese el sueldo del empleado {0}", i);
                decimal.TryParse(Console.ReadLine(), out sueldo);
                total = total + sueldo;
            }

            promedio = total / 20;
            Console.WriteLine("El sueldo total es: ${0}", total.ToString("C2"));
            Console.WriteLine("El sueldo promedio es: ${0}", promedio.ToString("C2"));
            Console.ReadKey();
        }
    }
}
