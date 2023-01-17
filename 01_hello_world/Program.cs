// See https://aka.ms/new-console-template for more information
// using keyword is basically import equivalent
using System;

// a namespace organizes a set of classes and can contain other namespaces
namespace HelloWorld
{
    class Program
    {
        // the Main method always has to be TitleCased
        static void Main(string[] args)
        {
            // Console is included within System.
            // using System is equivalent in python to from system import *

            // Writeline adds \n at the end of the text, write does not.
            // String needs to always use double quotes, single quotes are char
            // variables
            Console.WriteLine("Hello World!");
            Console.Write("Hi");
            Console.Write(" ");
            Console.WriteLine("baby!");
        }
    }
}