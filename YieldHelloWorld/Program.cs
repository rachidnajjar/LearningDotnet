using System;
using System.Collections.Generic;

namespace YieldHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display powers of 2 up to the exponent of 8:
            foreach (int i in Power(2, 8))
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();


            foreach (int item in Puissance(2, 8))
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            GalaxyClass.ShowGalaxies();
        }


        // Cette méthode calcule les puissances et les retourne les éléments un à un à mesure qu'ils sont calculés
        public static IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }

        // Cette méthode calcule les puissances puis retourne tous les éléments à la fin
        public static IEnumerable<int> Puissance(int number, int exponent)
        {
            IList<int> liste = new List<int>();
            
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                liste.Add(result);
            }

            return liste;
        }

    }
}
