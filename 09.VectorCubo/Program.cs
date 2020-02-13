using System;

namespace _09.VectorCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX=30;
            double[] A=new double[MAX];
            double[] B=new double[MAX];

            Random ale= new Random();

            for(int i=0; i<MAX; i++)
            {
                A[i]= ale.Next(1,10);
                B[i]= Math.Pow(A[i],3);
            }

            Console.WriteLine("Eleva al cubo 30 alementos en un vector \n");

            imprime(A);
            imprime(B);
        }

        static void imprime(double[] A)
        {
            for(int i=0; i<A.Length; i++)
                Console.WriteLine($"{A[i]} ");
            Console.WriteLine();
        }
    }
}
