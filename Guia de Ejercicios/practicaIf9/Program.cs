using System;

namespace practicaIf9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9. Hacer un programa para ingresar cinco números distintos y luego mostrar por
            // pantalla el mayor y el menor de ellos.

            int n, n2, n3, n4, n5, mayor, menor;

            Console.WriteLine("Ingrese 5 numeros distintos: ");
            n = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());

            if(n > n2)
            {
                mayor = n;
                menor = n2;
            }
            else
            {
                mayor = n2;
                menor = n;
            }
            if(mayor < n3)
            {
                mayor = n3;
            }
            if(menor > n3)
            {
                menor = n3;
            }
            if(mayor < n4)
            {
                mayor = n4;
            }
            if(menor > n4)
            {
                menor = n4;
            }
            if(mayor < n5)
            {
                mayor = n5;
            }
            if(menor > n5)
            {
                menor = n5;
            }
            Console.WriteLine("El mayor es: " + mayor);
            Console.WriteLine("El menor es: " + menor);
        }
    }
}
