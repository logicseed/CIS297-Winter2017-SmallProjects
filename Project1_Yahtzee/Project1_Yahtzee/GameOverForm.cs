// Marc King - mjking@umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;
using System.Windows.Forms;

namespace Project1_Yahtzee
{
    public partial class GameOverForm : Form
    {
        #region Public Constructors

        public GameOverForm()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Displays the final score to the player. 
        /// </summary>
        /// <param name="score"> Final score for the game. </param>
        public void DisplayScore(int score)
        {
            scoreLabel.Text = $"You scored {score} points!";
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Starts a new game. 
        /// </summary>
        private void playAgainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Quits the game. 
        /// </summary>
        private void quitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion Private Methods
    }
}
