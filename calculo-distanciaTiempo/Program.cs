using System;

namespace calculo_distanciaTiempo
{
    class Program
    {
        static void Main(string[] args)
        {
            string ciudad1, ciudad2;
            double distancia, velocidadPromedio, tiempoAproximado;
            

            Console.WriteLine("Ingrese las ciudades: ");
            ciudad1 = Console.ReadLine();
            ciudad2 = Console.ReadLine();

            Console.WriteLine("La distancia entre ambas ciudades es: ");
            distancia = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la velocidad promedio: ");
            velocidadPromedio = int.Parse(Console.ReadLine());

            tiempoAproximado = distancia / velocidadPromedio;

            Console.WriteLine("El tiempo aproximado que tarda entre estas 2 ciudades es: " + tiempoAproximado + " horas.");


        }
    }
}
