using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

            int n, maxPar = 0, minImpar = 0, conPar = 0, conImpar = 0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                if(n % 2 == 0)
                {
                    conPar++;
                    if(conPar == 1)
                        maxPar = n;
                    else if(n > maxPar)
                        maxPar = n;
                }
                else
                {
                    conImpar++;
                    if(conImpar == 1)
                        minImpar = n;
                    else if(n < minImpar)
                        minImpar = n;
                }

            }
            
            Console.WriteLine("El mayor de los pares es " + maxPar);
            Console.WriteLine("El menor de los impares es " + minImpar);
        }
    }
}
