using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:

            //Si el importe es menor a ARS 1000, no hay descuento.
            //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            //Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            //Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.

            double importe, importeFinal;

            Console.WriteLine("Ingrese el importe de la compra:");
            importe = double.Parse(Console.ReadLine());

            if(importe >= 5000){
                importeFinal = importe - (importe * 0.18);
                Console.WriteLine("Se aplica un 18% de descuento. El precio total es: " + importeFinal.ToString("0,00"));
            }else if(importe >= 1000){
                importeFinal = importe - (importe * 0.10);
                Console.WriteLine("Se aplica un 10% de descuento. El precio total es: " + importeFinal.ToString("0,00"));
            }else if(importe < 1000){
                importeFinal = importe;
                Console.WriteLine("No se aplica descuento, el importe final es: " + importeFinal.ToString("0.00"));
            }
        }
            

            


                

    }
}

