using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Factory
    {
        static Random _rando = new Random();

        //everything inside must be static
        public static GameObject RandomSpawn()
        {
            GameObject gObject;
            gObject = new GameObject(
                _rando.Next(Console.WindowWidth),
                _rando.Next(Console.WindowHeight),
                (ConsoleColor)_rando.Next(16)//explicit cast
                );
            return gObject;
        }
        public static GameObject Spawn(int x, int y, ConsoleColor color)
        {
            return new GameObject(x, y, color);
        }

        //
        //add a factory method to create Person instances
        //
        public static Person MakePerson(int age, string fullName)
        {
            Person peep = new Person(age, fullName);
            return peep;
        }
    }
}
