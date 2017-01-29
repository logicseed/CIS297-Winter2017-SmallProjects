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
        private List<Bitmap> dieFaceImages;
        private List<CheckBox> diceCheckBoxes;
        private Dictionary<ScoringCategory, Button> scoreButtons;

        private Random random;
        private DiceRoller diceRoller;
        private ScoreCard scoreCard;

        public MainForm()
        {
            InitializeComponent();
            InitializeDieFaceImages();
            InitializeDiceCheckBoxes();
            InitializeScoreButtons();

            random = new Random();
            diceRoller = new DiceRoller(random);
            scoreCard = new ScoreCard();
        }


        private void InitializeDieFaceImages()
        {
            dieFaceImages = new List<Bitmap>();

            dieFaceImages.Add(global::Project1_Yahtzee.Properties.Resources.DieFace0);
            dieFaceImages.Add(global::Project1_Yahtzee.Properties.Resources.DieFace1);
            dieFaceImages.Add(global::Project1_Yahtzee.Properties.Resources.DieFace2);
            dieFaceImages.Add(global::Project1_Yahtzee.Properties.Resources.DieFace3);
            dieFaceImages.Add(global::Project1_Yahtzee.Properties.Resources.DieFace4);
            dieFaceImages.Add(global::Project1_Yahtzee.Properties.Resources.DieFace5);
            dieFaceImages.Add(global::Project1_Yahtzee.Properties.Resources.DieFace6);
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
            scoreButtons = new Dictionary<ScoringCategory, Button>();

            scoreButtons.Add(ScoringCategory.Aces,          acesButton);
            scoreButtons.Add(ScoringCategory.Twos,          twosButton);
            scoreButtons.Add(ScoringCategory.Threes,        threesButton);
            scoreButtons.Add(ScoringCategory.Fours,         foursButton);
            scoreButtons.Add(ScoringCategory.Fives,         fivesButton);
            scoreButtons.Add(ScoringCategory.Sixes,         sixesButton);
            scoreButtons.Add(ScoringCategory.Bonus,         bonusButton);
            scoreButtons.Add(ScoringCategory.ThreeOfAKind,  threeOfAKindButton);
            scoreButtons.Add(ScoringCategory.FourOfAKind,   fourOfAKindButton);
            scoreButtons.Add(ScoringCategory.FullHouse,     fullHouseButton);
            scoreButtons.Add(ScoringCategory.SmallStraight, smallStraightButton);
            scoreButtons.Add(ScoringCategory.LargeStraight, largeStraightButton);
            scoreButtons.Add(ScoringCategory.Yahtzee,       yahtzeeButton);
            scoreButtons.Add(ScoringCategory.Chance,        chanceButton);
        }
    }
}
