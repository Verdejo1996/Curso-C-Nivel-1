using System;

namespace practicaIf11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 11. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla
            // cuántos son menores a 100.

            int n, n2, n3, n4, con = 0;

            Console.WriteLine("Ingrese 4 numeros: ");
            n = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());

             if(n > 100)
            {
                con++;
            }
            if(n2 > 100)
            {
                con++;
            }
            if(n3 > 100)
            {
                con++;
            }
            if(n4 > 100)
            {
                con++;
            }
            Console.WriteLine("La cantidad de numeros mayores a 100 son: " + con);
        }
    }
}
