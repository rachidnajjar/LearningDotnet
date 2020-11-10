using System;

namespace GenericsConsole1
{
    class Program
    {
        private class Example 
        { 

        }
        static void Main(string[] args)
        {
            // Declare a list of type int.
            GenericList<int> listOfInt = new GenericList<int>();
            listOfInt.Add(1);

            // Declare a list of type string.
            GenericList<string> listOfString = new GenericList<string>();
            listOfString.Add("");

            // Declare a list of type Example.
            GenericList<Example> listOfExample = new GenericList<Example>();
            listOfExample.Add(new Example());

        }
    }
}
