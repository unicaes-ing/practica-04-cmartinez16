using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            int i = 1;
            decimal total = 0, venta = 0, bonificacion;
            do
            {
                Console.WriteLine("Ingrese el valor de la venta {0}", i);
                Console.WriteLine("Ingrese -1 para detener la captura de datos");
                decimal.TryParse(Console.ReadLine(), out venta);
                i = i + 1;
                total = total + venta;
            } while (venta != -1);
            bonificacion = total * 0.05m;

            Console.Clear();
            Console.WriteLine("Total de ventas: {0}", total.ToString("C2"));
            Console.WriteLine("Bonificacion por las ventas: {0}", bonificacion.ToString("C2"));
            Console.ReadKey();
        }
    }
}
