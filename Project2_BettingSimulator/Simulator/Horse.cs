// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;

namespace Simulator
{
    public class Horse : IComparable<Horse>
    {
        private double speed;

        public Horse()
        {
            var random = new Random();
            speed = random.NextDouble();
        }

        public Horse(double speed)
        {
            this.speed = speed;
        }

        public int CompareTo(Horse other)
        {
            if (this.speed > other.speed) return 1;
            if (this.speed < other.speed) return -1;
            return 0;
        }
    }
}
