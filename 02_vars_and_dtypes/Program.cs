// See https://aka.ms/new-console-template for more information
using System;

namespace VarsAndTypes
{
    class Program {
        static void Main(string[] args){
            // To declare a variable, you pass in a data type and then varname
            // then assign
            int someInteger = 5;
            // double is the standard for floating point variables
            double someFloat = 5.99;
            // Can you add int and float?
            Console.WriteLine("Integer + float test:");
            Console.WriteLine(someFloat + someInteger); 
            // char is a primitive that can only contain one character
            char a = 'a';
            // string on the other side, is essentially an array of chars
            string myName = "Sasha";
            // bool is short for boolean
            // true and false are not capitalized.
            bool isItTrue = false;

            // Contrary to rust, all variables are mutable by default
            // to make them immutable, it is needed to add const before.
            const double gravity = 9.81;

            // Most variables have a string form and can be concatenated with
            // the + operator
            Console.WriteLine("Most variables can be parsed as text:");
            Console.WriteLine("Here is a character: " + a);
            Console.WriteLine("Here is a string: " + myName);
            Console.WriteLine("Here is a bool: " + isItTrue);
            Console.WriteLine("Here is a the constant of gravity: " + gravity);
            
            // You can assign several variables on a single line.
            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);

            // You can also instantiate and then assign.
            int o, p, q;
            o = p = q = 100;
            Console.WriteLine(o+p+q);

        }
    }
}
