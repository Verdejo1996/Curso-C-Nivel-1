using System;

namespace ejercicio4
{
    class Program
    {

        // 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
        // - Número de Artículo (1 a 15)
        // - Cantidad Vendida 

        // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
        // Se pide determinar e informar:
        // a) El número de artículo que más se vendió en total.
        // b) Los números de artículos que no registraron ventas.
        // c) Cuantas unidades se vendieron del número de artículo 10.
        
        static void Main(string[] args)
        {
            int numeroArticulo;
            int cantidad;
            
            int[] totalCantidadVendida = new int[15];
            for(int i = 0; i < 15; i++) 
            {
                totalCantidadVendida[i] = 0;
            }

            Console.WriteLine("Ingrese el numero de articulo");
            numeroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida");
            cantidad = int.Parse(Console.ReadLine());

            while(numeroArticulo != 0)
            {
                totalCantidadVendida[numeroArticulo-1] += cantidad;

                Console.WriteLine("Ingrese el numero de articulo");
                numeroArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad vendida");
                cantidad = int.Parse(Console.ReadLine());
            }

            int maxCantidad = totalCantidadVendida[0];
            int numeroMaximo = 1;
            for(int i = 0; i < 15; i++) 
            {
                if(totalCantidadVendida[i] > maxCantidad)
                {
                    maxCantidad = totalCantidadVendida[i];
                    numeroMaximo = i+1;
                }
            }
            Console.WriteLine("El producto mas vendido es el : " + numeroArticulo + " con la cantidad de: " + maxCantidad);

            for(int i = 0; i < 15; i++) 
            {
                if(totalCantidadVendida[i] == 0)
                {
                    Console.WriteLine("El producto : " + (i + 1) + " no tuvo ventas");
                }
            }

            Console.WriteLine("La cantidad de unidades que se vendieron del producto 10 son: " + totalCantidadVendida[9]);
        }
    }
}
