// See https://aka.ms/new-console-template for more information
using System;
// Adds Min, Max and Sum methods to arrays.
using System.Linq;

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

            //multidim arrays
            int[,] arr2d = {{0,1},{1,0}};
            int[,,] arr3d = {{{1,3},{2,4}},{{1,5},{2,6}}};
            // Length provides the length of an equivalent 1d array containing
            // all elements.
            Console.WriteLine(arr3d.Length);
            //get trace of arr3d
            double trace = 0;
            // To get the length of a specific dimension, we use the
            // GetLength() method.
            for (int i = 0; i < arr3d.GetLength(0); i++)
            {
                trace += arr3d[i,i,i]; 
            }
            Console.WriteLine(trace);
        }
    }
}