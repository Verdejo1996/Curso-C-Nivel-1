using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
            //  El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

            int n, conNumeros, numeroGrupo = 0;

            do
            {
                numeroGrupo++;
                conNumeros = 0;
                n = int.Parse(Console.ReadLine());
                while(n > 0)
                {
                    conNumeros++;
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("La cantidad de numeros " + numeroGrupo + " es: " + conNumeros);

            }while(n >= 0);
        }
    }
}
