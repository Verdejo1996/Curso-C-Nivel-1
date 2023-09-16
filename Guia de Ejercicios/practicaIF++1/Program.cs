using System;

namespace practicaIF__1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa que solicite el ingreso de un número y que luego emita un
            // cartel por pantalla aclarando si el mismo es múltiplo de 5.

            int n;

            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            if(n % 5 == 0)
            {
                Console.WriteLine("El numero es multiplo de 5");
            }
            else
            {
                Console.WriteLine("No es multiplo de 5");
            }
        }
    }
}
