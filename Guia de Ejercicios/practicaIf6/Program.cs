using System;

namespace practicaIf6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Una casa de video juegos otorga un descuento dependiendo del importe de la
            // compra realizada según los siguientes valores:
            // • Si el importe es menor a ARS 1000, no hay descuento.
            // • Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un
            // descuento del 10%.
            // • Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            // Hacer un programa para ingresar un importe de venta y luego muestre por
            // pantalla el importe final con el descuento que corresponda.

            double importe, importeTotal = 0;

            Console.WriteLine("Ingrese el importe de compra: ");
            importe = double.Parse(Console.ReadLine());

            if(importe >= 1000 && importe < 5000)
            {
                importeTotal = importe - (importe * 0.10);
                Console.WriteLine("Tu compra tine un 10% de descuento, el total es: " + importeTotal);
            }
            if(importe >= 5000)
            {
                importeTotal = importe - (importe * 0.18);
                Console.WriteLine("Tu compra tine un 18% de descuento, el total es: " + importeTotal);
            }
            if(importe < 1000)
            {
                importeTotal = importe;
                Console.WriteLine("Tu compra no tiene descuento, el total es: " + importeTotal);
            }
        }
    }
}
