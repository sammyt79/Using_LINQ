using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Simulation
{
    class Dice
    {
        private static Random rnd = new Random(Guid.NewGuid().GetHashCode()); // Initiate a random object.

        public int currnetValue { get; set; }

        public int Roll()
        {
            currnetValue = rnd.Next(1, 7);
            return currnetValue;
        }
    }
}
