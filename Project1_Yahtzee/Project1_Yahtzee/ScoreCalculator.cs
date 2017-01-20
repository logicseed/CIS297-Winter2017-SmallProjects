// Marc King - mjking@umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System.Collections.Generic;
using System.Linq;

namespace Project1_Yahtzee
{
    /// <summary>
    /// Calculates scores based on provided dice rolls or existing score cards.
    /// </summary>
    public static class ScoreCalculator
    {
        #region Constants

        private const int BONUS_REQUIREMENT = 63;
        private const int BONUS_SCORE = 35;
        private const int THREE_OF_A_KIND_COUNT = 3;
        private const int FOUR_OF_A_KIND_COUNT = 4;
        private const int YAHTZEE_COUNT = 5;
        private const int YAHTZEE_SCORE = 50;
        private const int FULL_HOUSE_SCORE = 25;
        private const int SMALL_STRAIGHT_SCORE = 30;
        private const int LARGE_STRAIGHT_SCORE = 40;
        private const int MAX_SMALL_STRAIGHT_INDEX = 2;
        private const int MAX_LARGE_STRAIGHT_INDEX = 1;

        #endregion Constants

        #region Public Methods

        /// <summary>
        /// Calculates all of the scoring categories except for the upper section bonus.
        /// </summary>
        /// <param name="dice">A list of dice rolls sorted in ascending order.</param>
        /// <returns>A dictionary of score categories and their respective scores.</returns>
        /// <remarks>
        /// This isn't the most efficient way of doing this because we're calculating scores that
        /// may have already been selected in the scorecard, but in this case increasing efficiency
        /// would require increasing coupling. This way, the scoring calculator doesn't need to 
        /// know anything about the rest of the program.
        /// </remarks>
        public static Dictionary<ScoringCategory, int> CalculateDice(List<int> dice)
        {
            var scores = new Dictionary<ScoringCategory, int>();

            scores.Add(ScoringCategory.Aces,          CalculateAces(dice));
            scores.Add(ScoringCategory.Twos,          CalculateTwos(dice));
            scores.Add(ScoringCategory.Threes,        CalculateThrees(dice));
            scores.Add(ScoringCategory.Fours,         CalculateFours(dice));
            scores.Add(ScoringCategory.Fives,         CalculateFives(dice));
            scores.Add(ScoringCategory.Sixes,         CalculateSixes(dice));
            scores.Add(ScoringCategory.ThreeOfAKind,  CalculateThreeOfAKind(dice));
            scores.Add(ScoringCategory.FourOfAKind,   CalculateFourOfAKind(dice));
            scores.Add(ScoringCategory.FullHouse,     CalculateFullHouse(dice));
            scores.Add(ScoringCategory.SmallStraight, CalculateSmallStraight(dice));
            scores.Add(ScoringCategory.LargeStraight, CalculateLargeStraight(dice));
            scores.Add(ScoringCategory.Yahtzee,       CalculateYahtzee(dice));
            scores.Add(ScoringCategory.Chance,        CalculateChance(dice));

            return scores;
        }

        /// <summary>
        /// Calculates the bonus score for the upper section.
        /// </summary>
        /// <param name="scores">Dictionary of scores used to calculate the bonus.</param>
        /// <returns>The bonus points earned by the provided scores.</returns>
        public static int CalculateBonus(Dictionary<ScoringCategory, int> scores)
        {
            var upperSectionScore = scores[ScoringCategory.Aces]
                                  + scores[ScoringCategory.Twos]
                                  + scores[ScoringCategory.Threes]
                                  + scores[ScoringCategory.Fours]
                                  + scores[ScoringCategory.Fives]
                                  + scores[ScoringCategory.Sixes];
            
            if (upperSectionScore >= BONUS_REQUIREMENT)
            {
                return BONUS_SCORE;
            }
            else
            {
                return 0;
            }
        }

        #endregion Public Methods

        #region Private Methods

        private static int CalculateUpperSectionCategory(List<int> dice, int face)
        {
            var faces = dice.FindAll(die => die == face);
            return faces.Count * face;
        }

        private static int CalculateAces(List<int> dice)
        {
            return CalculateUpperSectionCategory(dice, (int)ScoringCategory.Aces);
        }

        private static int CalculateTwos(List<int> dice)
        {
            return CalculateUpperSectionCategory(dice, (int)ScoringCategory.Twos);
        }

        private static int CalculateThrees(List<int> dice)
        {
            return CalculateUpperSectionCategory(dice, (int)ScoringCategory.Threes);
        }

        private static int CalculateFours(List<int> dice)
        {
            return CalculateUpperSectionCategory(dice, (int)ScoringCategory.Fours);
        }

        private static int CalculateFives(List<int> dice)
        {
            return CalculateUpperSectionCategory(dice, (int)ScoringCategory.Fives);
        }

        private static int CalculateSixes(List<int> dice)
        {
            return CalculateUpperSectionCategory(dice, (int)ScoringCategory.Sixes);
        }

        private static int CalculateCountOfAKind(List<int> dice, int count)
        {
            foreach (var face in dice)
            {
                var faces = dice.FindAll(die => die == face);
                if (faces.Count >= count)
                {
                    return dice.Sum();
                }
            }
            return 0;
        }

        private static int CalculateThreeOfAKind(List<int> dice)
        {
            return CalculateCountOfAKind(dice, THREE_OF_A_KIND_COUNT);
        }

        private static int CalculateFourOfAKind(List<int> dice)
        {
            return CalculateCountOfAKind(dice, FOUR_OF_A_KIND_COUNT);
        }

        /// Three of one face and two of another; worth 25 points.
        private static int CalculateFullHouse(List<int> dice)
        {
            var bottomFaces = dice.FindAll(die => die == dice[0]);
            var topFaces = dice.FindAll(die => die == dice[dice.Count - 1]);

            if ((bottomFaces.Count == 2 && topFaces.Count == 3)
                || (bottomFaces.Count == 3 && topFaces.Count == 2))
            {
                return FULL_HOUSE_SCORE;
            }
            else
            {
                return 0;
            }
        }

        /// Four sequential faces; worth 30 points. (e.g. 1-2-3-4, 2-3-4-5, 3-4-5-6)
        private static int CalculateSmallStraight(List<int> dice)
        {
            for (int index = 0; index <= MAX_SMALL_STRAIGHT_INDEX; index++)
            {
                if (dice[index + 1] == dice[index] + 1 &&
                    dice[index + 2] == dice[index] + 2 &&
                    dice[index + 3] == dice[index] + 3)
                {
                    return SMALL_STRAIGHT_SCORE;
                }  
            }
            return 0;
        }

        /// Five sequential faces; worth 40 points. (e.g. 1-2-3-4-5, 2-3-4-5-6)
        private static int CalculateLargeStraight(List<int> dice)
        {
            for (int index = 0; index <= MAX_LARGE_STRAIGHT_INDEX; index++)
            {
                if (dice[index + 1] == dice[index] + 1 &&
                    dice[index + 2] == dice[index] + 2 &&
                    dice[index + 3] == dice[index] + 3 &&
                    dice[index + 4] == dice[index] + 4)
                {
                    return LARGE_STRAIGHT_SCORE;
                }
            }
            return 0;
        }

        /// All five dice show the same face; worth 50 points.
        private static int CalculateYahtzee(List<int> dice)
        {
            if (CalculateCountOfAKind(dice, YAHTZEE_COUNT) > 0)
            {
                return YAHTZEE_SCORE;
            }
            else
            {
                return 0;
            }
        }

        /// Sum of all dice with any combination.
        private static int CalculateChance(List<int> dice)
        {
            return dice.Sum();
        }

        #endregion Private Methods
    }
}