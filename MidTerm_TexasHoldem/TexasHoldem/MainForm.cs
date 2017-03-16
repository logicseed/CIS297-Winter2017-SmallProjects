// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexasHoldem
{
    public partial class MainForm : Form
    {
        private TexasHoldemManager game;
        private CardImage cardImage = CardImage.Instance;

        public MainForm()
        {
            InitializeComponent();
            RestartGame();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            game.Deal();
            RefreshPokerTable();
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            game.Call();
            RefreshPokerTable();
        }

        private void foldButton_Click(object sender, EventArgs e)
        {
            game.Fold(true);
            RefreshPokerTable();
        }

        /// <summary>
        /// Restarts the game from the beginning.
        /// </summary>
        public void RestartGame()
        {
            game = new TexasHoldemManager();
            RefreshPokerTable();
        }

        /// <summary>
        /// Refreshes the GUI for the game.
        /// </summary>
        public void RefreshPokerTable()
        {
            RefreshCommunityCards(game.CommunityHand);
            RefreshPlayerCards(game.PlayerHand);
            var showOpponentHand = (game.State == GameState.AfterRound);
            RefreshOpponentCards(game.OpponentHand, showOpponentHand);
            RefreshPotAndMoney();

            switch (game.State)
            {
                case GameState.BeforeFirstDeal:
                    outcomeLabel.Text = "";
                    playerOddsLabel.Text = "";
                    callButton.Enabled = false;
                    foldButton.Enabled = false;
                    dealButton.Enabled = true;
                    break;

                case GameState.DuringRound:
                    outcomeLabel.Text = "";
                    playerOddsLabel.Text = $"Odds of Winning: {game.PlayerOdds * 100:0.00}%";
                    callButton.Enabled = true;
                    foldButton.Enabled = true;
                    dealButton.Enabled = false;
                    break;
                case GameState.AfterRound:
                    outcomeLabel.Text = game.DealOutcome;
                    playerOddsLabel.Text = "";
                    callButton.Enabled = false;
                    foldButton.Enabled = false;
                    dealButton.Enabled = true;
                    break;
                case GameState.GameOver:
                    outcomeLabel.Text = game.DealOutcome;
                    playerOddsLabel.Text = "";
                    callButton.Enabled = false;
                    foldButton.Enabled = false;
                    dealButton.Enabled = false;
                    break;
            }
            
        }

        /// <summary>
        /// Refreshes the GUI for the community hand.
        /// </summary>
        /// <param name="communityHand">The community hand.</param>
        private void RefreshCommunityCards(PokerHand communityHand = null)
        {
            // Handle empty hand, like before the game begins
            if (communityHand == null)
            {
                communityHand = new PokerHand();
                var card = new Card(CardSuit.Invalid, CardFace.Back);
                communityHand.Add(card);
                communityHand.Add(card);
                communityHand.Add(card);
                communityHand.Add(card);
                communityHand.Add(card);
            }
            communityCard1Label.Text = cardImage[communityHand.Cards[0].Suit, communityHand.Cards[0].Face];
            communityCard2Label.Text = cardImage[communityHand.Cards[1].Suit, communityHand.Cards[1].Face];
            communityCard3Label.Text = cardImage[communityHand.Cards[2].Suit, communityHand.Cards[2].Face];
            communityCard4Label.Text = cardImage[communityHand.Cards[3].Suit, communityHand.Cards[3].Face];
            communityCard5Label.Text = cardImage[communityHand.Cards[4].Suit, communityHand.Cards[4].Face];

            communityCard1Label.ForeColor = CardColor(communityHand.Cards[0]);
            communityCard2Label.ForeColor = CardColor(communityHand.Cards[1]);
            communityCard3Label.ForeColor = CardColor(communityHand.Cards[2]);
            communityCard4Label.ForeColor = CardColor(communityHand.Cards[3]);
            communityCard5Label.ForeColor = CardColor(communityHand.Cards[4]);
        }

        /// <summary>
        /// Refreshes the GUI for the player hand.
        /// </summary>
        /// <param name="playerHand">The player hand.</param>
        private void RefreshPlayerCards(PokerHand playerHand = null)
        {
            // Handle empty hand, like before the game begins
            if (playerHand == null)
            {
                playerHand = new PokerHand();
                var card = new Card(CardSuit.Invalid, CardFace.Back);
                playerHand.Add(card);
                playerHand.Add(card);
            }
            playerCard1Label.Text = cardImage[playerHand.Cards[0].Suit, playerHand.Cards[0].Face];
            playerCard2Label.Text = cardImage[playerHand.Cards[1].Suit, playerHand.Cards[1].Face];

            playerCard1Label.ForeColor = CardColor(playerHand.Cards[0]);
            playerCard2Label.ForeColor = CardColor(playerHand.Cards[1]);
        }

        /// <summary>
        /// Refreshes the GUI for the opponent hand.
        /// </summary>
        /// <param name="opponentHand">The opponent hand.</param>
        /// <param name="showFaces">If the faces should be displayed.</param>
        private void RefreshOpponentCards(PokerHand opponentHand = null, bool showFaces = false)
        {
            // Handle empty hand, like before the game begins
            if (opponentHand == null)
            {
                opponentHand = new PokerHand();
                var card = new Card(CardSuit.Invalid, CardFace.Back);
                opponentHand.Add(card);
                opponentHand.Add(card);
            }

            if (showFaces)
            {
                opponentCard1Label.Text = cardImage[opponentHand.Cards[0].Suit, opponentHand.Cards[0].Face];
                opponentCard2Label.Text = cardImage[opponentHand.Cards[1].Suit, opponentHand.Cards[1].Face];

                opponentCard1Label.ForeColor = CardColor(opponentHand.Cards[0]);
                opponentCard2Label.ForeColor = CardColor(opponentHand.Cards[1]);
            }
            else
            {
                opponentCard1Label.Text = cardImage[opponentHand.Cards[0].Suit, CardFace.Back];
                opponentCard2Label.Text = cardImage[opponentHand.Cards[1].Suit, CardFace.Back];

                opponentCard1Label.ForeColor = CardColor();
                opponentCard2Label.ForeColor = CardColor();
            }
        }

        /// <summary>
        /// Refreshes the GUI for the pot and money values.
        /// </summary>
        private void RefreshPotAndMoney()
        {
            // Pot
            totalPotLabel.Text = $"Total: ${game.TotalPot}";
            playerPotLabel.Text = $"Player: ${game.PlayerPot}";
            opponentPotLabel.Text = $"Opponent: ${game.OpponentPot}";

            // Money
            playerMoneyLabel.Text = $"Player: ${game.PlayerMoney}";
            opponentMoneyLabel.Text = $"Opponent: ${game.OpponentMoney}";
        }

        /// <summary>
        /// Determines the color of the card based on its suit, or if it's hidden.
        /// </summary>
        /// <param name="card">The card to colorize.</param>
        /// <returns>The color the card should be displayed in.</returns>
        public Color CardColor(Card card = null)
        {
            if (card == null || card.Face == CardFace.Back) return Color.Blue;

            if (card.Suit == CardSuit.Clubs || card.Suit == CardSuit.Spades) return Color.Black;

            if (card.Suit == CardSuit.Diamonds || card.Suit == CardSuit.Hearts) return Color.Red;

            return Color.Blue;
        }
    }
}
