using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Hacer un programa para ingresar tres números
            y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.
            */

            int a, b, c;

            Console.WriteLine("Ingrese 3 numeros: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());


            if(a + b > b * c){
                Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero.");
            }
            else{
                Console.WriteLine("No muestro nada.");
            }
        }
    }
}
