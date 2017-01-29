// Marc King - mjking@umich.edu 
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System.Collections.Generic;

namespace Project1_Yahtzee
{
    /// <summary>
    /// Manages the states of the game. 
    /// </summary>
    public class GameManager
    {
        #region Public Constructors

        public GameManager()
        {
            gameState = new FirstMoveState();
            scoreCard = new ScoreCard();
            roller = new DiceRoller();
            rollScores = new Dictionary<ScoringCategory, int>(scoreCard.Scores);
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// List of the current die rolls. 
        /// </summary>
        public List<int> Rolls
        {
            get
            {
                return roller.Dice;
            }
        }

        /// <summary>
        /// Dictionary of scores based on current die rolls by scoring category. 
        /// </summary>
        public Dictionary<ScoringCategory, int> RollScores
        {
            get
            {
                return rollScores;
            }
        }

        /// <summary>
        /// How many rolls remain for the current turn. 
        /// </summary>
        public int RollsRemaining
        {
            get
            {
                return roller.RollsRemaining;
            }
        }

        /// <summary>
        /// Dictionary of current scores by scoring category. 
        /// </summary>
        public Dictionary<ScoringCategory, int> Scores
        {
            get
            {
                return scoreCard.Scores;
            }
        }

        /// <summary>
        /// Sum of all current scores. 
        /// </summary>
        public int TotalScore
        {
            get
            {
                var totalScore = 0;
                foreach (var category in ScoringCategories.All)
                {
                    totalScore += scoreCard.Scores[category];
                }
                return totalScore;
            }
        }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Accepts the scoring category for the current roll onto the scorecard. 
        /// </summary>
        /// <param name="category"> Scoring category to accept. </param>
        /// <returns> True is accepted; false otherwise. </returns>
        public bool AcceptScore(ScoringCategory category)
        {
            if (gameState.AcceptScore(this, scoreCard, category, rollScores))
            {
                roller = new DiceRoller();
                rollScores = ScoreCalculator.CalculateDice(roller.SortedDice);
                scoreCard.AcceptScore(ScoringCategory.Bonus, ScoreCalculator.CalculateBonus(scoreCard.Scores));
                rollScores.Add(ScoringCategory.Bonus, ScoreCalculator.CalculateBonus(scoreCard.Scores));

                return true;
            }
            return false;
        }

        /// <summary>
        /// Calculates scores based on next die roll. 
        /// </summary>
        /// <returns></returns>
        public bool CalculateNextRollScores()
        {
            if (gameState.RollDice(this, roller) == true)
            {
                rollScores = ScoreCalculator.CalculateDice(roller.SortedDice);
                rollScores.Add(ScoringCategory.Bonus, ScoreCalculator.CalculateBonus(scoreCard.Scores));
                return true;
            }
            return false;
        }

        /// <summary>
        /// Determine if the game is over. 
        /// </summary>
        /// <returns> True if the game is over; false otherwise. </returns>
        public bool IsOver()
        {
            var isOver = true;

            foreach (var category in ScoringCategories.All)
            {
                isOver &= scoreCard.IsScoreAccepted(category);
                if (isOver == false) return isOver;
            }

            return isOver;
        }

        /// <summary>
        /// Determine if the scorecard category has been accepted. 
        /// </summary>
        /// <param name="category"> Category to check. </param>
        /// <returns> True if score category has been accepted; false otherwise. </returns>
        public bool IsScoreAccepted(ScoringCategory category)
        {
            return scoreCard.IsScoreAccepted(category);
        }

        /// <summary>
        /// Changes the state of the game 
        /// </summary>
        /// <param name="gameState"></param>
        public void NextState(AbstractGameState gameState)
        {
            this.gameState = gameState;
        }

        /// <summary>
        /// Sets whether or not a die roll will be kept. 
        /// </summary>
        /// <param name="die"> Zero index of die roll to set. </param>
        /// <param name="keep"> If the die should be kept. </param>
        /// <returns></returns>
        public bool SetWillKeep(int die, bool keep)
        {
            return gameState.SetWillKeep(this, roller, die, keep);
        }

        /// <summary>
        /// Determine if a die roll is marked to be kept. 
        /// </summary>
        /// <param name="die"> Zero index of the die roll. </param>
        /// <returns> True if the die roll will be kept; false otherwise. </returns>
        public bool WillKeep(int die)
        {
            return roller.WillKeep(die);
        }

        #endregion Public Methods

        #region Private Fields

        /// <summary>
        /// Current state of the game. 
        /// </summary>
        private AbstractGameState gameState;

        /// <summary>
        /// Manages die rolling. 
        /// </summary>
        private DiceRoller roller;

        /// <summary>
        /// Scores based on the current rolls. 
        /// </summary>
        private Dictionary<ScoringCategory, int> rollScores;

        /// <summary>
        /// Current game's score card. 
        /// </summary>
        private ScoreCard scoreCard;

        #endregion Private Fields
    }
}
