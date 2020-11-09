using System;

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Nombre de paramètres passés en argument : {args.Length}");


            string param1 = "world";
            if (args.Length > 0)
            {
                param1 = args[0];
            }


            Console.WriteLine($"Hello {param1}!");
        }
    }
}
