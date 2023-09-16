using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

                La resta si el primero es mayor que el segundo.
                La suma si son iguales.
                El producto si el primero es menor.
                
                Se deberá emitir un cartel por pantalla con el resultado correspondiente.
            */
            
            int a, b, res;

            Console.WriteLine("Ingrese dos numeros: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if(a > b){
                res = a - b;
                Console.WriteLine("La resta de ambos es: " + res);
            }
            if(a == b){
                res = a + b;
                Console.WriteLine("La suma de ambos es: " + res);
            }
            if(a < b){
                res = a * b;
                Console.WriteLine("El producto de ambos es: " + res);
            }
        }
    }
}
