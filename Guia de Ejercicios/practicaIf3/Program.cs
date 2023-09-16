using System;

namespace practicaIf3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer un programa para ingresar dos números y que luego emita por pantalla
            // el mayor de ellos o un cartel aclaratorio “Son iguales” en el caso de que así sea.

            int n, n2;

            Console.WriteLine("Ingrese 2 numeros: ");
            n = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            if(n > n2)
            {
                Console.WriteLine("El mayor es: " + n);
            }
            if(n == n2)
            {
                Console.WriteLine(n + " y " + n2 + ", son iguales");
            }
            else
            {
                Console.WriteLine("El mayor es: " + n2);
            }
        }
    }
}
