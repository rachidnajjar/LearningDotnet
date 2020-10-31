using CommandDotNet;
using System;

namespace HelloCommandDotnet
{
    [Command(Description = "Performs mathematical calculations")]
    public class CalculatorCommand
    {
        [Command(Description = "Adds two numbers")]
        public void Add(int value1, int value2)
        {
            int result = Calculator.Add(value1, value2);
            Console.WriteLine($"Result:  {result}");
        }

        [Command(Description = "Subtracts two numbers")]
        public void Subtract(int value1, int value2)
        {
            int result = Calculator.Subtract(value1, value2);
            Console.WriteLine($"Result:  {result}");
        }

        [Command(
            Name="multiplier",
            Usage="multiplier <int> <int>",
            Description = "Multiplie deux nombres entiers.",
            ExtendedHelpText="On peut mettre plus de détails ici.")]
        public void Multiply(int value1, int value2)
        {
            int result = Calculator.Multiply(value1, value2);
            Console.WriteLine($"Result:  {result}");
        }

    }
}