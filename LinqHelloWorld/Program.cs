using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Linq query syntax!");
            
            // Linq query syntax
            var startingDeckLinqQuery = (from s in Suits()
                                        from r in Ranks()
                                        select new { Suit = s, Rank = r }).ToArray();

            // Display each card that we've generated and placed in startingDeck in the console
            foreach (var card in startingDeckLinqQuery)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine("Hello Linq method syntax!");

            // Linq method syntax
            var startingDeckLinqMethod = Suits().SelectMany(s => Ranks().Select(r => new { Suit = s, Rank = r})).ToArray();

            // Display each card that we've generated and placed in startingDeck in the console
            foreach (var card in startingDeckLinqMethod)
            {
                Console.WriteLine(card);
            }


            Console.WriteLine("On mélange les cartes !");
            // on coupe le tas de cartes en 2 (52/2=26)
            var top = startingDeckLinqQuery.Take(26);
            var bottom = startingDeckLinqQuery.Skip(26);

            var shuffle = top.InterleaveSequenceWith(bottom);
            foreach (var card in shuffle)
            {
                Console.WriteLine(card);
            }

            // On mélange plusieurs fois jusqu'à retrouver l'ordre initial
            var times = 0;
            // We can re-use the shuffle variable from earlier, or you can make a new one
            shuffle = startingDeckLinqQuery;
            do
            {
                shuffle = shuffle.Skip(26).InterleaveSequenceWith(shuffle.Take(26)).ToArray();
                times++;

            } while (!startingDeckLinqQuery.SequenceEquals(shuffle));

            Console.WriteLine(times);


        }

        static IEnumerable<string> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
    }
}
