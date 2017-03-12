// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem
{
    /// <summary>
    /// Mananges the play sequence of Texas Hold 'em.
    /// </summary>
    public class TexasHoldemManager
    {
        public const int STARTING_MONEY = 100;
        public const int BET_AMOUNT = 5;
        public const int POSSIBLE_OPPONENT_HANDS = 2227500;

        private GameState state = GameState.BeforeFirstDeal;
        public GameState State { get => state; }

        private PokerHand communityHand = null;
        public PokerHand CommunityHand { get => communityHand; }

        private PokerHand playerHand = null;
        public PokerHand PlayerHand { get => playerHand; }

        private PokerHand opponentHand = null;
        public PokerHand OpponentHand { get => opponentHand; }

        private int playerMoney = STARTING_MONEY;
        public int PlayerMoney { get => playerMoney; }

        private int opponentMoney = STARTING_MONEY;
        public int OpponentMoney { get => opponentMoney; }

        private int playerPot = 0;
        public int PlayerPot { get => playerPot; }

        private int opponentPot = 0;
        public int OpponentPot { get => opponentPot; }

        public int TotalPot { get => playerPot + opponentPot; }

        private float playerOdds = 0.0f;
        public float PlayerOdds { get => playerOdds; }

        private float opponentOdds = 0.0f;
        public float OpponentOdds { get => opponentOdds; }

        private string dealOutcome = "";
        public string DealOutcome { get => dealOutcome; }

        private int tempCombiCount = 0;

        public TexasHoldemManager()
        {

        }

        public void Deal()
        {
            var deck = new CardDeck();

            // Deal out all cards
            communityHand = new PokerHand();
            communityHand.Add(deck.TakeCard());
            communityHand.Add(deck.TakeCard());
            communityHand.Add(deck.TakeCard());
            communityHand.Add(deck.TakeCard());
            communityHand.Add(deck.TakeCard());
            playerHand = new PokerHand();
            playerHand.Add(deck.TakeCard());
            playerHand.Add(deck.TakeCard());
            opponentHand = new PokerHand();
            opponentHand.Add(deck.TakeCard());
            opponentHand.Add(deck.TakeCard());

            // Ante
            playerMoney -= BET_AMOUNT;
            playerPot += BET_AMOUNT;
            opponentMoney -= BET_AMOUNT;
            opponentPot += BET_AMOUNT;

            // Calculate odds
            var playerBestHand = PokerHandCombinations.GeneratePotentialHands(communityHand, playerHand)[0];
            playerOdds = CalculateOdds(playerBestHand, playerHand);

            var opponentBestHand = PokerHandCombinations.GeneratePotentialHands(communityHand, opponentHand)[0];
            opponentOdds = CalculateOdds(opponentBestHand, opponentHand);

            state = GameState.DuringRound;

            if (opponentOdds >= 0.5f)
            {
                opponentMoney -= BET_AMOUNT;
                opponentPot += BET_AMOUNT;
            }
            else
            {
                Fold();
            }
        }

        private float CalculateOdds(PokerHand bestHand, PokerHand holeHand)
        {
            var bestHandRank = 0;
            var remainingHands = PokerHandCombinations.GenerateRemainingHands(communityHand, holeHand);
            tempCombiCount = remainingHands.Count;

            foreach (var hand in remainingHands)
            {
                bestHandRank += bestHand.CompareTo(hand);
            }
            return (((POSSIBLE_OPPONENT_HANDS / 2) + bestHandRank) / (float)POSSIBLE_OPPONENT_HANDS);
        }

        public void Call()
        {

            state = GameState.AfterRound;
        }

        public void Fold(bool playerFolded = false)
        {
            state = GameState.AfterRound;
        }
    }
}
