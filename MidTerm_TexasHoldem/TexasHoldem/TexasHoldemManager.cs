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
        public const int POSSIBLE_OPPONENT_HANDS = 990;

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
            var playerBestHand = PokerHandCombinations.FindBestHand(communityHand, playerHand);
            playerOdds = CalculateOdds(playerBestHand, opponentHand);

            var opponentBestHand = PokerHandCombinations.FindBestHand(communityHand, opponentHand);
            opponentOdds = CalculateOdds(opponentBestHand, playerHand);

            CheckForGameOver(GameState.DuringRound);

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
            var remainingHands = PokerHandCombinations.GenerateBestHands(communityHand, holeHand);

            foreach (var hand in remainingHands)
            {
                bestHandRank += bestHand.CompareTo(hand);
            }

            return (((POSSIBLE_OPPONENT_HANDS + bestHandRank) / 2) / (float)POSSIBLE_OPPONENT_HANDS);
        }

        public void Call()
        {
            playerMoney -= BET_AMOUNT;
            playerPot += BET_AMOUNT;

            var playerBestHand = PokerHandCombinations.FindBestHand(communityHand, playerHand);
            var opponentBestHand = PokerHandCombinations.FindBestHand(communityHand, opponentHand);

            var call = playerBestHand.CompareTo(opponentBestHand);
            if (call == -1)
            {
                dealOutcome = "YOU LOSE!";
                opponentMoney += opponentPot + playerPot;
                opponentPot = playerPot = 0;
            }
            else if (call == 0)
            {
                dealOutcome = "IT'S A TIE!";
            }
            else if (call == 1)
            {
                dealOutcome = "YOU WIN!";
                playerMoney += opponentPot + playerPot;
                opponentPot = playerPot = 0;
            }

            CheckForGameOver(GameState.AfterRound);
        }

        public void Fold(bool playerFolded = false)
        {
            if (playerFolded)
            {
                dealOutcome = "YOU LOSE! YOU FOLDED!";
                opponentMoney += opponentPot + playerPot;
            }
            else
            {
                dealOutcome = "YOU WIN! THEY FOLDED!";
                playerMoney += opponentPot + playerPot;
            }
            opponentPot = playerPot = 0;

            CheckForGameOver(GameState.AfterRound);
        }

        private void CheckForGameOver(GameState nextState)
        {
            if (playerMoney <= 0)
            {
                dealOutcome = "YOU RAN OUT OF MONEY!";
                state = GameState.GameOver;
            }
            else if (opponentMoney <= 0)
            {
                dealOutcome = "YOU WIN! THEY'RE BROKE!";
                state = GameState.GameOver;
            }
            else
            {
                state = nextState;
            }
        }
    }
}
