// Marc King - mjking@umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System.Collections.Generic;

namespace Project1_Yahtzee
{
    /// <summary>
    /// Represents a complete Yahtzee score card. 
    /// </summary>
    public class ScoreCard
    {
        #region Public Constructors

        /// <summary>
        /// Prepares the score card for use. 
        /// </summary>
        public ScoreCard()
        {
            // Initialize collection fields
            scores = new Dictionary<ScoringCategory, int>();
            scoreAccepted = new Dictionary<ScoringCategory, bool>();

            foreach (var category in ScoringCategories.All)
            {
                scores.Add(category, 0);
                scoreAccepted.Add(category, false);
            }

            scoreAccepted[ScoringCategory.Bonus] = true;
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// DIcionary of score by scoring category.
        /// </summary>
        public Dictionary<ScoringCategory, int> Scores
        {
            get
            {
                return scores;
            }
        }

        #endregion Public Properties

        #region Public Indexers

        /// <summary>
        /// Indexer to return the score of a scoring category. 
        /// </summary>
        /// <param name="category"> Scoring category to return the score for. </param>
        /// <returns> The score of the scoring category. </returns>
        public int this[ScoringCategory category]
        {
            get { return scores[category]; }
        }

        #endregion Public Indexers

        #region Public Methods

        /// <summary>
        /// Accepts a score for a specific scoring category. 
        /// </summary>
        /// <param name="category"> The category to accept the score for. </param>
        /// <param name="score"> The value of the score. </param>
        public void AcceptScore(ScoringCategory category, int score)
        {
            scores[category] = score;
            scoreAccepted[category] = true;
        }

        /// <summary>
        /// Whether or not the score for a scoring category has been accepted; or locked in. 
        /// </summary>
        /// <param name="category"> The scoring category to check for acceptance. </param>
        /// <returns> True if the score for the category has been accepted; false otherwise. </returns>
        public bool IsScoreAccepted(ScoringCategory category)
        {
            return scoreAccepted[category];
        }

        #endregion Public Methods

        #region Private Fields

        /// <summary>
        /// Whether or not a score category has been accepted; or locked in. 
        /// </summary>
        private Dictionary<ScoringCategory, bool> scoreAccepted;

        /// <summary>
        /// The current scores on the score card. 
        /// </summary>
        private Dictionary<ScoringCategory, int> scores;

        #endregion Private Fields
    }
}
