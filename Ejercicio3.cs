using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            string nombre;
            int A = 0, E = 0, I = 0, O = 0, U = 0;
            Console.WriteLine("Escriba su nombre");
            nombre = Console.ReadLine();
            for (int i = 0; i < nombre.Length; i++)
            {
                if ((nombre[i] == 'a') || (nombre [i]=='á') ||(nombre[i]=='A')) 
                {
                    A = A + 1;
                }
                if ((nombre[i] == 'e') || (nombre[i] == 'é') || (nombre[i] == 'E'))
                {
                    E = E + 1;
                }
                if ((nombre[i] == 'i') || (nombre[i] == 'í') || (nombre[i] == 'I'))
                {
                    I = I + 1;
                }
                if ((nombre[i] == 'o') || (nombre[i] == 'ó') || (nombre[i] == 'O'))
                {
                    O = O + 1;
                }
                if ((nombre[i] == 'u') || (nombre[i] == 'ú') || (nombre[i] == 'U'))
                {
                    U = U + 1;
                }
            }
            Console.WriteLine("-------Cantidad de vocales--------");
            Console.WriteLine("Cantidad de vocales A: {0}",A);
            Console.WriteLine("Cantidad de vocales E: {0}", E);
            Console.WriteLine("Cantidad de vocales I: {0}", I);
            Console.WriteLine("Cantidad de vocales O: {0}", O);
            Console.WriteLine("Cantidad de vocales U: {0}", U);
            Console.ReadKey();
        }
    }
}
