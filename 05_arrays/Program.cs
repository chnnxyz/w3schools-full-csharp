// See https://aka.ms/new-console-template for more information
using System;

namespace Arrays 
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Arrays need to have all elements of the same type
            // Arreys need to have defined sized or be assigned upon
            // instantiation
            string[] arr1 = {"a", "b", "c","d"};
            Console.WriteLine(arr1.Length);
            int[] numArr = {1,2,3,4};
            // Arrays don't have string versions
            Console.WriteLine(numArr);
            // obvs you can change an array element

            Console.WriteLine(numArr[0]);
            numArr[0] = 0;
            Console.WriteLine(numArr[0]);

            // you can instantiate something to use later with the new
            // keyword just like in java. You need to tell the size
            // and manually access any element.
            string[] useLater = new string[3];
            useLater[0] = "ni";
            useLater[1] = "no";
            useLater[2] = "nu";

            // looping through array with for loop
            for (int i = 0; i < useLater.Length; i++)
            {
                Console.WriteLine(useLater[i]);
            }
            
            // Looping through array elements
            foreach (string x in useLater)
            {
                Console.WriteLine(x);
            }
        }
    }
}