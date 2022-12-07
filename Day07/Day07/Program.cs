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
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //
            // CREATE a person class in the class library
            //      add a field for the age

            GameObject gameObj;//NULL
            gameObj = new GameObject(10,5,ConsoleColor.Red);
            gameObj.X = 15;//calling the set on the property
            Console.WriteLine(gameObj.X);//calls the get on the property

            //gameObj.Color = ConsoleColor.DarkYellow;
            Console.WriteLine(gameObj.Color);

            GameObject player = new GameObject(20, 10, ConsoleColor.Yellow);
            gameObj.MoveRight();
            player.MoveRight();//player is passed in as the 'this' parameter
            
            GameObject.DebugInfo();//static methods do NOT have a 'this' param

            Person me = new Person(25, "Bruce Wayne");
            me.ItsMyBirthday();
            me.Promotion(JobPosition.CEO);
        }
    }
}
