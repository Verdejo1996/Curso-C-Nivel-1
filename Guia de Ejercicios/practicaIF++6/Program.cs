using System;

namespace practicaIF__6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Hacer un programa para ingresar por teclado la longitud de los tres lados de un
            // triángulo y que luego determine e informe con un cartel aclaratorio a qué tipo
            // de triángulo corresponde:
            // a. Equilátero: cuando los tres lados sean iguales.
            // b. Isósceles: cuando dos de los tres lados sean iguales.
            // c. Escaleno: cuando todos los lados sean distintos.

            int l1, l2, l3;

            Console.WriteLine("Ingrese la longitud de los lados: ");
            l1 = int.Parse(Console.ReadLine());
            l2 = int.Parse(Console.ReadLine());
            l3 = int.Parse(Console.ReadLine());

            if(l1 == l2 && l2 == l3)
            {
                Console.WriteLine("El triangulo es equilatero.");
            }
            else if(l1 != l2 && l2 != l3 && l1 != l3)
            {
                Console.WriteLine("El triangulo es escaleno.");
            }
            else
            {
                Console.WriteLine("El triangulo es isosceles.");
            }
        }
    }
}
