using System;

namespace _10.VectorSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX=30;
            double[] A = new double[MAX];
            Random ale = new Random();
            int cp=0,cn=0,cz=0;
            double sp=0,sn=0,sz=0;

            for(int i=0; i<MAX; i++)
            {
                A[i] = ale.Next(-10,50);
                if(A[i]>0)
                {
                    cp++;
                    sp++;
                }
                else if(A[i]<0)
                {
                    cn++;
                    sn+=A[i];
                }
                else 
                {
                    cz++;
                    sz+=A[i];
                }
            }

            Console.WriteLine("Suma de numeros en un vector aleatorio \n");
            Console.WriteLine($"Los positivos son {cp} y suman {sp}");
            Console.WriteLine($"Los negativos son {cn} y suman {sn}");
            Console.WriteLine($"Los ceros son {cz} y suman {sz}");
        }
    }
}
