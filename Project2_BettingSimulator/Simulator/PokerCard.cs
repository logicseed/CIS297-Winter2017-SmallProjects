// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;

namespace Simulator
{
    public class PokerCard : IComparable<PokerCard>, IEquatable<PokerCard>
    {
        public int Value { get; set; }
        public CardSuit Suit { get; set; }

        public PokerCard(int value, CardSuit suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        public int CompareTo(PokerCard other)
        {
            if (other == null) return 1;

            var result = 0;

            // Order by value
            if (Value > other.Value)
            {
                result = 1;
            }
            else if (Value < other.Value)
            {
                result = -1;
            }

            // Order by suit
            if ((int)Suit > (int)other.Suit)
            {
                result = 1;
            }
            else if ((int)Suit < (int)other.Suit)
            {
                result = -1;
            }

            return result;
        }

        public bool Equals(PokerCard other)
        {
            if (other == null) return false;

            return this.Suit == other.Suit && this.Value == other.Value;
        }
    }
}
