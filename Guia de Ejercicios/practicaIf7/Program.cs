using System;

namespace practicaIf7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Hacer un programa para ingresar cuatro números distintos y luego mostrar por
            // pantalla el mayor de ellos.

            int n, n2, n3, n4, mayor;

            Console.WriteLine("Ingrese 4 numeros distintos: ");
            n = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());

            if(n > n2)
            {
                mayor = n;
            }
            else
            {
                mayor = n2;
            }
            if(mayor < n3)
            {
                mayor = n3;
            }
            if(mayor < n4)
            {
                mayor = n4;
            }
            Console.WriteLine("El mayor es: " + mayor);
        }
    }
}
