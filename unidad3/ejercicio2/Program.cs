using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Ingrese un numero:");
            n1 = int.Parse(Console.ReadLine());

            if(n1 > 0)
                Console.WriteLine("El numero es positivo");
            else if(n1 < 0)
                Console.WriteLine("El numero es negativo");
            else if(n1 == 0)
                Console.WriteLine("El numero es 0");

            
        }
    }
}
