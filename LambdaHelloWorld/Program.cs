using System;
using System.Linq;
using System.Linq.Expressions;

namespace LambdaHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //*********************************************
            // Lambda expressions
            //*********************************************

            Func<int, int> square; // on déclare une variable de type delegate
            square = x => x * x; // on assigne une lambda expression à notre variable delegate
            int i = square(3); // on execute la méthode square
            Console.WriteLine($"result : {i}");

            //---------------------------------------------
            Expression<Func<int, int>> addition = x => x + x;
            Console.WriteLine(addition);

            //---------------------------------------------
            int[] numbers = { 1, 2, 3, 4, 5 };
            var squareNumbers = numbers.Select(x => x * x);
            string s = string.Join(";", squareNumbers);
            Console.WriteLine($"resultat : {s}");

            //*********************************************
            // Lambda statements
            //*********************************************
            Action<string> greet = name => {
                string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };
            greet("rachid najjar");

            //---------------------------------------------
            Action ecrireLigne = () => Console.WriteLine(); // lambda statement sans parametre
            ecrireLigne();

            //---------------------------------------------
            Func<int, int, bool> testerEgalite = (x, y) => x == y; // lambda statement avec 2 parametres
            bool b = testerEgalite(5, 3);
            Console.WriteLine($"testerEgalite : {b}");

            //---------------------------------------------
            Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x; // lambda statement avec type explicite
            b = isTooLong(3,"Bonjour");
            Console.WriteLine($"isTooLong : {b}");


        }
    }
}
