// Marc King - mjking@umich.edu
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

namespace Project1_Yahtzee
{
    public partial class MainForm : Form
    {
        private const string ROLLS_REMAIN_LABEL = "Rolls remaining this turn: ";

        private List<Bitmap> dieFaceBitmaps;
        private List<CheckBox> diceCheckBoxes;
        private Dictionary<ScoringCategory, Button> scoreCategoryToButton;
        private Dictionary<Button, ScoringCategory> scoreButtonToCategory;

        private GameManager game;

        public MainForm()
        {
            InitializeComponent();
            InitializeDieFaceBitmaps();
            InitializeDiceCheckBoxes();
            InitializeScoreButtons();

            NewGame();
        }

        private void NewGame()
        {
            game = new GameManager();

            RefreshDice();
            DiceEnabled = false;
            RefreshScoreCard();
            DisableScores();
        }

        private void RefreshDice()
        {
            for (int index = 0; index < diceCheckBoxes.Count; index++)
            {
                diceCheckBoxes[index].Image = dieFaceBitmaps[game.Rolls[index]];
                diceCheckBoxes[index].Checked = game.IsLocked(index);
            }

            rollsRemainLabel.Text = ROLLS_REMAIN_LABEL + game.RollsRemaining;
        }

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

        private void DisableScores()
        {
            foreach (var category in ScoringCategories.All)
            {
                scoreCategoryToButton[category].Enabled = false;
            }
        }

        private void RefreshScoreCard()
        {
            foreach (var category in ScoringCategories.All)
            {
                // fill permanent scores
                scoreCategoryToButton[category].Text = game.Scores[category].ToString();
                scoreCategoryToButton[category].Enabled = !game.KeepScore(category);
                // fill turn scores
                if (!game.KeepScore(category))
                {
                    scoreCategoryToButton[category].Text = game.RollScores[category].ToString();
                }

                if ((category == ScoringCategory.Bonus && game.Scores[category] > 0) 
                    || (category != ScoringCategory.Bonus && game.KeepScore(category)))
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
        /// Initializes the dictionary that maintains the relationship between the score buttons
        /// and their scoring category.
        /// </summary>
        private void InitializeScoreButtons()
        {
            scoreCategoryToButton = new Dictionary<ScoringCategory, Button>();

            scoreCategoryToButton.Add(ScoringCategory.Aces,          acesButton);
            scoreCategoryToButton.Add(ScoringCategory.Twos,          twosButton);
            scoreCategoryToButton.Add(ScoringCategory.Threes,        threesButton);
            scoreCategoryToButton.Add(ScoringCategory.Fours,         foursButton);
            scoreCategoryToButton.Add(ScoringCategory.Fives,         fivesButton);
            scoreCategoryToButton.Add(ScoringCategory.Sixes,         sixesButton);
            scoreCategoryToButton.Add(ScoringCategory.Bonus,         bonusButton);
            scoreCategoryToButton.Add(ScoringCategory.ThreeOfAKind,  threeOfAKindButton);
            scoreCategoryToButton.Add(ScoringCategory.FourOfAKind,   fourOfAKindButton);
            scoreCategoryToButton.Add(ScoringCategory.FullHouse,     fullHouseButton);
            scoreCategoryToButton.Add(ScoringCategory.SmallStraight, smallStraightButton);
            scoreCategoryToButton.Add(ScoringCategory.LargeStraight, largeStraightButton);
            scoreCategoryToButton.Add(ScoringCategory.Yahtzee,       yahtzeeButton);
            scoreCategoryToButton.Add(ScoringCategory.Chance,        chanceButton);

            scoreButtonToCategory = new Dictionary<Button, ScoringCategory>();

            foreach (var category in ScoringCategories.All)
            {
                scoreButtonToCategory.Add(scoreCategoryToButton[category], category);
            }
        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            // honor keep dice check boxes
            for (int index = 0; index < diceCheckBoxes.Count; index++)
            {
                game.KeepDieRoll(index, diceCheckBoxes[index].Checked);
            }

            game.RollDice();
            RefreshDice();
            RefreshScoreCard();

            var haveRollsRemaining = game.RollsRemaining > 0;
            DiceEnabled = haveRollsRemaining;
            rollDiceButton.Enabled = haveRollsRemaining;

            if (game.RollsRemaining == 0) UncheckDice();
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            ScoringCategory category = scoreButtonToCategory[(Button)sender];
            game.AcceptScore(category);
            RefreshDice();
            RefreshScoreCard();

            DiceEnabled = false;
            rollDiceButton.Enabled = true;
            DisableScores();
            rollsRemainLabel.Text = ROLLS_REMAIN_LABEL + game.RollsRemaining;

            UncheckDice();
        }

        private void UncheckDice()
        {
            for (int index = 0; index < diceCheckBoxes.Count; index++)
            {
                diceCheckBoxes[index].Checked = false;
            }
        }
    }
}
