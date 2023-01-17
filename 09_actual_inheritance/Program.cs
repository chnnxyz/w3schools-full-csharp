using System;

namespace ICookaDaPasta
{
    class Cook
    // some goon with base cooking experience. Can cook chicken and Pasta
    {
        public void CookChicken()
        {
            Console.WriteLine("I Cooka Da Chicken!");
        }
        // in order to be able to override a method we have to make it virtual
        public virtual void CookPasta()
        {
            Console.WriteLine("I Cooka Da Pasta!");
        }
    }

    class Chef: Cook // this is the notation for inheritance, weird.
    // less of a goon, can make everything cook does but even more.
    // not so good at chicken tho
    {
        public void CookPasta() 
        {
            Console.WriteLine("I Cooka Da Better Pasta!");
        }

        public void CookWellington()
        {
            Console.WriteLine("Mamma Mia, I Can Cooka Food that its-a not italian");

        }
    }

    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Cook");
            Cook ck = new Cook();
            ck.CookChicken();
            ck.CookPasta();
            Console.WriteLine("Chef");
            Chef cf = new Chef();
            cf.CookChicken();
            cf.CookPasta();
            cf.CookWellington();
        }
    }
}
