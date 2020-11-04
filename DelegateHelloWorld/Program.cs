using System;

namespace DelegateHelloWorld
{
    class Program
    {
        // Je déclare un type delegate que je nomme Del 
        // qui peut encapsuler une methode avec string en argument et retour void
        public delegate void Del(string message);

        // Une méthode qui pourra être utilisé comme instance du delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        // Une méthode qui prend en paramètre un type delegate nommé callback
        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }

        static void Main(string[] args)
        {
            // Instantiate the delegate.
            Del delegateMethode = DelegateMethod;
            delegateMethode("Hello world for delegate !");
            MethodWithCallback(1, 2, delegateMethode);
        }

    }
}
