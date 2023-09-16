using System;

namespace ejercicio3
{
    class Program
    {

        // 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
        // El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. 
        // Mostrar el resultado en pantalla. Ejemplo:
        // CADENA FUENTE: “La mar estaba serena"
        // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
        // CADENA RESULTADO: “Li mir estibi sereni"
        
        static void Main(string[] args)
        {
            char[] palabras = new char[30];
            char letraActual;
            char letraNueva;
            char letra;
            int indice = 0;

            Console.WriteLine("Ingrese una letra: ");
            letra = char.Parse(Console.ReadLine());
            while(letra != '0' && indice < 30)
            {
                palabras[indice] = letra;
                Console.WriteLine("Ingrese otra letra: ");
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
            palabras[indice] = '\0';
            Console.WriteLine("La frase completa es: ");
            indice = 0;
            while(palabras[indice] != '\0')
            {
                Console.Write(palabras[indice]);
                indice++;
            }

            Console.WriteLine("\nIngrese la letra para reemplazar: ");
            letraActual = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo caracter de sustitucion");
            letraNueva = char.Parse(Console.ReadLine());

            indice = 0;
            while(palabras[indice] != '\0')
            {
                if(palabras[indice] == letraActual)
                {
                    palabras[indice] = letraNueva;
                }
                    indice++;
            }
            Console.WriteLine("La frase nueva es: ");
            indice = 0;
            while (palabras[indice] != '\0')
            {
                Console.Write(palabras[indice]);
                indice++;
            }

            //Forma actual

            // string frase;
            // char letraActual;
            // char letraNueva;
            // Console.WriteLine("Ingrese la frase: ");
            // frase = Console.ReadLine();
            // Console.WriteLine("Ingrese la letra a reemplazar: ");
            // letraActual = char.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el nuevo carácter:");
            // letraNueva = char.Parse(Console.ReadLine());

            // frase = frase.Replace(letraActual, letraNueva);
            // Console.WriteLine($"Frase modificada:{frase}");
            
        }
    }
}
