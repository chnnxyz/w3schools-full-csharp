using System;

namespace OopBasics
{
    class Car
    {
        // This is a class attribute, by default, this will be the same in any
        // instance of the class
        public int wheels = 4;

        // this is a public method, it can be accessed outside the class.
        public void Honk()
        {
            Console.WriteLine("beep beep");
        }
    }

    // You can also use class constructors and pass in parameters
    class CustomCar
    {
        public int wheels = 4;
        public bool engine = true;
        public string model;
        public string color;
        public int nCylinders;
        public int horsepower;

        // arguments cant have the same name as class attributes
        public CustomCar(
            string modeln = "Mustang",
            string carcolor = "red",
            int cylinders = 4,
            int hp = 5000
        ) {
            model = modeln;
            color = carcolor;
            nCylinders = cylinders;
            horsepower = hp;
        }

        public void Honk(string noise="beep"){
            Console.WriteLine($"{noise} {noise}!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {   
            // Instantiate a new car object.
            //every time you use "new" you create a new objecrt instance
            Car myObj = new Car();
            myObj.Honk();

            CustomCar myPrius = new CustomCar(
                modeln:"Prius",
                cylinders:4,
                carcolor:"blue"
            );
            Console.WriteLine($"My car is a {myPrius.color} {myPrius.model}");
            Console.Write("It goes ");
            myPrius.Honk("beeeeeeep");
        }
    }
}
