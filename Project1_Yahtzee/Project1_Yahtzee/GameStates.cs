// Marc King - mjking@umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System.Collections.Generic;

namespace Project1_Yahtzee
{
    /// <summary>
    /// Abstract state for implementation of state pattern for game states. 
    /// </summary>
    public abstract class AbstractGameState
    {
        #region Public Methods

        /// <summary>
        /// </summary>
        /// <param name="game"> Reference to game manager. </param>
        /// <param name="scoreCard"> Reference to current game's score card. </param>
        /// <param name="category"> Score category to accept. </param>
        /// <param name="scores"> Reference to current turn's dice scores. </param>
        /// <returns></returns>
        public virtual bool AcceptScore(GameManager game, ScoreCard scoreCard,
                                ScoringCategory category, Dictionary<ScoringCategory, int> scores)
        {
            scoreCard.AcceptScore(category, scores[category]);
            game.NextState(new FirstMoveState());
            return true;
        }

        /// <summary>
        /// Attempts to roll dice that are not marked to be kept. 
        /// </summary>
        /// <param name="game"> Reference to game manager. </param>
        /// <param name="roller"> Reference to current game's dice roller. </param>
        /// <returns> True if the dice were rolled; false otherwise. </returns>
        public virtual bool RollDice(GameManager game, DiceRoller roller)
        {
            roller.RollDice();

            switch (roller.RollsRemaining)
            {
                case 2:
                    game.NextState(new SecondMoveState());
                    break;

                case 1:
                    game.NextState(new ThirdMove());
                    break;

                default:
                    game.NextState(new FinalMoveState());
                    break;
            }

            return true;
        }

        /// <summary>
        /// Marks the die roll to be kept through rerolls. 
        /// </summary>
        /// <param name="game"> Reference to game manager. </param>
        /// <param name="roller"> Reference to current game's dice roller. </param>
        /// <param name="die"> Index of die to set the keep. </param>
        /// <param name="keep"> If the die should be kept. </param>
        /// <returns></returns>
        public virtual bool SetWillKeep(GameManager game, DiceRoller roller, int die, bool keep)
        {
            roller.KeepDie(die, keep);
            return true;
        }

        #endregion Public Methods
    }

    /// <summary>
    /// The final move of a turn. Player can only accept a score. 
    /// </summary>
    public class FinalMoveState : AbstractGameState
    {
        #region Public Methods

        public override bool RollDice(GameManager game, DiceRoller diceRoller)
        {
            return false;
        }

        public override bool SetWillKeep(GameManager game, DiceRoller roller, int die, bool keep)
        {
            return false;
        }

        #endregion Public Methods
    }

    /// <summary>
    /// The first move of a turn. Player can only roll dice. 
    /// </summary>
    public class FirstMoveState : AbstractGameState
    {
        #region Public Methods

        public override bool AcceptScore(GameManager game, ScoreCard scoreCard,
                                ScoringCategory category, Dictionary<ScoringCategory, int> scores)
        {
            return false;
        }

        public override bool SetWillKeep(GameManager game, DiceRoller roller, int die, bool keep)
        {
            return false;
        }

        #endregion Public Methods
    }

    /// <summary>
    /// The second move of a turn. 
    /// </summary>
    public class SecondMoveState : AbstractGameState
    {
        // SecondMove has all default behaviour
    }

    /// <summary>
    /// The third move of a turn. 
    /// </summary>
    public class ThirdMove : AbstractGameState
    {
        // ThirdMove has all default behaviour
    }
}
