using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            int sucursales;
            int c = 1;
            decimal total = 0, ventas = 0, promedio = 0;
            decimal totalG = 0, promedioG = 0;

            Console.WriteLine("Ingrese la cantidad de sucursales a evaluar");
            int.TryParse(Console.ReadLine(), out sucursales);

            for ( int i = 0; i < sucursales; i++)
            {
                do
                {
                    Console.WriteLine("Sucursal {0}", (i + 1));
                    Console.WriteLine("Ingrese el valor de su venta");
                    Console.WriteLine("Ingrese 0 para detener la captura de datos");
                    decimal.TryParse(Console.ReadLine(), out ventas);
                    c = c + 1;
                    total = total + ventas;
                } while (ventas != 0);

                promedio = total / (c - 2);

                Console.Clear();
                Console.WriteLine("Sucursal {0}", (i + 1));
                Console.WriteLine("Venta total: {0}", total.ToString("C2"));
                Console.WriteLine("Promedio de ventas: {0}", promedio.ToString("C2"));

                totalG = totalG + total;
                promedioG = promedioG + promedio;

                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Total de ventas globales: {0}", totalG.ToString("C2"));
                Console.WriteLine("Promedio de ventas global: {0}", promedioG.ToString("C2"));
                Console.ReadKey();
            }

        }
    }
}
