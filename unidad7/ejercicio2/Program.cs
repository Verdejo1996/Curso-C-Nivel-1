using System;

namespace ejercicio2
{
    class Program
    {

        // 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
        // Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
        
        static void Main(string[] args){

        int n;
        Console.WriteLine("Ingrese 10 numeros: ");

        int[] array = new int [10];

        for(int i = 0; i < 10; i++) 
        {
            n = int.Parse(Console.ReadLine());
            array[i] = n;
        }

        int suma = 0;
        float promedio;

        for(int i = 0; i < 10; i++) 
        {
            suma += array[i];    
        }
        promedio = (float)suma / 10 ;
        Console.WriteLine("\nEl promedio de los elementos es " + promedio);

        for(int i = 0; i < 10; i++) 
        {
            if(array[i] > promedio)
            {
                Console.WriteLine("Los numeros mayores al promedio son: " + array[i]);
            }    
        }
        }
    }
}
