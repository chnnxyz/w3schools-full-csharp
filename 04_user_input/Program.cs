// See https://aka.ms/new-console-template for more information
using System;

namespace UserIn
{
    class Program
    {
        static void Main(string[] args)
        {
            // Think of readline as equivalent to writeline but for the user
            // contrary to python you cannot add a direct prompt
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            // Let's try typecasting in one line
            Console.WriteLine("What is your age?");
            // The following typecast for some reason dont work,
            // probably because on compile time you cant guarantee this string
            // will be parsable to int.
            // int age = (int) Console.ReadLine();

            // as expected, this function works at runtime so it will crash
            // the program if the string provided cant be converted
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You are " + name);
            Console.WriteLine("You are " + age + " years old");
            Console.WriteLine("You will be " + (age + 1) + " years old");
        }
    }
}
