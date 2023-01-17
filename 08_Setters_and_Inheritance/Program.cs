using System;

namespace InheritanceAndMore
{   
    class EldritchHorror
    {
        public static string alignment = "Evil";
        // To access this on an instance level, we need to create an instance
        // method.
        public string getAlignment()
        {
            return alignment;
        }
        public string name;
        public string form;
        public bool tentacles;
        // we make this only accessible to the class
        private int numTentacles = 0;
        // we add a property to this.
        public int NumTentacles
        {
            // get and set are reserved keywords.
            // get is accessed when you call for numTentacles,
            // set is accessed when you assign a value
            // this is different to adding rules in the constructor
            // since this can work on an already instantiated object.
            get {
                return numTentacles;
            }
            set {
                // value is a keyword that is whatever value you are trying to
                // assign
                if(value == 2 || value == 4 || value == 8 || value == 16)
                {
                    numTentacles = value;
                }
                else
                {
                    numTentacles = 0;
                }

            }
        }

        public EldritchHorror(
            string aName,
            string aForm,
            bool aTentacles
        ){
            if (!(new[] {"humanoid","animal","impossible"}.Contains(aForm))){
                throw new ArgumentException("Invalid form");
            }
            name = aName;
            form = aForm;
            tentacles = aTentacles;
        }

        // Contrary to static methods, object methods use the values for a 
        // specific object and requires the object to be instantiated.
        // Which means you cannot call EldritchHorror.Screech() but if you
        // instantiate cthulhu, you can call cthulhu.Screech()
        public void Scream(){
            switch (form){
                case "humanoid":
                    Console.WriteLine("Hnnnnngh");
                    break;
                case "animal":
                    Console.WriteLine("Grrrrrrr");
                    break;
                case "impossible":
                    Console.WriteLine("The creature is so weird you can't tell the sound");
                    break;
            }
        }

        // now we have a static method that can be used for the player to sense
        // if there are portals for eldritch horrors.
        public static void Scan(){
            Random rnd = new Random();
            int diceroll = rnd.Next(20);
            if (diceroll >=12)
            {
                Console.WriteLine("No horrors here");
            }
            else
            {
                Console.WriteLine("Beware, ya dingus.");
            }
        }

    }
    class Program
    {
        static void Main(string[] args){
            EldritchHorror cthulhu = new EldritchHorror(
                "Cthul'hu",
                "impossible",
                true
            );

            Console.WriteLine(cthulhu.name);
            cthulhu.Scream();

            // We can see that Scream is an object method since it will
            // print a different value for both of these eldritch horrors
            EldritchHorror alluin = new EldritchHorror(
                "Alluin",
                "humanoid",
                false
            );

            Console.WriteLine(alluin.name);
            alluin.Scream();

            // Let's try and have alluin grow a new tentacle
            alluin.NumTentacles = 1;
            // Since it can only grow powers of two.
            // this should return 0.
            Console.WriteLine(alluin.NumTentacles);
            // he now tries to grow two. Grow a pair, you might say.
            alluin.NumTentacles = 2;
            Console.WriteLine(alluin.NumTentacles);

            // Getters and setters are, in the end, glorified input validation
            
            //let's try making the poor possessed alluin good.
            // try
            // {
            //     alluin.alignment = "Good";
            // }
            // catch
            // {

            // }
            // This ends up commented because you cannot even try catch it
            // because error is at compile time.
            // you cannot access them from an instance either, so
            // you access them on a class level.
            Console.WriteLine(EldritchHorror.alignment);
            // access the static value through instance method.
            Console.WriteLine(alluin.getAlignment());

            EldritchHorror.Scan();
        }
    }
}