// Marc King - mjking@umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;
using System.Collections.Generic;
using System.Linq;

namespace Project1_Yahtzee
{
    /// <summary>
    /// Represents a complete Yahtzee score card.
    /// </summary>
    public class ScoreCard
    {
        #region Private Fields

        /// <summary>
        /// The current scores on the score card.
        /// </summary>
        private Dictionary<ScoringCategory, int> scores;

        /// <summary>
        /// Whether or not a score category has been accepted; or locked in.
        /// </summary>
        private Dictionary<ScoringCategory, bool> scoreAccepted;

        #endregion Private Fields

        #region Constructors

        /// <summary>
        /// Prepares the score card for use.
        /// </summary>
        public ScoreCard()
        {
            // Initialize collection fields
            this.scores = new Dictionary<ScoringCategory, int>();
            this.scoreAccepted = new Dictionary<ScoringCategory, bool>();

            var scoringCategories = Enum.GetNames(typeof(ScoringCategory)).Cast<ScoringCategory>();

            foreach (var category in scoringCategories)
            {
                this.scores.Add(category, 0);
                this.scoreAccepted.Add(category, false);
            }
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Accepts a score for a specific scoring category.
        /// </summary>
        /// <param name="category">The category to accept the score for.</param>
        /// <param name="score">The value of the score.</param>
        public void AcceptScore(ScoringCategory category, int score)
        {
            if (scoreAccepted[category] == false)
            {
                this.scores[category] = score;
                this.scoreAccepted[category] = true;
            }
        }

        /// <summary>
        /// Gets the score a a specific scoring category.
        /// </summary>
        /// <param name="category">The category to get the score for.</param>
        /// <returns>The score of the specific scoring category.</returns>
        public int GetScore(ScoringCategory category)
        {
            return this.scores[category];
        }

        /// <summary>
        /// Whether or not the score for a scoring category has been accepted; or locked in.
        /// </summary>
        /// <param name="category">The scoring category to check for acceptance.</param>
        /// <returns>True if the score for the category has been accepted; false otherwise.</returns> 
        public bool IsScoreAccepted(ScoringCategory category)
        {
            return this.scoreAccepted[category];
        }

        #endregion Public Methods
    }
}