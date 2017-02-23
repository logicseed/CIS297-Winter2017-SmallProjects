// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;
using System.Collections.Generic;

namespace Simulator
{
    class PokerHand : IComparable<PokerHand>
    {
        public const int HAND_SIZE = 5;

        private List<PokerCard> cards;
        private PokerHandRank rank = PokerHandRank.Invalid;

        public PokerHand()
        {
            cards = new List<PokerCard>(HAND_SIZE);
        }

        public void Add(PokerCard card)
        {
            if (card != null && cards.Count < HAND_SIZE)
            {
                cards.Add(card);
                cards.Sort();
            }
        }

        public PokerHandRank Rank
        {
            get
            {
                if (rank == PokerHandRank.Invalid) rank = CalculatePokerHandRank();
                return rank;
            }
        }

        public int GetHighestValue()
        {
            var highest = 0;
            foreach (var card in cards)
            {
                if (card.Value > highest) highest = card.Value;
            }
            return highest;
        }

        public PokerHandRank CalculatePokerHandRank()
        {
            if (IsStraightFlush()) return PokerHandRank.StraightFlush;

            if (IsFourOfAKind()) return PokerHandRank.FourOfAKind;

            if (IsFullHouse()) return PokerHandRank.FullHouse;

            if (IsFlush()) return PokerHandRank.Flush;

            if (IsStraight()) return PokerHandRank.Straight;

            if (IsThreeOfAKind()) return PokerHandRank.ThreeOfAKind;

            if (IsTwoPair()) return PokerHandRank.TwoPair;

            if (IsOnePair()) return PokerHandRank.OnePair;

            // High Card
            return PokerHandRank.HighCard;
        }

        public bool AreSequential()
        {
            // Check ace low sequential
            if (cards[1].Value == cards[0].Value + 1 &&
                cards[2].Value == cards[1].Value + 1 &&
                cards[3].Value == cards[2].Value + 1 &&
                cards[4].Value == cards[3].Value + 1) return true;

            // Check ace high sequential
            if (HasAce())
            {
                if (cards[2].Value == cards[1].Value + 1 &&
                    cards[3].Value == cards[2].Value + 1 &&
                    cards[4].Value == cards[3].Value + 1 &&
                    cards[4].Value == 13) return true;
            }
            return false;
        }

        public bool HasAce()
        {
            foreach (var card in cards)
            {
                if (card.Value == 1) return true;
            }
            return false;
        }

        public bool AreSameSuit()
        {
            var suit = cards[0].Suit;
            foreach (var card in cards)
            {
                if (card.Suit != suit) return false;
            }
            return true;
        }
        public bool IsStraightFlush()
        {
            if (!AreSameSuit()) return false;
            return AreSequential();
        }


        public bool IsFourOfAKind()
        {
            return HasMultipleOfAKind(4);
        }

        public bool HasMultipleOfAKind(int multiple)
        {
            if (multiple > HAND_SIZE || multiple <= 0) return false;

            for (int i = 0; i < HAND_SIZE; i++)
            {
                var count = 0;
                var value = cards[i].Value;

                for (int j = 0; j < HAND_SIZE; j++)
                {
                    if (cards[i].Value == cards[j].Value) count++;
                }

                if (count == multiple) return true;
            }
            return false;
        }

        public bool IsFullHouse()
        {
            var value1 = 0;
            var count1 = 0;
            var value2 = 0;
            var count2 = 0;

            foreach (var card in cards)
            {
                if (card.Value == value1)
                {
                    count1++;
                    continue;
                }
                
                if (card.Value == value2)
                {
                    count2++;
                    continue;
                }

                if (value1 == 0)
                {
                    value1 = card.Value;
                    count1++;
                    continue;
                }

                if (value2 == 0)
                {
                    value2 = card.Value;
                    count2++;
                    continue;
                }

                return false;
            }

            return ((count1 == 2 && count2 == 3) || (count1 == 3 && count2 == 2));
        }

        public bool IsFlush()
        {
            return AreSameSuit();
        }

        public bool IsStraight()
        {
            return AreSequential();
        }

        public bool IsThreeOfAKind()
        {
            return HasMultipleOfAKind(3);
        }

        public bool IsTwoPair()
        {
            var value1 = 0;
            var value2 = 0;

            for (int i = 0; i < HAND_SIZE; i++)
            {
                for(int j = 0; j < HAND_SIZE; j++)
                {
                    if (i == j) continue;

                    if (cards[i].Value == cards[j].Value)
                    {
                        if (value1 == cards[i].Value || value2 == cards[i].Value) continue;

                        if (value1 == 0)
                        {
                            value1 = cards[i].Value;
                        }

                        if (value2 == 0)
                        {
                            value2 = cards[i].Value;
                        }
                    }

                }
            }

            return (value1 > 0 && value2 > 0);
        }

        public bool IsOnePair()
        {
            for (int i = 0; i < HAND_SIZE; i++)
            {
                for (int j = 0; j < HAND_SIZE; j++)
                {
                    if (i == j) continue;

                    if (cards[i].Value == cards[j].Value) return true;
                }
            }
            return false;
        }

        public int CompareTo(PokerHand other)
        {
            // Check hand rank
            if (this.Rank > other.Rank) return 1;
            if (this.Rank < other.Rank) return -1;

            // Check sub ranks
            switch (this.Rank)
            {
                case PokerHandRank.StraightFlush:
                    if (this.GetHighestValue() > other.GetHighestValue()) return 1;
                    if (this.GetHighestValue() < other.GetHighestValue()) return -1;
                    break;
                case PokerHandRank.FourOfAKind:
                    if (this.GetValueOfMultiple(4) > other.GetValueOfMultiple(4)) return 1;
                    if (this.GetValueOfMultiple(4) < other.GetValueOfMultiple(4)) return -1;
                    if (this.GetValueOfMultiple(1) > other.GetValueOfMultiple(1)) return 1;
                    if (this.GetValueOfMultiple(1) < other.GetValueOfMultiple(1)) return -1;
                    break;
                case PokerHandRank.FullHouse:
                    if (this.GetValueOfMultiple(3) > other.GetValueOfMultiple(3)) return 1;
                    if (this.GetValueOfMultiple(3) < other.GetValueOfMultiple(3)) return -1;
                    if (this.GetValueOfMultiple(2) > other.GetValueOfMultiple(2)) return 1;
                    if (this.GetValueOfMultiple(2) < other.GetValueOfMultiple(2)) return -1;
                    break;
                case PokerHandRank.Flush:
                    var thisList = this.GetSortedListOfCardValues();
                    var otherList = other.GetSortedListOfCardValues();
                    for (int i = 0; i < thisList.Count; i++)
                    {
                        if (thisList[i] > otherList[i]) return 1;
                        if (thisList[i] < otherList[i]) return -1;
                    }
                    break;
                case PokerHandRank.Straight:
                    if (this.HasAce() && !other.HasAce()) return 1;
                    if (!this.HasAce() && other.HasAce()) return -1;
                    if (this.GetHighestValue() > other.GetHighestValue()) return 1;
                    if (this.GetHighestValue() < other.GetHighestValue()) return -1;
                    break;
                case PokerHandRank.ThreeOfAKind:
                    var thisRanks = this.GetThreeOfAKindRanks();
                    var otherRanks = other.GetThreeOfAKindRanks();
                    for (int i = 0; i < thisRanks.Count; i++)
                    {
                        if (thisRanks[i] > otherRanks[i]) return 1;
                        if (thisRanks[i] < otherRanks[i]) return -1;
                    }
                    break;
                case PokerHandRank.TwoPair:
                    var thisTwoPairRanks = this.GetTwoPairRanks();
                    var otherTwoPairRanks = other.GetTwoPairRanks();
                    for (int i = 0; i < thisTwoPairRanks.Count; i++)
                    {
                        if (thisTwoPairRanks[i] > otherTwoPairRanks[i]) return 1;
                        if (thisTwoPairRanks[i] < otherTwoPairRanks[i]) return -1;
                    }
                    break;
                case PokerHandRank.OnePair:
                    var thisOnePairRanks = this.GetOnePairRanks();
                    var otherOnePairRanks = other.GetOnePairRanks();
                    for (int i = 0; i < thisOnePairRanks.Count; i++)
                    {
                        if (thisOnePairRanks[i] > otherOnePairRanks[i]) return 1;
                        if (thisOnePairRanks[i] < otherOnePairRanks[i]) return -1;
                    }
                    break;
                case PokerHandRank.HighCard:
                    if (this.HasAce() && !other.HasAce()) return 1;
                    if (!this.HasAce() && other.HasAce()) return -1;

                    var thisHighCardRanks = this.GetSortedListOfCardValues();
                    var otherHighCardRanks = other.GetSortedListOfCardValues();
                    for (int i = 0; i < thisHighCardRanks.Count; i++)
                    {
                        if (thisHighCardRanks[i] > otherHighCardRanks[i]) return 1;
                        if (thisHighCardRanks[i] < otherHighCardRanks[i]) return -1;
                    }
                    break;
            }

            return 0;
        }

        public int GetValueOfMultiple(int multiple)
        {
            for (int i = 0; i < HAND_SIZE; i++)
            {
                var count = 0;
                var value = cards[i].Value;

                for (int j = 0; j < HAND_SIZE; j++)
                {
                    if (cards[i].Value == cards[j].Value) count++;
                }

                if (count == multiple) return value;
            }
            return 0;
        }

        public List<int> GetSortedListOfCardValues()
        {
            var values = new List<int>();

            foreach (var card in cards)
            {
                values.Add(card.Value);
            }

            values.Sort();
            values.Reverse();

            return values;
        }
        
        public List<int> GetThreeOfAKindRanks()
        {
            var ranks = new List<int>();

            ranks.Add(GetValueOfMultiple(3));

            var list = GetSortedListOfCardValues();
            list.Reverse();

            for (int i = 4; i >= 0; i--)
            {
                if (list[i] != ranks[0]) ranks.Add(i);
            }

            return ranks;
        }

        public List<int> GetTwoPairRanks()
        {
            var ranks = new List<int>();

            var value1 = 0;
            var value2 = 0;
            var kicker = 0;

            for (int i = 0; i < HAND_SIZE; i++)
            {
                for (int j = 0; j < HAND_SIZE; j++)
                {
                    if (i == j) continue;

                    if (cards[i].Value == cards[j].Value)
                    {
                        if (value1 == cards[i].Value || value2 == cards[i].Value) continue;

                        if (value1 == 0)
                        {
                            value1 = cards[i].Value;
                        }

                        if (value2 == 0)
                        {
                            value2 = cards[i].Value;
                        }
                    }
                }
            }

            foreach (var card in cards)
            {
                if (card.Value != value1 && card.Value != value2) kicker = card.Value;
            }

            ranks.Add(value1);
            ranks.Add(value2);
            ranks.Sort();
            if (ranks[0] != 1) ranks.Reverse();
            ranks.Add(kicker);
            return ranks;
        }

        public List<int> GetOnePairRanks()
        {
            var pair = GetValueOfMultiple(2);
            var ranks = new List<int>();

            foreach (var card in cards)
            {
                if (card.Value != pair) ranks.Add(card.Value);
            }

            ranks.Sort();
            ranks.Reverse();

            if (ranks[ranks.Count - 1] == 1)
            {
                ranks.RemoveAt(ranks.Count - 1);
                ranks.Insert(0, 1);
            }

            ranks.Insert(0, pair);
            return ranks;
        }
    }
}
