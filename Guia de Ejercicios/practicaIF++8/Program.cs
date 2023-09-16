using System;

namespace practicaIF__8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8. El negocio de desinfectante antes mencionado vende además detergente
            // suelto, y los precios se aplican según la siguiente escala:
            // a. 25 ARS por litro los primeros 50 litros.
            // b. 20 ARS por litro si la venta es de 51 a 200 litros.
            // c. 15 ARS por litro si la venta es de 201 a 500 litros.
            // d. 10 ARS por litro si la venta es de más de 500 litros.
            // Además, si paga en efectivo, tiene un adicional del 10% sobre el importe final.
            // Hacer un programa que solicite la cantidad de litros vendidos y el tipo de pago
            // (ingresará 1 si paga en efectivo y 0 con cualquier otro medio de pago) y calcule
            // y emita por pantalla el monto final a abonar por el cliente.

            double litros, precioFinal = 0;
            int efectivo;

            Console.WriteLine("Ingrese la cantidad de litros de su compra: ");
            litros = double.Parse(Console.ReadLine());

            if(litros <= 50)
            {
                precioFinal = litros * 25;
            }
            if(litros >= 51 && litros <= 200)
            {
                precioFinal = litros * 20;
            }
            if(litros >= 201 && litros <= 500)
            {
                precioFinal = litros * 15;
            }
            if(litros >= 501)
            {
                precioFinal = litros * 10;
            }

            Console.WriteLine("Ingrese el tipo de pago a utilizar, 1 para efectivo con 10% de descuento o 0 para otro medio.)");
            efectivo = int.Parse(Console.ReadLine());

            if(efectivo == 1)
            {
                precioFinal = precioFinal - (precioFinal * 0.10);
                Console.WriteLine("El precio de su compra con 10% de descuento es: " + precioFinal);
            }
            else
            {
                Console.WriteLine("El precio de su compra es: " + precioFinal);
            }


            
        }
    }
}
