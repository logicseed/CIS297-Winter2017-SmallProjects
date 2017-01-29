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
    public partial class GameOverForm : Form
    {
        public GameOverForm()
        {
            InitializeComponent();
        }

        public void DisplayScore(int score)
        {
            scoreLabel.Text = $"You scored {score} points!";
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
