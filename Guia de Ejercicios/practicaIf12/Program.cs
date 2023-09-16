using System;

namespace practicaIf12
{
    class Program
    {
        static void Main(string[] args)
        {
            // 12. Hacer un programa para ingresar un valor que estará expresado en minutos. Si
            // los minutos superan los 60, pasar el valor a horas, de lo contrario dejarlo en
            // minutos. Mostrar el resultado en pantalla aclarando si se muestran minutos u
            // horas.

            double valor;


            Console.WriteLine("Ingrese un valor: ");
            valor = double.Parse(Console.ReadLine());

            if(valor >= 60)
            {
                valor = valor / 60;
                Console.WriteLine("Las horas son: " + valor);
            }
            else
            {
                Console.WriteLine("Los minutos son: " + valor);
            }
        }
    }
}
