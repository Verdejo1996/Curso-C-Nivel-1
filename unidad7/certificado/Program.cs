using System;

namespace certificado
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            Console.WriteLine(EsNumeroPerfecto(n));

            
        }

        static bool EsNumeroPerfecto(int n)
        {
            
            int sumaDivisores = 0;

            

            for(int i = 1; i < n; i++) 
            {
                if(n % i == 0)
                {
                    sumaDivisores += i;
                }

            }
            return sumaDivisores == n;
        }
    }
}
