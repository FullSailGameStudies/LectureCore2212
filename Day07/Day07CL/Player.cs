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
    }
}
