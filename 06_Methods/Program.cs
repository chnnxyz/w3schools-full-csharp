using System;

namespace mthds
{
    class Program
    {
        // Main is a method, but you can generate any other methods.
        // Static methods belong to the class itself and not to instances of it
        // voi means no return type.
        // This particular onne has no arguments.
        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        // This one does the same as the previous one but can take in arguments
        // Also you can pass in default values
        //Keyword arguments, however are not a thing, and you need to pass in
        // all params in order. Or that we beleive up to now.
        static void Salute(string title="Mx.", string name="uwu")
        {
            Console.WriteLine($"Hello {title} {name}");
        }

        // If not using void, you need a return of the defined type.
        static int Square(int x)
        {
            // keyword is, ob iously, return.
            return x * x;
        }

        static void Main(string[] args)
        {   
            // Methods in the sme class can be easily accessed.
            HelloWorld();
            Salute("Mx.","sasha");
            Salute();
            Salute("Ms.");
            Console.WriteLine(Square(3));
            // Except we acrually can pass in arguments using key val
            // and in any order
            Salute(name:"Pepito", title:"mr");
        }
    }
}


//Final notes, methods can have the same name and take in different arguments.