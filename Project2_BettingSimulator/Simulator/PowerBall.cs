// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    class PowerBall : IComparable<PowerBall>
    {
        private const int COUNT_WHITE = 5;
        private const int NUM_WHITE = 69;
        private const int NUM_RED = 26;

        private List<int> whiteBalls = new List<int>();
        private int redBall;
        private Random random = new Random();

        public PowerBall()
        {
            for (int i = 0; i < COUNT_WHITE; i++)
            {
                int ball;
                var accept = false;
                do
                {
                    ball = random.Next(1, NUM_WHITE + 1);
                    if (!whiteBalls.Contains(ball))
                    {
                        whiteBalls.Add(ball);
                        accept = true;
                    }
                } while (!accept);
            }
            whiteBalls.Sort();

            redBall = random.Next(1, NUM_RED + 1);
        }

        public PowerBall(int white1, int white2, int white3, int white4, int white5, int red)
        {
            whiteBalls.Add(white1);
            whiteBalls.Add(white2);
            whiteBalls.Add(white3);
            whiteBalls.Add(white4);
            whiteBalls.Add(white5);
            redBall = red;
        }

        public int CompareTo(PowerBall other)
        {
            var matches = true;

            for (int i = 0; i < whiteBalls.Count; i++)
            {
                if (this.whiteBalls[i] != other.whiteBalls[i]) matches = false;
            }

            if (this.redBall != other.redBall) matches = false;

            if (matches == true) return 0;
            return -1;
        }
    }
}
