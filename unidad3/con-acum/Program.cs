using System;

namespace con_acum
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, e1 = 14, e2 = 13, e3 = 25;
            int acumulador = 0, promedio = 0;

            /*operadores de contador y acumulador
            ++
            --
            =+
            -=
            */

            if(e1 > 18){
                contador++;
                acumulador += e1;
            }

            if(e2 > 18){
                contador++;
                acumulador += e2;
            }

            if(e3 > 18){
                contador++;
                acumulador += e3;
            }
            promedio = acumulador / contador;

            Console.WriteLine("El conteo es: " + contador);
            Console.WriteLine("El promedio es: " + promedio);

        }
    }
}
