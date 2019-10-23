using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a simple message to the user
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // Process any incoming args
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg: {0}", args[i]);
            }

            // Wait for enter key to be pressed before shutting down
            Console.ReadLine();
        }
    }
}
