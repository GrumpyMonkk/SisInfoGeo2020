using System;

namespace _05.pizza
{
    class Program
    {
        private const int V = 1;

        static int Main(string[] args)
        {
            if((args.Length == 0))
            {
                Menu();
                return V;
            }

           
        

        char tam=char.Parse(args[0]);
        string[] ings = args[1].Split("+");
        char cub = char.Parse(args[2]);
        char don = char.Parse(args[3]);
        string tamano ="", ingredientes="", Cubierta="", Donde="";

        if(tam =='P') tamano="Pequena";
        else if(tam=='M') tamano="Mediana";
        else tamano="Grande";

        foreach(string i in ings)
        {
            switch (char.Parse(i))
            {
                case 'E': ingredientes+="Extra queso, "; break;
                case 'C': ingredientes+="Champinones, "; break;
                case 'T': ingredientes+="Tomates, "; break;
            }
        }

        if(cub=='D') Cubierta="Delgada"; else Cubierta="Gruesa";
        if(don=='C') Donde="Comer aqui"; else Donde="Para llevar";

        Console.Clear();
        Console.WriteLine($"Tamaño      :    {tamano}");
        Console.WriteLine($"Ingredientes:   {ingredientes}");
        Console.WriteLine($"Cubierta    :  {Cubierta}");
        Console.WriteLine($"Donde comer :   {Donde}\n");

      
         return 0;
        }
        static void Menu() 
        {
            Console.WriteLine("Procesando Pizzas \n");
            Console.WriteLine("Tamaño: Puede ser de tamaño (P) Pequena, (M) Mediana o (G) Grande. ");
            Console.WriteLine("Ingredientes: (E)Extra Queso, (C) Champinones, (T)Tomates. ");
            Console.WriteLine("Cubierta: (D) Delgada o (G) Gruesa");
            Console.WriteLine("Donde se consume: (C) Comer aqui o (P) Para llevar. \n");
            Console.WriteLine("<Tamano> <ing1+ing2...> <Cubierta> <Donde>");
        }
    }
}
