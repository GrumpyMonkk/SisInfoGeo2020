using System;

namespace _07.VectorPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = {10,20,30,40,50,60,70,80,90,100,
                            10,20,30,40,50,60,70,80,90,100,
                            10,20,30,40,50,60,70,80,90,100,
                            10,20,30,40,50,60,70,80,90,100,
                            10,20,30,40,50,60,70,80,90,100 };

                            Console.WriteLine("Calcular el promedio de 50 valores constantes! \n");
                            Console.WriteLine("Los elementos del arreglo son: \n");
                            imprime(vector);
                            float promedio=prom(vector);
                            Console.WriteLine($"El promedio es {promedio}");
                            Console.WriteLine($"Mayores que el promedio {mayores(vector,promedio)}");
        }


        static int mayores(int[] A, float Z)
        {
            int cont=0;
            for(int i=0; i<A.Length; i++)
            {
                if(A[i] > Z)
                {
                    cont++;
                }
            }
            return cont;
        }

        static void imprime(int[] A)
        {
            for(int i=0; i<A.Length; i++)
            {
                Console.WriteLine($"{A[i]}");
            }
            Console.WriteLine();
        }

        static float prom(int[] A)
        {
            int suma=0;
            for(int i=0; i<A.Length; i++)
            {
                suma+=A[i];
            }
            return suma / A.Length;
        }
    }
}
