// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System.Collections.Generic;

namespace TexasHoldem
{
    /// <summary>
    /// Generates combinations of hands for use in probability checking.
    /// </summary>
    public static class PokerHandCombinations
    {
        /// <summary>
        /// Generates the best hands from the two cards of the player/computer and the community cards.
        /// </summary>
        /// <param name="communityHand">Current community cards on the board.</param>
        /// <param name="knownHoleHand">Two cards dealt to the player/computer.</param>
        /// <returns>A sorted list of all best hands in descending order.</returns>
        public static List<PokerHand> GenerateBestHands(PokerHand communityHand, PokerHand knownHoleHand)
        {
            var hands = new List<PokerHand>();
            var holeHands = GenerateTwoCardHoleHands(communityHand, knownHoleHand);

            foreach (var hand in holeHands)
            {
                hands.Add(FindBestHand(communityHand, hand));
            }

            hands.Sort();
            hands.Reverse();
            return hands;
        }


        public static PokerHand FindBestHand(PokerHand communityHand, PokerHand holeHand)
        {
            // Create a list of all possible hands.
            var possibleHands = new List<PokerHand>();

            // You can always use the community hand.
            possibleHands.Add(communityHand);

            // All possible hands using two hole cards.
            for (int i = 0; i < communityHand.Cards.Count - 2; i++)
            {
                for (int j = i + 1; j < communityHand.Cards.Count - 1; j++)
                {
                    for (int k = j + 1; k < communityHand.Cards.Count; k++)
                    {
                        var hand = new PokerHand();

                        hand.Add(holeHand);
                        hand.Add(communityHand.Cards[i]);
                        hand.Add(communityHand.Cards[j]);
                        hand.Add(communityHand.Cards[k]);

                        possibleHands.Add(hand);
                    }
                }
            }

            // All possible hands using one hole card.
            for (int i = 0; i < holeHand.Cards.Count; i++)
            {
                for (int j = 0; j < communityHand.Cards.Count - 3; j++)
                {
                    for (int k = j + 1; k < communityHand.Cards.Count - 2; k++)
                    {
                        for (int m = k + 1; m < communityHand.Cards.Count - 1; m++)
                        {
                            for (int n = m + 1; n < communityHand.Cards.Count; n++)
                            {
                                var hand = new PokerHand();

                                hand.Add(holeHand.Cards[i]);
                                hand.Add(communityHand.Cards[j]);
                                hand.Add(communityHand.Cards[k]);
                                hand.Add(communityHand.Cards[m]);
                                hand.Add(communityHand.Cards[n]);

                                possibleHands.Add(hand);
                            }
                        }
                    }
                }
            }

            // Sort to put the best hand at index zero.
            possibleHands.Sort();
            possibleHands.Reverse();
            return possibleHands[0];
        }








        private static List<PokerHand> GenerateTwoCardHoleHands(PokerHand communityHand, PokerHand knownHoleHand)
        {
            var hands = new List<PokerHand>();

            // We need a list of the remaining cards.
            var deck = new CardDeck();
            var remainingCards = deck.Cards;

            // Remove community hand cards.
            foreach (var card in communityHand.Cards)
            {
                remainingCards.Remove(card);
            }

            // Remove known hole hand cards.
            foreach (var card in knownHoleHand.Cards)
            {
                remainingCards.Remove(card);
            }

            // We need a list of every possible 2 card combination in the remaining cards.
            var twoCardHands = new List<PokerHand>();
            for (int i = 0; i < remainingCards.Count - 1; i++)
            {
                for (int j = i + 1; j < remainingCards.Count; j++)
                {
                    var hand = new PokerHand();

                    hand.Add(remainingCards[i]);
                    hand.Add(remainingCards[j]);

                    twoCardHands.Add(hand);
                }
            }

            //twoCardHands.Sort();
            //twoCardHands.Reverse();
            return twoCardHands;
        }
    }
}
