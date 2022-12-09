using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    //
    // edge, club, pistols, rifles, grenades
    // create a Pistol weapon class that derives from Weapon.
    //      Data: mag capacity, # of rounds
    //      Methods: Shoot

    public abstract class Weapon
    {
        public Weapon(int range, int damage)
        {
            Range = range;
            Damage = damage;
        }

        public int Range { get; }
        public int Damage { get; }
    }
}
