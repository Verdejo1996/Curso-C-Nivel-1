using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

            int n, promedio, con = 0, acu = 0;

            for(int x = 0; x <= 20; x++)
            {
                Console.WriteLine("Ingrese 20 edades: ");
                n = int.Parse(Console.ReadLine());

                if(n > 18)
                {
                    acu += n;
                    con++;
                }
            }
            promedio = acu / con;

            Console.WriteLine("El promedio de edades mayores a 18 es: " + promedio);
        }
    }
}
