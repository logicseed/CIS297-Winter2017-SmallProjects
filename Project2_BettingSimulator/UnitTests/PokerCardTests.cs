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
    public class PokerCardTests
    {
        [TestMethod]
        public void TestSuitSorting()
        {
            var cards = new List<PokerCard>();
            cards.Add(new PokerCard(1, CardSuit.Spades));
            cards.Add(new PokerCard(1, CardSuit.Hearts));
            cards.Add(new PokerCard(1, CardSuit.Diamonds));
            cards.Add(new PokerCard(1, CardSuit.Clubs));
            cards.Sort();

            Assert.AreEqual(cards[0].Suit, CardSuit.Clubs);
            Assert.AreEqual(cards[1].Suit, CardSuit.Diamonds);
            Assert.AreEqual(cards[2].Suit, CardSuit.Hearts);
            Assert.AreEqual(cards[3].Suit, CardSuit.Spades);
        }

        [TestMethod]
        public void TestValueSorting()
        {
            var cards = new List<PokerCard>();
            cards.Add(new PokerCard(9, CardSuit.Clubs));
            cards.Add(new PokerCard(8, CardSuit.Clubs));
            cards.Add(new PokerCard(7, CardSuit.Clubs));
            cards.Add(new PokerCard(6, CardSuit.Clubs));
            cards.Add(new PokerCard(5, CardSuit.Clubs));
            cards.Add(new PokerCard(13, CardSuit.Clubs));
            cards.Add(new PokerCard(12, CardSuit.Clubs));
            cards.Add(new PokerCard(11, CardSuit.Clubs));
            cards.Add(new PokerCard(10, CardSuit.Clubs));
            cards.Add(new PokerCard(4, CardSuit.Clubs));
            cards.Add(new PokerCard(3, CardSuit.Clubs));
            cards.Add(new PokerCard(2, CardSuit.Clubs));
            cards.Add(new PokerCard(1, CardSuit.Clubs));
            cards.Sort();

            Assert.AreEqual(cards[0].Value, 1);
            Assert.AreEqual(cards[1].Value, 2);
            Assert.AreEqual(cards[2].Value, 3);
            Assert.AreEqual(cards[3].Value, 4);
            Assert.AreEqual(cards[4].Value, 5);
            Assert.AreEqual(cards[5].Value, 6);
            Assert.AreEqual(cards[6].Value, 7);
            Assert.AreEqual(cards[7].Value, 8);
            Assert.AreEqual(cards[8].Value, 9);
            Assert.AreEqual(cards[9].Value, 10);
            Assert.AreEqual(cards[10].Value, 11);
            Assert.AreEqual(cards[11].Value, 12);
            Assert.AreEqual(cards[12].Value, 13);
        }
    }
}
