// Marc King - mjking@umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project1_Yahtzee
{
    public partial class MainForm : Form
    {
        #region Public Constructors

        public MainForm()
        {
            InitializeComponent();
            InitializeDieFaceBitmaps();
            InitializeDiceCheckBoxes();
            InitializeScoreButtons();

            NewGame();
        }

        #endregion Public Constructors

        #region Private Fields

        /// <summary>
        /// Verbage for label showing the rolls remaining. 
        /// </summary>
        private const string ROLLS_REMAIN_LABEL = "Rolls remaining this turn: ";

        /// <summary>
        /// List of references to each of the die check boxes. 
        /// </summary>
        private List<CheckBox> diceCheckBoxes;

        /// <summary>
        /// List of reference to die face images. 
        /// </summary>
        private List<Bitmap> dieFaceBitmaps;

        /// <summary>
        /// Reference to the game manager for this game. 
        /// </summary>
        private GameManager game;

        /// <summary>
        /// Relationship dictionary of scoring categories by scorecard button. 
        /// </summary>
        private Dictionary<Button, ScoringCategory> scoreButtonToCategory;

        /// <summary>
        /// Relationship dictionary of scorecard buttons by scoring category. 
        /// </summary>
        private Dictionary<ScoringCategory, Button> scoreCategoryToButton;

        #endregion Private Fields

        #region Private Properties

        /// <summary>
        /// If the die check boxes are enabled. 
        /// </summary>
        private bool DiceEnabled
        {
            get
            {
                return diceCheckBoxes[0].Enabled;
            }

            set
            {
                foreach (var dieBox in diceCheckBoxes)
                {
                    dieBox.Enabled = value;
                }
            }
        }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// Disables all of the scorecard buttons. 
        /// </summary>
        private void DisableScores()
        {
            foreach (var category in ScoringCategories.All)
            {
                scoreCategoryToButton[category].Enabled = false;
            }
        }

        /// <summary>
        /// Initializes a list of references to the dice check boxes. 
        /// </summary>
        private void InitializeDiceCheckBoxes()
        {
            diceCheckBoxes = new List<CheckBox>();

            diceCheckBoxes.Add(die1);
            diceCheckBoxes.Add(die2);
            diceCheckBoxes.Add(die3);
            diceCheckBoxes.Add(die4);
            diceCheckBoxes.Add(die5);
        }

        /// <summary>
        /// Initializes a list of references to dice face images. 
        /// </summary>
        private void InitializeDieFaceBitmaps()
        {
            dieFaceBitmaps = new List<Bitmap>();

            dieFaceBitmaps.Add(Properties.Resources.DieFace0);
            dieFaceBitmaps.Add(Properties.Resources.DieFace1);
            dieFaceBitmaps.Add(Properties.Resources.DieFace2);
            dieFaceBitmaps.Add(Properties.Resources.DieFace3);
            dieFaceBitmaps.Add(Properties.Resources.DieFace4);
            dieFaceBitmaps.Add(Properties.Resources.DieFace5);
            dieFaceBitmaps.Add(Properties.Resources.DieFace6);
        }

        /// <summary>
        /// Initializes the dictionary that maintains the relationship between the score buttons and their scoring category. 
        /// </summary>
        private void InitializeScoreButtons()
        {
            scoreCategoryToButton = new Dictionary<ScoringCategory, Button>();

            scoreCategoryToButton.Add(ScoringCategory.Aces, acesButton);
            scoreCategoryToButton.Add(ScoringCategory.Twos, twosButton);
            scoreCategoryToButton.Add(ScoringCategory.Threes, threesButton);
            scoreCategoryToButton.Add(ScoringCategory.Fours, foursButton);
            scoreCategoryToButton.Add(ScoringCategory.Fives, fivesButton);
            scoreCategoryToButton.Add(ScoringCategory.Sixes, sixesButton);
            scoreCategoryToButton.Add(ScoringCategory.Bonus, bonusButton);
            scoreCategoryToButton.Add(ScoringCategory.ThreeOfAKind, threeOfAKindButton);
            scoreCategoryToButton.Add(ScoringCategory.FourOfAKind, fourOfAKindButton);
            scoreCategoryToButton.Add(ScoringCategory.FullHouse, fullHouseButton);
            scoreCategoryToButton.Add(ScoringCategory.SmallStraight, smallStraightButton);
            scoreCategoryToButton.Add(ScoringCategory.LargeStraight, largeStraightButton);
            scoreCategoryToButton.Add(ScoringCategory.Yahtzee, yahtzeeButton);
            scoreCategoryToButton.Add(ScoringCategory.Chance, chanceButton);

            scoreButtonToCategory = new Dictionary<Button, ScoringCategory>();

            foreach (var category in ScoringCategories.All)
            {
                scoreButtonToCategory.Add(scoreCategoryToButton[category], category);
            }
        }

        /// <summary>
        /// Creates a new game to play. 
        /// </summary>
        private void NewGame()
        {
            game = new GameManager();

            RefreshDice();
            DiceEnabled = false;
            RefreshScoreCard();
            DisableScores();
        }

        /// <summary>
        /// Prepares the interface for the next turn. 
        /// </summary>
        private void NextTurn()
        {
            RefreshDice();
            RefreshScoreCard();

            DiceEnabled = false;
            rollDiceButton.Enabled = true;
            DisableScores();

            UncheckDice();
        }

        /// <summary>
        /// Refreshes the die roller interface with values from the current game. 
        /// </summary>
        private void RefreshDice()
        {
            for (int index = 0; index < diceCheckBoxes.Count; index++)
            {
                diceCheckBoxes[index].Image = dieFaceBitmaps[game.Rolls[index]];
                diceCheckBoxes[index].Checked = game.WillKeep(index);
            }

            rollsRemainLabel.Text = ROLLS_REMAIN_LABEL + game.RollsRemaining;
        }

        /// <summary>
        /// Refreshes the score card interface with value from the current game. 
        /// </summary>
        private void RefreshScoreCard()
        {
            foreach (var category in ScoringCategories.All)
            {
                // fill permanent scores
                scoreCategoryToButton[category].Text = game.Scores[category].ToString();
                scoreCategoryToButton[category].Enabled = !game.IsScoreAccepted(category);
                // fill turn scores
                if (!game.IsScoreAccepted(category))
                {
                    scoreCategoryToButton[category].Text = game.RollScores[category].ToString();
                }

                if ((category == ScoringCategory.Bonus && game.Scores[category] > 0)
                    || (category != ScoringCategory.Bonus && game.IsScoreAccepted(category)))
                {
                    scoreCategoryToButton[category].BackColor = Color.PaleGreen;
                }
                else
                {
                    scoreCategoryToButton[category].BackColor = Color.WhiteSmoke;
                }
            }
        }

        /// <summary>
        /// Roll any dice that are not marked to be kept. 
        /// </summary>
        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            // honor keep dice check boxes
            for (int index = 0; index < diceCheckBoxes.Count; index++)
            {
                game.SetWillKeep(index, diceCheckBoxes[index].Checked);
            }

            game.CalculateNextRollScores();

            RefreshDice();
            RefreshScoreCard();

            var haveRollsRemaining = game.RollsRemaining > 0;
            DiceEnabled = haveRollsRemaining;
            rollDiceButton.Enabled = haveRollsRemaining;

            if (game.RollsRemaining == 0) UncheckDice();
        }

        /// <summary>
        /// Select a score based on the current rolls and enter it into the scorecard. 
        /// </summary>
        private void scoreButton_Click(object sender, EventArgs e)
        {
            var category = scoreButtonToCategory[(Button)sender];
            game.AcceptScore(category);

            NextTurn();
            if (game.IsOver())
            {
                var gameOver = new GameOverForm();
                gameOver.DisplayScore(game.TotalScore);
                NewGame();
                gameOver.ShowDialog();
            }
        }

        /// <summary>
        /// Sets all dice check boxes as unchecked. 
        /// </summary>
        private void UncheckDice()
        {
            for (int index = 0; index < diceCheckBoxes.Count; index++)
            {
                diceCheckBoxes[index].Checked = false;
            }
        }

        #endregion Private Methods
    }
}
