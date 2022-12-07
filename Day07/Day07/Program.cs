using Day07CL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //
            // CREATE a person class in the class library
            //      add a field for the age

            GameObject gameObj;//NULL
            gameObj = new GameObject(10,5,ConsoleColor.Red);
            gameObj.X = 15;//calling the set on the property
            Console.WriteLine(gameObj.X);//calls the get on the property

            //gameObj.Color = ConsoleColor.DarkYellow;
            Console.WriteLine(gameObj.Color);
        }
    }
}
