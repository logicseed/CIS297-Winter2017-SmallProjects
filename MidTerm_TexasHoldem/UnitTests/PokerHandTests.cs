using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TexasHoldem;

namespace UnitTests
{
    [TestClass]
    public class PokerHandTests
    {
        [TestMethod]
        public void TestStraightFlush()
        {
            var hand = new PokerHand();
            hand.Add(new Card(CardSuit.Clubs, CardFace.Jack));
            hand.Add(new Card(CardSuit.Clubs, CardFace.Ten));
            hand.Add(new Card(CardSuit.Clubs, CardFace.Nine));
            hand.Add(new Card(CardSuit.Clubs, CardFace.Eight));
            hand.Add(new Card(CardSuit.Clubs, CardFace.Seven));

            Assert.AreEqual(hand.Rank, PokerHandRank.StraightFlush);

            var hand2 = new PokerHand();
            hand2.Add(new Card(CardSuit.Clubs, CardFace.Queen));
            hand2.Add(new Card(CardSuit.Clubs, CardFace.Jack));
            hand2.Add(new Card(CardSuit.Clubs, CardFace.Ten));
            hand2.Add(new Card(CardSuit.Clubs, CardFace.Nine));
            hand2.Add(new Card(CardSuit.Clubs, CardFace.Eight));

            Assert.AreEqual(hand.CompareTo(hand2), -1);
        }

        [TestMethod]
        public void TestFourOfAKind()
        {
            var hand = new PokerHand();
            hand.Add(new Card(CardSuit.Clubs, CardFace.Five));
            hand.Add(new Card(CardSuit.Diamonds, CardFace.Five));
            hand.Add(new Card(CardSuit.Hearts, CardFace.Five));
            hand.Add(new Card(CardSuit.Spades, CardFace.Five));
            hand.Add(new Card(CardSuit.Clubs, CardFace.Seven));

            Assert.AreEqual(hand.Rank, PokerHandRank.FourOfAKind);
        }

        [TestMethod]
        public void TestFullHouse()
        {
            var hand = new PokerHand();
            hand.Add(new Card(CardSuit.Clubs, CardFace.Five));
            hand.Add(new Card(CardSuit.Diamonds, CardFace.Five));
            hand.Add(new Card(CardSuit.Hearts, CardFace.Five));
            hand.Add(new Card(CardSuit.Spades, CardFace.Seven));
            hand.Add(new Card(CardSuit.Clubs, CardFace.Seven));

            Assert.AreEqual(hand.Rank, PokerHandRank.FullHouse);
        }

        [TestMethod]
        public void TestFlush()
        {
            var hand = new PokerHand();
            hand.Add(new Card(CardSuit.Clubs, CardFace.Jack));
            hand.Add(new Card(CardSuit.Clubs, CardFace.Ten));
            hand.Add(new Card(CardSuit.Clubs, CardFace.Nine));
            hand.Add(new Card(CardSuit.Clubs, CardFace.Six));
            hand.Add(new Card(CardSuit.Clubs, CardFace.Five));

            Assert.AreEqual(hand.Rank, PokerHandRank.Flush);
        }

        [TestMethod]
        public void TestStraight()
        {
            var hand = new PokerHand();
            hand.Add(new Card(CardSuit.Diamonds, CardFace.Jack));
            hand.Add(new Card(CardSuit.Spades, CardFace.Ten));
            hand.Add(new Card(CardSuit.Hearts, CardFace.Nine));
            hand.Add(new Card(CardSuit.Diamonds, CardFace.Eight));
            hand.Add(new Card(CardSuit.Clubs, CardFace.Seven));

            Assert.AreEqual(hand.Rank, PokerHandRank.Straight);
        }

        [TestMethod]
        public void TestThreeOfAKind()
        {
            var hand = new PokerHand();
            hand.Add(new Card(CardSuit.Clubs, CardFace.Queen));
            hand.Add(new Card(CardSuit.Spades, CardFace.Queen));
            hand.Add(new Card(CardSuit.Hearts, CardFace.Queen));
            hand.Add(new Card(CardSuit.Hearts, CardFace.Nine));
            hand.Add(new Card(CardSuit.Spades, CardFace.Two));

            Assert.AreEqual(hand.Rank, PokerHandRank.ThreeOfAKind);
        }

        [TestMethod]
        public void TestTwoPair()
        {
            var hand = new PokerHand();
            hand.Add(new Card(CardSuit.Hearts, CardFace.Jack));
            hand.Add(new Card(CardSuit.Spades, CardFace.Jack));
            hand.Add(new Card(CardSuit.Clubs, CardFace.Three));
            hand.Add(new Card(CardSuit.Spades, CardFace.Four));
            hand.Add(new Card(CardSuit.Hearts, CardFace.Two));

            Assert.AreNotEqual(hand.Rank, PokerHandRank.TwoPair);

            var hand2 = new PokerHand();
            hand2.Add(new Card(CardSuit.Hearts, CardFace.Jack));
            hand2.Add(new Card(CardSuit.Spades, CardFace.Jack));
            hand2.Add(new Card(CardSuit.Clubs, CardFace.Four));
            hand2.Add(new Card(CardSuit.Spades, CardFace.Four));
            hand2.Add(new Card(CardSuit.Hearts, CardFace.Two));

            Assert.AreEqual(hand2.Rank, PokerHandRank.TwoPair);
        }

        [TestMethod]
        public void TestOnePair()
        {
            var hand = new PokerHand();
            hand.Add(new Card(CardSuit.Spades, CardFace.Ten));
            hand.Add(new Card(CardSuit.Hearts, CardFace.Ten));
            hand.Add(new Card(CardSuit.Spades, CardFace.Eight));
            hand.Add(new Card(CardSuit.Hearts, CardFace.Seven));
            hand.Add(new Card(CardSuit.Clubs, CardFace.Four));

            Assert.AreEqual(hand.Rank, PokerHandRank.OnePair);
        }

        [TestMethod]
        public void TestHighCard()
        {
            var hand = new PokerHand();
            hand.Add(new Card(CardSuit.Diamonds, CardFace.King));
            hand.Add(new Card(CardSuit.Diamonds, CardFace.Queen));
            hand.Add(new Card(CardSuit.Spades, CardFace.Seven));
            hand.Add(new Card(CardSuit.Spades, CardFace.Four));
            hand.Add(new Card(CardSuit.Hearts, CardFace.Three));

            Assert.AreEqual(hand.Rank, PokerHandRank.HighCard);
        }
    }
}
