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

            Player player = new Player('$', 20, 10, ConsoleColor.Yellow);
            gameObj.MoveRight();
            player.MoveRight();//player is passed in as the 'this' parameter
            
            GameObject.DebugInfo();//static methods do NOT have a 'this' param

            Person me = new Person(25, "Bruce Wayne");
            me.ItsMyBirthday();
            me.Promotion(JobPosition.CEO);

            int smallNum = 5;
            long bigNum = smallNum;//implicit cast
            smallNum = (int)bigNum;//explicit cast

            Grenade bomb = new Grenade(10, 50, 100);

            // UPCASTING
            // going from a DERIVED type (Grenade) casting to a BASE type (Weapon)
            // ALWAYS SAFE!!
            Weapon handWeapon = bomb;
            player.PickupItem(bomb);//upcasts to a Weapon
            player.PickupItem(new Pistol(25, 25, 50, 25));

            //DOWNCASTING
            // going from a BASE type (Weapon) casting to a DERIVED type (Grenade)
            // !!!! NOT SAFE !!!!
            // 3 ways: explicit cast, as keyword, pattern matching

            //1) explicit cast with try-catch
            try
            {
                Pistol walter = (Pistol)handWeapon;
            }
            catch (Exception)
            {
            }

            //2) 'as' keyword
            Pistol bang = handWeapon as Pistol;//will assign NULL to bang if it can't be downcasted
            if(bang != null)
                Console.WriteLine(bang.MagCapacity);

            //3) pattern matching using the 'is' keyword
            if(handWeapon is Pistol colt)
                Console.WriteLine(colt.MagCapacity);

            player.Inventory();

            Console.ReadKey();
            Console.Clear();

            List<GameObject> gameObjs = new List<GameObject>();
            for (int i = 0; i < 20; i++)
            {
                gameObjs.Add(Factory.RandomSpawn());
            }
            gameObjs.Add(player);

            while (true)
            {
                Drawobjects(gameObjs);
                Console.ReadKey();
            }
        }

        private static void Drawobjects(List<GameObject> gameObjs)
        {
            foreach (GameObject gameObj in gameObjs)
            {
                gameObj.DrawMe();
            }
        }
    }
}
