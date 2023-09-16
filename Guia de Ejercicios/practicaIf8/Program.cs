using System;

namespace practicaIf8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8. Hacer un programa para ingresar cuatro números distintos y luego mostrar por
            // pantalla el menor de ellos.

            int n, n2, n3, n4, menor;

            Console.WriteLine("Ingrese 4 numeros distintos: ");
            n = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());

            if(n > n2)
            {
                menor = n2;
            }
            else
            {
                menor = n;
            }
            if(menor > n3)
            {
                menor = n3;
            }
            if(menor > n4)
            {
                menor = n4;
            }
            Console.WriteLine("El menor es: " + menor);
        }
    }
}
