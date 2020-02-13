using System;

namespace _08.VectorRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX=15;
            int[] A = new int[MAX];
            int[] B = new int[MAX];
            int[] C = new int[MAX];

            Random ale = new Random();

            for(int i=0; i<MAX; i++)
            {
                A[i]=ale.Next(1,100);
                B[i]= ale.Next(1,100);
                C[i]= A[i]+B[i];
            }
            imprime(A);
            imprime(B);
            imprime(C);

            Console.WriteLine("Suma de 2 vectores aleatorios con 15 elementos \n");
        }

        static void imprime(int[] Z)
        {
            for(int i=0; i<Z.Length; i++)
                Console.WriteLine($"{Z[i]}");
            Console.WriteLine();    
        }
    }
}
