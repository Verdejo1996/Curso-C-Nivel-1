using System;

namespace practicaIf10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla
            // cuáles son mayores a 100.

            int n, n2, n3, n4;

            Console.WriteLine("Ingrese 4 numeros: ");
            n = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());

            if(n > 100)
            {
                Console.WriteLine("El numero " + n + " es mayor a 100");
            }
            if(n2 > 100)
            {
                Console.WriteLine("El numero " + n2 + " es mayor a 100");
            }
            if(n3 > 100)
            {
                Console.WriteLine("El numero " + n3 + " es mayor a 100");
            }
            if(n4 > 100)
            {
                Console.WriteLine("El numero " + n4 + " es mayor a 100");
            }
        }
    }
}
