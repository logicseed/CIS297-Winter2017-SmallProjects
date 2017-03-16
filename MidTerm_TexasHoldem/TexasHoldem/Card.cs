// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;

namespace TexasHoldem
{
    /// <summary>
    /// Represents a playing card.
    /// </summary>
    public class Card : IComparable<Card>, IEquatable<Card>
    {
        public CardFace Face { get; set; }
        public CardSuit Suit { get; set; }

        public Card(CardSuit suit, CardFace face)
        {
            this.Suit = suit;
            this.Face = face;
        }

        public int CompareTo(Card other)
        {
            if (other == null) return 1;

            var result = 0;

            // Order by value
            if (Face > other.Face)
            {
                result = 1;
            }
            else if (Face < other.Face)
            {
                result = -1;
            }

            //// Order by suit
            //if (Suit > other.Suit)
            //{
            //    result = 1;
            //}
            //else if (Suit < other.Suit)
            //{
            //    result = -1;
            //}

            return result;
        }

        public bool Equals(Card other)
        {
            if (other == null) return false;

            return this.Suit == other.Suit && this.Face == other.Face;
        }
    }
}
