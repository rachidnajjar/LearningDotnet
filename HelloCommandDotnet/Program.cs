using System;
using CommandDotNet;

namespace HelloCommandDotnet
{
    class Program
    {
        static int Main(string[] args)
        {
            return new AppRunner<CalculatorCommand>().Run(args);
        }
    }
}
