using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    public class HorseRace
    {
        private const int NUM_HORSES = 10;

        private List<Horse> horses;
        private int winner;

        public HorseRace()
        {
            horses = new List<Horse>();

            for (int i = 0; i < NUM_HORSES; i++)
            {
                horses.Add(new Horse());
            }

            var raceOrder = horses.ToList<Horse>();
            raceOrder.Sort();
            raceOrder.Reverse();

            winner = horses.IndexOf(raceOrder[0]);
        }

        public int Winner
        {
            get
            {
                return winner;
            }
        }
    }
}
