using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal static class ExtraChallenges
    {
        enum Superpower
        {
            Money, Strength, Flight, Speed, Invisibility
        }
        private static Dictionary<string, Superpower> _supers = new Dictionary<string, Superpower>();


        public static void Run()
        {
            Challenge1();
            Challenge2();
            Challenge3();
            Challenge4();
            Challenge5();
        }


        private static void Challenge1()
        {
            Console.WriteLine("\n\n--------CHALLENGE 1-----------");
            Console.WriteLine("Add 4 superheroes to the _supers Dictionary using the Add method");

            //Add 4 superheroes to the _supers Dictionary using the Add method

            Continue();
        }
        private static void Challenge2()
        {
            Console.WriteLine("\n\n--------CHALLENGE 2-----------");
            Console.WriteLine("Loop over _supers with a foreach loop and print out each superhero name and power");

            //Loop over _supers with a foreach loop and print out each superhero name and power

            Continue();
        }
        private static void Challenge3()
        {
            Console.WriteLine("\n\n--------CHALLENGE 3-----------");
            Console.WriteLine("use TryGetValue to check if a superhero is in the dictionary. print out the enum if the superhero is found");

            //use TryGetValue to check if a superhero is in the dictionary. print out the enum if the superhero is found

            Continue();
        }
        private static void Challenge4()
        {
            Console.WriteLine("\n\n--------CHALLENGE 4-----------");
            Console.WriteLine("use TryGetValue to check if a superhero is in the dictionary. Try with a superhero that is not in the dictionary");

            //use TryGetValue to check if a superhero is in the dictionary. Try with a superhero that is not in the dictionary

            Continue();
        }
        private static void Challenge5()
        {
            Console.WriteLine("\n\n--------CHALLENGE 5-----------");
            Console.WriteLine("Remove one of the superheroes using the Remove method then print out the dictionary");

            //Remove one of the superheroes using the Remove method then print out the dictionary

            Continue();
        }

        private static void Continue()
        {
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
