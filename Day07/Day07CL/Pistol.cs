using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Pistol : Weapon
    {
        public Pistol(int magCap, int rounds, int range, int damage) : base(range,damage)
        {
            MagCapacity = magCap;
            Rounds = rounds;
        }

        public int MagCapacity { get; }
        public int Rounds { get; }
    }
}
