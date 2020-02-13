using System;

namespace _04.ciclos
{
    class Program1
    {
        static int Main(string[] args)
        {
            if(args.Legth==0) Menu();
            op=int.Parse(args[0]);
            switch (0)
            {
                case 1 :
                {
                    c=1;
                    suma=0;
                    while(c<=100)
                    {
                        Console.Write($"{c} ");
                        suma+=c;
                        c++;
                    }
                    Console.Writeline($"La suma es {suma} \n");
                }
                break;
                case 2 :
                {
                    c=100;
                    suma=0;
                    while(c>=1)
                    {
                        Console.Write($"{c} ");
                        suma+=c;
                        c--;
                    }
                    Console.Writeline($"La suma es {suma} \n");
                }
                break;
                case 3 :
                {
                    suma=0;
                    for(c=50 ; c<=200; c++)
                    {
                        Console.Write($"{c} ");
                        suma+=c;
                    }
                    Console.Writeline($"La suma es {suma} \n");
                }
                break;
                case 4 :
                {
                    suma=0;
                    for(c=2 ; c<=100; c+=2)
                    {
                        Console.Write($"{c} ");
                        suma+=c;
                    }
                    Console.Writeline($"La suma es {suma} \n");
                }
                break;
                case 5 :
                {
                    suma=0;
                    for(c=99 ; c>=1; c+=2)
                    {
                        Console.Write($"{c} ");
                        suma+=c;
                    }
                    Console.Writeline($"La suma es {suma} \n");
                }
                break;
                default : Console.Writeline("Opcion Invalida");
                break;
            }
            return 0;
        }
        static void Menu()
        {
            Console.clear();
            Console.Writeline("Programa sobre uso de estructuras de control\n");
            Console.Writeline("Números del 1 al 100 con ciclo while ");
            Console.Writeline("Números del 100 al 1 con ciclo do .. while ");
            Console.Writeline("Números del 50 al 200 con ciclo for");
            Console.Writeline("Números del 2 al 100 solo los pares con ciclo for");
            Console.Writeline("Números del 99 al 1 solo los impares con ciclo for");
            Console.Writeline("Números del 272 al 40 en decrementos de 4 con ciclo while");


        }
    }
}