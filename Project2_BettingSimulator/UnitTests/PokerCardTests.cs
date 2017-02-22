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
            cards.Add(new PokerCard(9,  CardSuit.Clubs));
            cards.Add(new PokerCard(8,  CardSuit.Clubs));
            cards.Add(new PokerCard(7,  CardSuit.Clubs));
            cards.Add(new PokerCard(6,  CardSuit.Clubs));
            cards.Add(new PokerCard(5,  CardSuit.Clubs));
            cards.Add(new PokerCard(13, CardSuit.Clubs));
            cards.Add(new PokerCard(12, CardSuit.Clubs));
            cards.Add(new PokerCard(11, CardSuit.Clubs));
            cards.Add(new PokerCard(10, CardSuit.Clubs));
            cards.Add(new PokerCard(4,  CardSuit.Clubs));
            cards.Add(new PokerCard(3,  CardSuit.Clubs));
            cards.Add(new PokerCard(2,  CardSuit.Clubs));
            cards.Add(new PokerCard(1,  CardSuit.Clubs));
            cards.Sort();

            Assert.AreEqual(cards[0].Value,  1);
            Assert.AreEqual(cards[1].Value,  2);
            Assert.AreEqual(cards[2].Value,  3);
            Assert.AreEqual(cards[3].Value,  4);
            Assert.AreEqual(cards[4].Value,  5);
            Assert.AreEqual(cards[5].Value,  6);
            Assert.AreEqual(cards[6].Value,  7);
            Assert.AreEqual(cards[7].Value,  8);
            Assert.AreEqual(cards[8].Value,  9);
            Assert.AreEqual(cards[9].Value,  10);
            Assert.AreEqual(cards[10].Value, 11);
            Assert.AreEqual(cards[11].Value, 12);
            Assert.AreEqual(cards[12].Value, 13);
        }

        [TestMethod]
        public void TestValueAndSuitSorting()
        {
            var cards = new List<PokerCard>();
            cards.Add(new PokerCard(9, CardSuit.Hearts));
            cards.Add(new PokerCard(8, CardSuit.Hearts));
            cards.Add(new PokerCard(7, CardSuit.Hearts));
            cards.Add(new PokerCard(6, CardSuit.Hearts));
            cards.Add(new PokerCard(5, CardSuit.Hearts));
            cards.Add(new PokerCard(13, CardSuit.Hearts));
            cards.Add(new PokerCard(12, CardSuit.Hearts));
            cards.Add(new PokerCard(11, CardSuit.Hearts));
            cards.Add(new PokerCard(10, CardSuit.Hearts));
            cards.Add(new PokerCard(4, CardSuit.Hearts));
            cards.Add(new PokerCard(3, CardSuit.Hearts));
            cards.Add(new PokerCard(2, CardSuit.Hearts));
            cards.Add(new PokerCard(1, CardSuit.Hearts));
            cards.Add(new PokerCard(9, CardSuit.Spades));
            cards.Add(new PokerCard(8, CardSuit.Spades));
            cards.Add(new PokerCard(7, CardSuit.Spades));
            cards.Add(new PokerCard(6, CardSuit.Spades));
            cards.Add(new PokerCard(5, CardSuit.Spades));
            cards.Add(new PokerCard(13, CardSuit.Spades));
            cards.Add(new PokerCard(12, CardSuit.Spades));
            cards.Add(new PokerCard(11, CardSuit.Spades));
            cards.Add(new PokerCard(10, CardSuit.Spades));
            cards.Add(new PokerCard(4, CardSuit.Spades));
            cards.Add(new PokerCard(3, CardSuit.Spades));
            cards.Add(new PokerCard(2, CardSuit.Spades));
            cards.Add(new PokerCard(1, CardSuit.Spades));
            cards.Add(new PokerCard(9, CardSuit.Diamonds));
            cards.Add(new PokerCard(8, CardSuit.Diamonds));
            cards.Add(new PokerCard(7, CardSuit.Diamonds));
            cards.Add(new PokerCard(6, CardSuit.Diamonds));
            cards.Add(new PokerCard(5, CardSuit.Diamonds));
            cards.Add(new PokerCard(13, CardSuit.Diamonds));
            cards.Add(new PokerCard(12, CardSuit.Diamonds));
            cards.Add(new PokerCard(11, CardSuit.Diamonds));
            cards.Add(new PokerCard(10, CardSuit.Diamonds));
            cards.Add(new PokerCard(4, CardSuit.Diamonds));
            cards.Add(new PokerCard(3, CardSuit.Diamonds));
            cards.Add(new PokerCard(2, CardSuit.Diamonds));
            cards.Add(new PokerCard(1, CardSuit.Diamonds));
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
            Assert.AreEqual(cards[0].Suit, CardSuit.Clubs);
            Assert.AreEqual(cards[1].Value, 2);
            Assert.AreEqual(cards[1].Suit, CardSuit.Clubs);
            Assert.AreEqual(cards[2].Value, 3);
            Assert.AreEqual(cards[2].Suit, CardSuit.Clubs);
            Assert.AreEqual(cards[3].Value, 4);
            Assert.AreEqual(cards[3].Suit, CardSuit.Clubs);
            Assert.AreEqual(cards[4].Value, 5);
            Assert.AreEqual(cards[4].Suit, CardSuit.Clubs);
            Assert.AreEqual(cards[5].Value, 6);
            Assert.AreEqual(cards[5].Suit, CardSuit.Clubs);
            Assert.AreEqual(cards[6].Value, 7);
            Assert.AreEqual(cards[6].Suit, CardSuit.Clubs);
            Assert.AreEqual(cards[7].Value, 8);
            Assert.AreEqual(cards[7].Suit, CardSuit.Clubs);
            Assert.AreEqual(cards[8].Value, 9);
            Assert.AreEqual(cards[8].Suit, CardSuit.Clubs);
            Assert.AreEqual(cards[9].Value, 10);
            Assert.AreEqual(cards[9].Suit, CardSuit.Clubs);
            Assert.AreEqual(cards[10].Value, 11);
            Assert.AreEqual(cards[10].Suit, CardSuit.Clubs);
            Assert.AreEqual(cards[11].Value, 12);
            Assert.AreEqual(cards[11].Suit, CardSuit.Clubs);
            Assert.AreEqual(cards[12].Value, 13);
            Assert.AreEqual(cards[12].Suit, CardSuit.Clubs);
            Assert.AreEqual(cards[13].Value, 1);
            Assert.AreEqual(cards[13].Suit, CardSuit.Diamonds);
            Assert.AreEqual(cards[14].Value, 2);
            Assert.AreEqual(cards[14].Suit, CardSuit.Diamonds);
            Assert.AreEqual(cards[15].Value, 3);
            Assert.AreEqual(cards[15].Suit, CardSuit.Diamonds);
            Assert.AreEqual(cards[16].Value, 4);
            Assert.AreEqual(cards[16].Suit, CardSuit.Diamonds);
            Assert.AreEqual(cards[17].Value, 5);
            Assert.AreEqual(cards[17].Suit, CardSuit.Diamonds);
            Assert.AreEqual(cards[18].Value, 6);
            Assert.AreEqual(cards[18].Suit, CardSuit.Diamonds);
            Assert.AreEqual(cards[19].Value, 7);
            Assert.AreEqual(cards[19].Suit, CardSuit.Diamonds);
            Assert.AreEqual(cards[20].Value, 8);
            Assert.AreEqual(cards[20].Suit, CardSuit.Diamonds);
            Assert.AreEqual(cards[21].Value, 9);
            Assert.AreEqual(cards[21].Suit, CardSuit.Diamonds);
            Assert.AreEqual(cards[22].Value, 10);
            Assert.AreEqual(cards[22].Suit, CardSuit.Diamonds);
            Assert.AreEqual(cards[23].Value, 11);
            Assert.AreEqual(cards[23].Suit, CardSuit.Diamonds);
            Assert.AreEqual(cards[24].Value, 12);
            Assert.AreEqual(cards[24].Suit, CardSuit.Diamonds);
            Assert.AreEqual(cards[25].Value, 13);
            Assert.AreEqual(cards[25].Suit, CardSuit.Diamonds);
            Assert.AreEqual(cards[26].Value, 1);
            Assert.AreEqual(cards[26].Suit, CardSuit.Hearts);
            Assert.AreEqual(cards[27].Value, 2);
            Assert.AreEqual(cards[27].Suit, CardSuit.Hearts);
            Assert.AreEqual(cards[28].Value, 3);
            Assert.AreEqual(cards[28].Suit, CardSuit.Hearts);
            Assert.AreEqual(cards[29].Value, 4);
            Assert.AreEqual(cards[29].Suit, CardSuit.Hearts);
            Assert.AreEqual(cards[30].Value, 5);
            Assert.AreEqual(cards[30].Suit, CardSuit.Hearts);
            Assert.AreEqual(cards[31].Value, 6);
            Assert.AreEqual(cards[31].Suit, CardSuit.Hearts);
            Assert.AreEqual(cards[32].Value, 7);
            Assert.AreEqual(cards[32].Suit, CardSuit.Hearts);
            Assert.AreEqual(cards[33].Value, 8);
            Assert.AreEqual(cards[33].Suit, CardSuit.Hearts);
            Assert.AreEqual(cards[34].Value, 9);
            Assert.AreEqual(cards[34].Suit, CardSuit.Hearts);
            Assert.AreEqual(cards[35].Value, 10);
            Assert.AreEqual(cards[35].Suit, CardSuit.Hearts);
            Assert.AreEqual(cards[36].Value, 11);
            Assert.AreEqual(cards[36].Suit, CardSuit.Hearts);
            Assert.AreEqual(cards[37].Value, 12);
            Assert.AreEqual(cards[37].Suit, CardSuit.Hearts);
            Assert.AreEqual(cards[38].Value, 13);
            Assert.AreEqual(cards[38].Suit, CardSuit.Hearts);
            Assert.AreEqual(cards[39].Value, 1);
            Assert.AreEqual(cards[39].Suit, CardSuit.Spades);
            Assert.AreEqual(cards[40].Value, 2);
            Assert.AreEqual(cards[40].Suit, CardSuit.Spades);
            Assert.AreEqual(cards[41].Value, 3);
            Assert.AreEqual(cards[41].Suit, CardSuit.Spades);
            Assert.AreEqual(cards[42].Value, 4);
            Assert.AreEqual(cards[42].Suit, CardSuit.Spades);
            Assert.AreEqual(cards[43].Value, 5);
            Assert.AreEqual(cards[43].Suit, CardSuit.Spades);
            Assert.AreEqual(cards[44].Value, 6);
            Assert.AreEqual(cards[44].Suit, CardSuit.Spades);
            Assert.AreEqual(cards[45].Value, 7);
            Assert.AreEqual(cards[45].Suit, CardSuit.Spades);
            Assert.AreEqual(cards[46].Value, 8);
            Assert.AreEqual(cards[46].Suit, CardSuit.Spades);
            Assert.AreEqual(cards[47].Value, 9);
            Assert.AreEqual(cards[47].Suit, CardSuit.Spades);
            Assert.AreEqual(cards[48].Value, 10);
            Assert.AreEqual(cards[48].Suit, CardSuit.Spades);
            Assert.AreEqual(cards[49].Value, 11);
            Assert.AreEqual(cards[49].Suit, CardSuit.Spades);
            Assert.AreEqual(cards[50].Value, 12);
            Assert.AreEqual(cards[50].Suit, CardSuit.Spades);
            Assert.AreEqual(cards[51].Value, 13);
            Assert.AreEqual(cards[51].Suit, CardSuit.Spades);
        }
    }
}
