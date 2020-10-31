using CommandDotNet;
using System;

namespace HelloCommandDotnet
{
    [Command(Description = "Performs mathematical calculations")]
    public class Calculator
    {
        [Command(Description = "Adds two numbers")]
        public void Add(int value1, int value2)
        {
            Console.WriteLine($"Answer:  {value1 + value2}");
        }

        [Command(Description = "Subtracts two numbers")]
        public void Subtract(int value1, int value2)
        {
            Console.WriteLine($"Answer:  {value1 - value2}");
        }
    }
}