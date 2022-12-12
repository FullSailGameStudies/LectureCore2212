using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Player : GameObject
    {
        public char Symbol { get; set; }

        List<Weapon> _weapons = new List<Weapon>();

        public Player(char symbol, int x, int y, ConsoleColor color) : base(x,y,color)
        {
            Symbol = symbol;
        }

        public void PickupItem(Weapon weapon)
        {
            _weapons.Add(weapon);
        }

        //override DrawMe
        public override void DrawMe()
        {
            //FULLY OVERRIDING the base if you don't call it
            //base.DrawMe();//EXTENDING the base
            Console.SetCursorPosition(X, Y);
            Console.BackgroundColor = Color;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(Symbol);
        }

        //
        //create a method to display your inventory (list of weapons)
        // print the weapon info
        //  if it's a pistol, print the pistol info
        //  if it's a grenade, print the grenade info
        //
        public void Inventory()
        {
            foreach (Weapon weapon in _weapons)
            {
                weapon.ShowMe();
                //Console.WriteLine($"Range: {weapon.Range} Damage: {weapon.Damage}");
                ////Downcast
                //if(weapon is Pistol pistol)
                //    Console.WriteLine($"\tMagazing Capacity: {pistol.MagCapacity} Number of round: {pistol.Rounds}");
                //else if (weapon is Grenade grenade)
                //    Console.WriteLine($"\tBlast Radius: {grenade.BlastRadius}");
            }
        }
        // create a ShowMe method is Weapon
        //      print the weapon info
        // OVERRIDE it in Grenade/Pistol to show the Grenade/Pistol info
        // FIX Inventory to remove the Downcasting
    }
}
