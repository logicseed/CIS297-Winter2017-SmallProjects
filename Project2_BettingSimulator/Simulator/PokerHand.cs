// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;
using System.Collections.Generic;

namespace Simulator
{
    class PokerHand : IComparable<PokerHand>
    {
        private const int HAND_SIZE = 5;

        private List<PokerCard> cards;

        public PokerHand()
        {
            cards = new List<PokerCard>(HAND_SIZE);
        }

        public void Add(PokerCard card)
        {
            if (cards.Count < HAND_SIZE)
            {

            }
        }

        public int CompareTo(PokerHand other)
        {
            throw new NotImplementedException();
        }
    }
}
