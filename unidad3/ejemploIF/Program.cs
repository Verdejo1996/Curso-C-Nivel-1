using System;

namespace ejemploIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //BLOQUE IF: Condicionales
            //> < >= <= == !=
            // valor OP valor
            // n1 > 10
            // 10 > 5 no es correcto conceptualmente

            int edad = 25;

            if(edad > 30)
                Console.WriteLine("30 OFF");
            else if(edad > 20)
                Console.WriteLine("20 OFF");
            else if(edad == 18)
                Console.WriteLine("10 OFF");
            else
                Console.WriteLine("5 OFF");
            

            Console.WriteLine("Fin del programa");
        }
    }
}
