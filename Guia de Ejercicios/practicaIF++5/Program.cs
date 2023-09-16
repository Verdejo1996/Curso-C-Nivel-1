using System;

namespace practicaIF__5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa que solicite el ingreso de las notas del primer parcial y del
            // segundo parcial de una alumna de programación. El programa deberá analizar
            // las notas y emitir la situación de la alumna según la siguiente escala:
            // a. Si tiene 8 o más en ambos parciales, emitir “aprobación directa”.
            // b. Si no tiene 8 o más en ambos pero tiene aprobados ambos parciales (se
            // aprueba con 6 o más), emitir “rinde examen final”.
            // c. Si tiene menos de 6 en alguno de los dos parciales, emitir “debe
            // recuperar”.
            // El programa debe emitir solo un cartel, el que corresponda.

            int n1, n2;

            Console.WriteLine("Ingrese la nota del primer parcial y luego del segundo: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            if(n1 < 6 || n2 < 6)
            {
                Console.WriteLine("Debe recuperar.");
            }
            else if(n1 < 8 || n2 < 8)
            {
                Console.WriteLine("Rinde examen final.");
            }
            else
            {
                Console.WriteLine("Aprobacion directa.");
            }
        }
    }
}
