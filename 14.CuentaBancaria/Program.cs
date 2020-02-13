using System;

namespace _14.CuentaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria evers = new CuentaBancaria(1000);
            Console.WriteLine($"Saldo al crear {evers.Saldo}");
            evers.Saldo=500;
            Console.WriteLine($"Saldo despues del domingo {evers.Saldo}");
            if(evers.Retira(2500))
            Console.WriteLine($"Saldo despues de la peda {evers.Saldo}");
            else
            Console.WriteLine($"No tienes pito");
        }
    }
}
