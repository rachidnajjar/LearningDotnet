using System;
using System.IO;

namespace ExceptionsConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = File.OpenText("data.txt"))
                {
                    Console.WriteLine($"The first line of this file is {sr.ReadLine()}");
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"The file was not found:\r\n{e}");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"The directory was not found:\r\n{e}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"The file could not be opened:\r\n{e}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An exception occured:\r\n{e}");
            }
        }
    }
}
