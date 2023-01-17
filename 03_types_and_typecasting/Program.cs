// See https://aka.ms/new-console-template for more information
using System;

namespace TypeCast
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables can be implicitly casted in this hierarchy
            // char -> int -> long -> float -> double -> string
            // an exmple of implicit casting is 
            int myInt = 9;
            double myDouble = myInt;

            // Explicit casting
            // use type between parentheses
            // This can be used when not following the hierarchy above
            double myDouble2 = 9.78;
            int myInt2 = (int) myDouble2;    // Manual casting: double to int

            Console.WriteLine(myDouble2);   // Outputs 9.78
            Console.WriteLine(myInt2);      // Outputs 9, essentially truncates

            // Aditionally, the system namespace has a Convert class with
            // several conversion methods

            int myInt3 = 10;
            double myDouble3 = 5.25;
            bool myBool3 = true;

            Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool3));   // convert bool to string

        }
    }
}
