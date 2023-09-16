using System;

namespace practicaIF__4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Un importante negocio de desinfectante líquido realiza descuentos
            // dependiendo de la cantidad de litros vendidos según la siguiente escala:
            // a. Si vende menos de 100 litros, no hay descuento.
            // b. Si vende entre 101 y 300 litros, el descuento es del 10%.
            // c. Si vende entre 301 y 500 litros, el descuento es del 15%.
            // d. Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            // Hacer un programa que solicite el ingreso del importe total de la venta y la
            // cantidad de litros vendidos y calcule y emita el importe con el descuento
            // aplicado.

            int litros;
            double importe, total;

            Console.WriteLine("Ingrese los litros y el importe total de la venta: ");
            litros = int.Parse(Console.ReadLine());
            importe = double.Parse(Console.ReadLine());

            if(litros < 100)
            {
                Console.WriteLine("No aplica descuento, el importe de su venta es: " + importe);
            }
            if(litros >= 101 && litros <= 300)
            {
                total = importe - (importe * 0.10);
                Console.WriteLine("Por tu compra se aplica un 10% de descuento, el total es: " + total);
            }
            if(litros >= 301 && litros <= 500)
            {
                total = importe - (importe * 0.15);
                Console.WriteLine("Por tu compra se aplica un 15% de descuento, el total es: " + total);
            }
            if(litros >= 501)
            {
                total = importe - (importe * 0.25);
                Console.WriteLine("Por tu compra se aplica un 25% de descuento, el total es: " + total);
            }
        }
    }
}
