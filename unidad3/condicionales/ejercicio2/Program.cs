using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

                Si vende menos de 100 litros, no hay descuento.
                Si vende entre 101 y 300 litros, el descuento es del 10%.
                Si vende entre 301 y 500 litros, el descuento es del 15%.
                Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
                
                Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..
            */


            double litros, importe, total;

            Console.WriteLine("Ingrese el importe total de la venta: ");
            importe = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los litros vendidos: ");
            litros = double.Parse(Console.ReadLine());

            if(litros > 500){
                total = importe - (importe * 0.25);
                Console.WriteLine("Se te aplica un 25% de descuento, tu importe total es: " + total);
            }
            if(litros >= 301 && litros <= 500){
                total = importe - (importe * 0.15);
                Console.WriteLine("Se te aplica un 15% de descuento, tu importe total es: " + total);
            }
            if(litros >= 101 && litros <= 300){
                total = importe - (importe * 0.10);
                Console.WriteLine("Se te aplica un 10% de descuento, el importe total es: " + total);                
            }
            if(litros <= 100){
                total = importe;
                Console.WriteLine("El importe total es: " + total);
            }
        }
    }
}
