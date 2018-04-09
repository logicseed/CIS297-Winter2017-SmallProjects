// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;
using System.Collections.Generic;

namespace TexasHoldem
{
    public class PokerHand : IComparable<PokerHand>
    {
        public const int HAND_SIZE = 5;

        private List<Card> cards;
        private PokerHandRank rank = PokerHandRank.Invalid;

        public PokerHand()
        {
            cards = new List<Card>(HAND_SIZE);
        }

        public void Add(Card card)
        {
            if (card != null && cards.Count < HAND_SIZE)
            {
                cards.Add(card);
                cards.Sort();
            }
        }

        public void Add(PokerHand hand)
        {
            if (cards.Count + hand.Cards.Count <= HAND_SIZE)
            {
                foreach (var card in hand.Cards)
                {
                    Add(card);
                }
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

        public List<Card> Cards { get => cards; }

        public CardFace GetHighestFace()
        {
            var highest = CardFace.Back;

            foreach (var card in cards)
            {
                if (card.Face > highest) highest = card.Face;
            }

            return highest;
        }

        public PokerHandRank CalculatePokerHandRank()
        {
            if (cards.Count != HAND_SIZE) return PokerHandRank.Invalid;

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
            if ((int)cards[1].Face == (int)cards[0].Face + 1 &&
                (int)cards[2].Face == (int)cards[1].Face + 1 &&
                (int)cards[3].Face == (int)cards[2].Face + 1 &&
                (int)cards[4].Face == (int)cards[3].Face + 1) return true;

            // Check ace high sequential
            if (HasAce())
            {
                if ((int)cards[2].Face == (int)cards[1].Face + 1 &&
                    (int)cards[3].Face == (int)cards[2].Face + 1 &&
                    (int)cards[4].Face == (int)cards[3].Face + 1 &&
                    (int)cards[4].Face == 13) return true;
            }
            return false;
        }

        public bool HasAce()
        {
            foreach (var card in cards)
            {
                if (card.Face == CardFace.Ace) return true;
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
                var Face = cards[i].Face;

                for (int j = 0; j < HAND_SIZE; j++)
                {
                    if (cards[i].Face == cards[j].Face) count++;
                }

                if (count == multiple) return true;
            }
            return false;
        }

        public bool IsFullHouse()
        {
            var face1 = CardFace.Back;
            var count1 = 0;
            var face2 = CardFace.Back;
            var count2 = 0;

            foreach (var card in cards)
            {
                if (card.Face == face1)
                {
                    count1++;
                    continue;
                }
                
                if (card.Face == face2)
                {
                    count2++;
                    continue;
                }

                if (face1 == CardFace.Back)
                {
                    face1 = card.Face;
                    count1++;
                    continue;
                }

                if (face2 == CardFace.Back)
                {
                    face2 = card.Face;
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
            var face1 = CardFace.Back;
            var face2 = CardFace.Back;

            for (int i = 0; i < HAND_SIZE - 1; i++)
            {
                for(int j = i + 1; j < HAND_SIZE; j++)
                {
                    //if (i == j) continue;

                    if (cards[i].Face == cards[j].Face)
                    {
                        if (face1 == cards[i].Face || face2 == cards[i].Face) continue;

                        if (face1 == CardFace.Back)
                        {
                            face1 = cards[i].Face;
                            continue;
                        }

                        if (face2 == CardFace.Back)
                        {
                            face2 = cards[i].Face;
                            continue;
                        }
                    }

                }
            }

            return (face1 != CardFace.Back && face2 != CardFace.Back);
        }

        public bool IsOnePair()
        {
            for (int i = 0; i < HAND_SIZE; i++)
            {
                for (int j = 0; j < HAND_SIZE; j++)
                {
                    if (i == j) continue;

                    if (cards[i].Face == cards[j].Face) return true;
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
                    if (this.GetHighestFace() > other.GetHighestFace()) return 1;
                    if (this.GetHighestFace() < other.GetHighestFace()) return -1;
                    break;
                case PokerHandRank.FourOfAKind:
                    if (this.GetFaceOfMultiple(4) > other.GetFaceOfMultiple(4)) return 1;
                    if (this.GetFaceOfMultiple(4) < other.GetFaceOfMultiple(4)) return -1;
                    if (this.GetFaceOfMultiple(1) > other.GetFaceOfMultiple(1)) return 1;
                    if (this.GetFaceOfMultiple(1) < other.GetFaceOfMultiple(1)) return -1;
                    break;
                case PokerHandRank.FullHouse:
                    if (this.GetFaceOfMultiple(3) > other.GetFaceOfMultiple(3)) return 1;
                    if (this.GetFaceOfMultiple(3) < other.GetFaceOfMultiple(3)) return -1;
                    if (this.GetFaceOfMultiple(2) > other.GetFaceOfMultiple(2)) return 1;
                    if (this.GetFaceOfMultiple(2) < other.GetFaceOfMultiple(2)) return -1;
                    break;
                case PokerHandRank.Flush:
                    var thisList = this.GetSortedListOfCardFaces();
                    var otherList = other.GetSortedListOfCardFaces();
                    for (int i = 0; i < thisList.Count; i++)
                    {
                        if (thisList[i] > otherList[i]) return 1;
                        if (thisList[i] < otherList[i]) return -1;
                    }
                    break;
                case PokerHandRank.Straight:
                    if (this.HasAce() && !other.HasAce()) return 1;
                    if (!this.HasAce() && other.HasAce()) return -1;
                    if (this.GetHighestFace() > other.GetHighestFace()) return 1;
                    if (this.GetHighestFace() < other.GetHighestFace()) return -1;
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

                    var thisHighCardRanks = this.GetSortedListOfCardFaces();
                    var otherHighCardRanks = other.GetSortedListOfCardFaces();
                    for (int i = 0; i < thisHighCardRanks.Count; i++)
                    {
                        if (thisHighCardRanks[i] > otherHighCardRanks[i]) return 1;
                        if (thisHighCardRanks[i] < otherHighCardRanks[i]) return -1;
                    }
                    break;
            }

            return 0;
        }

        public CardFace GetFaceOfMultiple(int multiple)
        {
            for (int i = 0; i < HAND_SIZE; i++)
            {
                var count = 0;
                var face = cards[i].Face;

                for (int j = 0; j < HAND_SIZE; j++)
                {
                    if (cards[i].Face == cards[j].Face) count++;
                }

                if (count == multiple) return face;
            }
            return 0;
        }

        public List<CardFace> GetSortedListOfCardFaces()
        {
            var faces = new List<CardFace>();

            foreach (var card in cards)
            {
                faces.Add(card.Face);
            }

            faces.Sort();
            faces.Reverse();

            return faces;
        }
        
        public List<CardFace> GetThreeOfAKindRanks()
        {
            var ranks = new List<CardFace>();

            ranks.Add(GetFaceOfMultiple(3));

            var list = GetSortedListOfCardFaces();
            list.Reverse();

            for (int i = 4; i >= 0; i--)
            {
                if (list[i] != ranks[0]) ranks.Add((CardFace)i);
            }

            return ranks;
        }

        public List<CardFace> GetTwoPairRanks()
        {
            var ranks = new List<CardFace>();

            var face1 = CardFace.Back;
            var face2 = CardFace.Back;
            var kicker = CardFace.Back;

            for (int i = 0; i < HAND_SIZE; i++)
            {
                for (int j = 0; j < HAND_SIZE; j++)
                {
                    if (i == j) continue;

                    if (cards[i].Face == cards[j].Face)
                    {
                        if (face1 == cards[i].Face || face2 == cards[i].Face) continue;

                        if (face1 == 0)
                        {
                            face1 = cards[i].Face;
                        }

                        if (face2 == 0)
                        {
                            face2 = cards[i].Face;
                        }
                    }
                }
            }

            foreach (var card in cards)
            {
                if (card.Face != face1 && card.Face != face2) kicker = card.Face;
            }

            ranks.Add(face1);
            ranks.Add(face2);
            ranks.Sort();
            if (ranks[0] != CardFace.Back) ranks.Reverse();
            ranks.Add(kicker);
            return ranks;
        }

        public List<CardFace> GetOnePairRanks()
        {
            var pair = GetFaceOfMultiple(2);
            var ranks = new List<CardFace>();

            foreach (var card in cards)
            {
                if (card.Face != pair) ranks.Add(card.Face);
            }

            ranks.Sort();
            ranks.Reverse();

            if (ranks[ranks.Count - 1] == CardFace.Ace)
            {
                ranks.RemoveAt(ranks.Count - 1);
                ranks.Insert(0, CardFace.Ace);
            }

            ranks.Insert(0, pair);
            return ranks;
        }
    }
}
