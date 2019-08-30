using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            string contraseña = "empanada123", contra;
            int intentos = 0;
            do
            {
                Console.WriteLine("Ingrese su contraseña");
                contra = Console.ReadLine();
                if (contra != contraseña)
                {
                    Console.WriteLine(" Contraseña inválida ");
                    Console.WriteLine("---------------------");
                    intentos = intentos + 1;
                    Console.WriteLine("Pista: {0}", contraseña.Substring(0, intentos));
                }
            } while (contraseña != contra && intentos < 3);
            if ( intentos == 3 && contraseña!=contra)
            {
                Console.WriteLine("La contraseña fue ingresada incorrectamente");
                Console.WriteLine("Usted ya no tiene mas intentos");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Contraseña correcta");
                Console.ReadKey();
            }
        }
    }
}
