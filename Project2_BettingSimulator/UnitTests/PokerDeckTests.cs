// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Simulator;

namespace UnitTests
{
    [TestClass]
    public class PokerDeckTests
    {
        [TestMethod]
        public void TestNoNullCards()
        {
            var deck = new PokerDeck();
            var cards = new List<PokerCard>();

            for (int count = 0; count < 52; count++)
            {
                cards.Add(deck.NextCard());
            }

            for (int i = 0; i < 52; i++)
            {
                Assert.IsNotNull(cards[i]);
            }
        }

        [TestMethod]
        public void TestContainsCards()
        {
            var deck = new PokerDeck();
            var cards = new List<PokerCard>();

            for (int count = 0; count < 52; count++)
            {
                cards.Add(deck.NextCard());
            }

            for (int i = 0; i < 52; i++)
            {
                Assert.IsInstanceOfType(cards[i], typeof(PokerCard));
            }
        }

        [TestMethod]
        public void TestNoDuplicateCards()
        {
            var deck = new PokerDeck();
            var cards = new List<PokerCard>();

            for (int count = 0; count < 52; count++)
            {
                cards.Add(deck.NextCard());
            }

            for (int i = 0; i < cards.Count; i++)
            {
                for (int j = 0; j < cards.Count; j++)
                {
                    if (i == j) continue;

                    Assert.IsFalse(cards[i].Equals(cards[j]));
                }
            }
        }


    }
}
