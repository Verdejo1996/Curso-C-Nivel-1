using System;

namespace practicaIF__2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Hacer un programa que solicite el ingreso de dos números y luego calcular:
            // a. La resta si el primero es mayor que el segundo.
            // b. La suma si son iguales.
            // c. El producto si el primero es menor.
            // Se deberá emitir un cartel por pantalla con el resultado correspondiente.

            int n, n2, r;

            Console.WriteLine("Ingrese dos numeros");
            n = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            if(n > n2)
            {
                r = n - n2;
                Console.WriteLine("El resultado es: " + r);
            }
            if(n == n2)
            {
                r = n + n2;
                Console.WriteLine("El resultado es: " + r);
            }
            if(n < n2)
            {
                r = n * n2;
                Console.WriteLine("El resultado es: " + r);
            }
        }
    }
}
