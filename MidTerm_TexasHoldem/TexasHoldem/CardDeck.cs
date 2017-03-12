// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;
using System.Collections.Generic;

namespace TexasHoldem
{
    /// <summary>
    /// Represents a deck of playing cards.
    /// </summary>
    public class CardDeck
    {
        private List<Card> cards;
        private Random random;

        public CardDeck()
        {
            cards = new List<Card>();
            random = new Random();

            // Fill the deck with all the cards.
            for (int suit = 1; suit <= (int)CardSuit.TotalSuits; suit++)
            {
                for (int face = 1; face <= (int)CardFace.TotalFaces; face++)
                {
                    var card = new Card((CardSuit)suit, (CardFace)face);
                    cards.Add(card);
                }
            }
        }

        public List<Card> Cards
        {
            get
            {
                return cards;
            }
        }

        /// <summary>
        /// Takes a card from the deck.
        /// </summary>
        /// <returns>The card taken from the deck.</returns>
        public Card TakeCard()
        {
            var index = random.Next(0, cards.Count);
            var card = cards[index];
            cards.RemoveAt(index);
            cards.TrimExcess();
            return card;
        }
    }
}
