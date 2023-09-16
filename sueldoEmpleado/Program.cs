using System;

namespace sueldoEmpleado
{
    class Program
    {
        static void Main(string[] args)
        {
            const double sueldo = 15000, comision = 0.05; 
            double totalFacturado, sueldoTotal;
            string nombreEmpleado;

            Console.WriteLine("Ingrese el nombre del empleado: ");
            nombreEmpleado = Console.ReadLine();
            Console.WriteLine("Ingrese el total facturado: ");
            totalFacturado = int.Parse(Console.ReadLine());

            sueldoTotal = sueldo + (totalFacturado * comision);

            Console.WriteLine("El sueldo total del empleado " + nombreEmpleado + " es: " + sueldoTotal);

        }
    }
}
