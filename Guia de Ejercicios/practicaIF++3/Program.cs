using System;

namespace practicaIF__3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer un programa para ingresar dos números. Si el segundo es distinto de
            // cero, calcular la división del primero por el segundo y mostrar el resultado por
            // pantalla; caso contrario, emitir un cartel aclarando que no se puede dividir por
            // cero.

            double n, n2, r;

            Console.WriteLine("Ingrese dos numeros");
            n = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());

            if(n2 != 0)
            {
                r = n / n2;
                Console.WriteLine("El resultado es: " + r);
            }
            else
            {
                Console.WriteLine("No se puede dividir por 0");
            }
        }
    }
}
