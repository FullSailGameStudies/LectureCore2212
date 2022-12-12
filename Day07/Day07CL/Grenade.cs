using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Grenade : Weapon
    {
        public Grenade(int blastRadius, int range, int damage) : base(range, damage)
        {
            BlastRadius = blastRadius;
        }

        public int BlastRadius { get; }

        public override void ShowMe()
        {
            base.ShowMe(); 
            Console.WriteLine($"\tBlast Radius: {BlastRadius}");

        }
    }
}
