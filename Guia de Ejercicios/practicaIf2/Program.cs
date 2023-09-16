using System;

namespace practicaIf2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa para ingresar dos números distintos y luego se muestre por
            //pantalla el menor de ellos.
            
            int n, n2;

            Console.WriteLine("Ingrese 2 numeros distintos: ");
            n = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            if(n > n2)
            {
                Console.WriteLine("El menor es: " + n2);
            }
            else
            {
                Console.WriteLine("El menor es: " + n);
            }
        }
    }
}
