// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;
using System.Collections.Generic;

namespace Simulator
{
    class PokerDeck
    {
        const int TOTAL_VALUES = 13;

        private List<PokerCard> cards;
        private Random random;

        public PokerDeck()
        {
            cards = new List<PokerCard>();
            random = new Random();

            for (int index = 0; index < TOTAL_VALUES; index++)
            {
                foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
                {
                    var card = new PokerCard(index, suit);
                    cards.Add(card);
                }
            }
        }

        public PokerCard NextCard()
        {
            cards.TrimExcess();
            var index = random.Next(0, cards.Count);
            var card = cards[index];
            cards.RemoveAt(index);
            return card;
        }
    }
}
