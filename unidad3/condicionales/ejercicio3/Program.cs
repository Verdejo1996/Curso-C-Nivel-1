using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. 
            Para ello existe la siguiente escala de precios:

                        i5 (1)	    i7 (2)	    i9 (3)
            8 RAM (1)	USD 800 	USD 900	    USD 1200
            16 RAM (2)	USD 900 	USD 1000	USD 1400
            32 RAM (3)	USD 1000	USD 1400	USD 2000

            Además, el equipo viene con un disco que permite almacenar 500 GB de información
            y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo
            adicional de USD 300. Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no 
            (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.
            */

            int procesador, ram, costoMaquina = 0, ampliarDisco;

            Console.WriteLine("Ingrese la opcion de procesador y memoria ram que desea comprar: ");
            procesador = int.Parse(Console.ReadLine());
            ram = int.Parse(Console.ReadLine());

            Console.WriteLine("Desea agregar mayor espacio en disco? Tiene un costo adicional de 300 USD.");
            ampliarDisco = int.Parse(Console.ReadLine());
            
            if(ampliarDisco == 1){
                costoMaquina += 300;              
            }
            else if(ampliarDisco == 0){
            }

            if (procesador == 5 && ram == 8){
                costoMaquina += 800;
                Console.WriteLine("Su maquina con esta configuracion tiene un costo de " + costoMaquina + ".");
            }

            if(procesador == 5 && ram == 16){
                costoMaquina += 900;
                Console.WriteLine("Su maquina con esta configuracion tiene un costo de " + costoMaquina + ".");
            }

            if(procesador == 5 && ram == 32){
                costoMaquina += 1000;
                Console.WriteLine("Su maquina con esta configuracion tiene un costo de " + costoMaquina + ".");
            }

            if(procesador == 7 && ram == 8){
                costoMaquina += 900;
                Console.WriteLine("Su maquina con esta configuracion tiene un costo de " + costoMaquina + ".");
            }

            if(procesador == 7 && ram == 16){
                costoMaquina += 1000;
                Console.WriteLine("Su maquina con esta configuracion tiene un costo de " + costoMaquina + ".");
            }

            if(procesador == 7 && ram == 32){
                costoMaquina += 1400;
                Console.WriteLine("Su maquina con esta configuracion tiene un costo de " + costoMaquina + ".");
            }

            if(procesador == 9 && ram == 8){
                costoMaquina += 1200;
                Console.WriteLine("Su maquina con esta configuracion tiene un costo de " + costoMaquina + ".");
            }

            if(procesador == 9 && ram == 16){
                costoMaquina += 1400;
                Console.WriteLine("Su maquina con esta configuracion tiene un costo de " + costoMaquina + ".");
            }

            if(procesador == 9 && ram == 32){
                costoMaquina += 2000;
                Console.WriteLine("Su maquina con esta configuracion tiene un costo " + costoMaquina + ".");
            }


            
            


        }
    }
}
