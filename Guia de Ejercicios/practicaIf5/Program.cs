using System;

namespace practicaIf5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa para ingresar un número y mostrar por pantalla un cartel
            // aclaratorio si el mismo es PAR o IMPAR.

            int n;

            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");    
            }
        }
    }
}
