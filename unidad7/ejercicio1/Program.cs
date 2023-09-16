// See https://aka.ms/new-console-template for more information

// 1. Hacer un programa que solicite 10 números enteros
//  y los guarde en un vector. Luego recorrer los elementos y determinar 
//  e informar cuál es el valor máximo y su posición dentro del vector.

int n;
Console.WriteLine("Ingrese 10 numeros: ");

int[] array = new int [10];

for(int i = 0; i < 10; i++) 
{
    n = int.Parse(Console.ReadLine());
    array[i] = n;
}

int maximo = array[0];
int posMaximo = 0;

for(int i = 0; i < 10; i++) 
{
    if(array[i] > maximo)
    {
        maximo = array[i];
        posMaximo = i;
    }
}

int posicion = 0;

for(int i = 0; i < 10; i++) 
{
    if(array[posicion] < array[i])
    {
        posicion = i;
    }    
}

Console.WriteLine("El maximo fue: " + maximo);
Console.WriteLine("Y su posicion es: " + posicion);