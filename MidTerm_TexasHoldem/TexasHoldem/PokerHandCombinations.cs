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
        /// Generates the potential hands from the two cards of the player/computer and the community cards.
        /// </summary>
        /// <param name="communityHand">Current community cards on the board.</param>
        /// <param name="playerHand">Two cards dealt to the player/computer.</param>
        /// <returns>A sorted list of all potential hands in descending order.</returns>
        public static List<PokerHand> GeneratePotentialHands(PokerHand communityHand, PokerHand playerHand)
        {
            var hands = new List<PokerHand>();

            // Using just the community cards is always an option.
            hands.Add(communityHand);

            hands.AddRange(GenerateHandsUsingOneCard(communityHand, playerHand.Cards));
            hands.AddRange(GenerateHandsUsingTwoCards(communityHand, playerHand));

            hands.Sort();
            hands.Reverse();
            return hands;
        }

        /// <summary>
        /// Generates the hands that can be made from the community cards and all remaining cards.
        /// </summary>
        /// <param name="communityHand">Current community cards on the board.</param>
        /// <param name="playerHand">Two cards dealt to the player/computer.</param>
        /// <returns>A sorted list of all potential hands in descending order.</returns>
        /// <remarks>This method generates 2,227,500 poker hands!!</remarks>
        public static List<PokerHand> GenerateRemainingHands(PokerHand communityHand, PokerHand playerHand)
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

            // Remove player's hand cards.
            foreach (var card in playerHand.Cards)
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

            foreach (var hand in twoCardHands)
            {
                hands.AddRange(GenerateHandsUsingTwoCards(communityHand, hand));
            }
            hands.AddRange(GenerateHandsUsingOneCard(communityHand, remainingCards));
            // Using just the community cards is always an option.
            hands.Add(communityHand);

            hands.Sort();
            hands.Reverse();
            return hands;
        }

        /// <summary>
        /// Generates all possible hands from four community cards and one card from a list of cards.
        /// </summary>
        /// <param name="communityHand">Current community cards on the board.</param>
        /// <param name="playerCards">List of cards to use with the community cards.</param>
        /// <returns>A list of all potential hands.</returns>
        private static List<PokerHand> GenerateHandsUsingOneCard(PokerHand communityHand, List<Card> playerCards)
        {
            var hands = new List<PokerHand>();

            for (int i = 0; i < playerCards.Count; i++)
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

                                hand.Add(playerCards[i]);
                                hand.Add(communityHand.Cards[j]);
                                hand.Add(communityHand.Cards[k]);
                                hand.Add(communityHand.Cards[m]);
                                hand.Add(communityHand.Cards[n]);

                                hands.Add(hand);
                            }
                        }
                    }
                }
            }

            return hands;
        }

        /// <summary>
        /// Generates all possible hands from three community cards and the provided player hand.
        /// </summary>
        /// <param name="communityHand">Current community cards on the board.</param>
        /// <param name="playerHand">Poker hand consisting of two cards that will be used with the community cards.</param>
        /// <returns>A list of all potential hands.</returns>
        private static List<PokerHand> GenerateHandsUsingTwoCards(PokerHand communityHand, PokerHand playerHand)
        {
            var hands = new List<PokerHand>();

            for (int i = 0; i < communityHand.Cards.Count - 2; i++)
            {
                for (int j = i + 1; j < communityHand.Cards.Count - 1; j++)
                {
                    for (int k = j + 1; k < communityHand.Cards.Count; k++)
                    {
                        var hand = new PokerHand();

                        hand.Add(playerHand);
                        hand.Add(communityHand.Cards[i]);
                        hand.Add(communityHand.Cards[j]);
                        hand.Add(communityHand.Cards[k]);

                        hands.Add(hand);
                    }
                }
            }

            return hands;
        }
    }
}
