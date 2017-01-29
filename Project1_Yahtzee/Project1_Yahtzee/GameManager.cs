// Marc King - mjking@umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1_Yahtzee
{
    public class GameManager
    {
        private AbstractGameState gameState;
        private ScoreCard scoreCard;
        private DiceRoller roller;
        private Dictionary<ScoringCategory, int> rollScores;

        public Dictionary<ScoringCategory, int> Scores
        {
            get
            {
                return scoreCard.Scores;
            }
        }

        public List<int> Rolls
        {
            get
            {
                return roller.Dice;
            }
        }

        public Dictionary<ScoringCategory, int> RollScores
        {
            get
            {
                return rollScores;
            }
        }

        public int RollsRemaining
        {
            get
            {
                return roller.RollsRemaining;
            }
        }

        public GameManager()
        {
            gameState = new FirstMoveState();
            scoreCard = new ScoreCard();
            roller = new DiceRoller();
            rollScores = new Dictionary<ScoringCategory, int>(scoreCard.Scores);
        }

        /// <summary>
        /// Changes the state of the game
        /// </summary>
        /// <param name="gameState"></param>
        public void NextState(AbstractGameState gameState)
        {
            this.gameState = gameState;
        }

        public bool RollDice()
        {
            if (gameState.RollDice(this, roller) == true)
            {
                rollScores = ScoreCalculator.CalculateDice(roller.SortedDice);
                rollScores.Add(ScoringCategory.Bonus, ScoreCalculator.CalculateBonus(scoreCard.Scores));
                return true;
            }
            return false;
        }

        public bool KeepDieRoll(int die, bool keep)
        {
            return gameState.SetKeepDieRoll(this, roller, die, keep);
        }

        public bool AcceptScore(ScoringCategory category)
        {
            return gameState.AcceptScore(this, scoreCard, roller, category, rollScores);
        }

        public bool IsLocked(int die)
        {
            return roller.WillKeep(die);
        }

        public bool IsLocked(ScoringCategory category)
        {
            return scoreCard.IsScoreAccepted(category);
        }

        public bool KeepScore(ScoringCategory category)
        {
            return scoreCard.IsScoreAccepted(category);
        }
    }
}