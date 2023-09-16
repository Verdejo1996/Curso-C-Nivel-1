using System;

namespace promedioAlumno
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, promedio;
            string alumno;

            Console.WriteLine("Ingrese el alumno: ");
            alumno = Console.ReadLine();

            Console.WriteLine("Ingrese la nota 1: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 2: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3: ");
            nota3 = float.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("El promedio del alumno " + alumno + " es: " + promedio.ToString("0.00"));

        
        }
    }
}
