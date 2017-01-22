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

        /// <summary>
        /// Number of points in the upper section required to earn the bonus.
        /// </summary>
        private const int BONUS_REQUIREMENT = 63;

        /// <summary>
        /// Amount of points earned for the upper section bonus.
        /// </summary>
        private const int BONUS_SCORE = 35;

        /// <summary>
        /// Number of dice with the same face required for the three of a kind score.
        /// </summary>
        private const int THREE_OF_A_KIND_COUNT = 3;

        /// <summary>
        /// Number of dice with the same face required for the four of a kind score.
        /// </summary>
        private const int FOUR_OF_A_KIND_COUNT = 4;

        /// <summary>
        /// Number of dice with the same face required for the Yahtzee score.
        /// </summary>
        private const int YAHTZEE_COUNT = 5;

        /// <summary>
        /// Amount of points earned for the Yahtzee score.
        /// </summary>
        private const int YAHTZEE_SCORE = 50;

        /// <summary>
        /// Amount of points earned for the full house score.
        /// </summary>
        private const int FULL_HOUSE_SCORE = 25;

        /// <summary>
        /// Amount of points earned for the small straight score.
        /// </summary>
        private const int SMALL_STRAIGHT_SCORE = 30;

        /// <summary>
        /// Amount of points earned for the large straight score.
        /// </summary>
        private const int LARGE_STRAIGHT_SCORE = 40;

        /// <summary>
        /// Of the five dice, this is the maximum index the first die of a small straight can have
        /// and still leave room to complete the small straight.
        /// </summary>
        private const int MAX_SMALL_STRAIGHT_INDEX = 1;

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
        /// 
        /// We could potentially have the GUI call only the scoring methods it needs, but then that
        /// class would have to know a lot about this one.
        /// </remarks>
        public static Dictionary<ScoringCategory, int> CalculateDice(List<int> dice)
        {
            var scores = new Dictionary<ScoringCategory, int>();

            scores.Add(ScoringCategory.Aces, CalculateAces(dice));
            scores.Add(ScoringCategory.Twos, CalculateTwos(dice));
            scores.Add(ScoringCategory.Threes, CalculateThrees(dice));
            scores.Add(ScoringCategory.Fours, CalculateFours(dice));
            scores.Add(ScoringCategory.Fives, CalculateFives(dice));
            scores.Add(ScoringCategory.Sixes, CalculateSixes(dice));
            scores.Add(ScoringCategory.ThreeOfAKind, CalculateThreeOfAKind(dice));
            scores.Add(ScoringCategory.FourOfAKind, CalculateFourOfAKind(dice));
            scores.Add(ScoringCategory.FullHouse, CalculateFullHouse(dice));
            scores.Add(ScoringCategory.SmallStraight, CalculateSmallStraight(dice));
            scores.Add(ScoringCategory.LargeStraight, CalculateLargeStraight(dice));
            scores.Add(ScoringCategory.Yahtzee, CalculateYahtzee(dice));
            scores.Add(ScoringCategory.Chance, CalculateChance(dice));

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

        /// <summary>
        /// Calculate the upper section score for a specific die face for a dice roll. The score is
        /// the sum of all the die with the specified face.
        /// </summary>
        /// <param name="dice">Sorted list of the die faces that have been rolled.</param>
        /// <param name="face">Die face to calculate the score for.</param>
        /// <returns>The calculated score for the die face.</returns>
        private static int CalculateUpperSectionCategory(List<int> dice, int face)
        {
            var faces = dice.FindAll(die => die == face);
            return faces.Count * face;
        }

        /// <summary>
        /// Calculate the upper section aces score. The score is the sum of all the dice with a one
        /// showing.
        /// </summary>
        /// <param name="dice">Sorted list of the die faces that have been rolled.</param>
        /// <returns>The calculated aces score.</returns>
        private static int CalculateAces(List<int> dice)
        {
            return CalculateUpperSectionCategory(dice, (int)ScoringCategory.Aces);
        }

        /// <summary>
        /// Calculate the upper section twos score. The score is the sum of all the dice with a two
        /// showing.
        /// </summary>
        /// <param name="dice">Sorted list of the die faces that have been rolled.</param>
        /// <returns>The calculated twos score.</returns>
        private static int CalculateTwos(List<int> dice)
        {
            return CalculateUpperSectionCategory(dice, (int)ScoringCategory.Twos);
        }

        /// <summary>
        /// Calculate the upper section threes score. The score is the sum of all the dice with a
        /// three showing.
        /// </summary>
        /// <param name="dice">Sorted list of the die faces that have been rolled.</param>
        /// <returns>The calculated threes score.</returns>
        private static int CalculateThrees(List<int> dice)
        {
            return CalculateUpperSectionCategory(dice, (int)ScoringCategory.Threes);
        }

        /// <summary>
        /// Calculate the upper section fours score. The score is the sum of all the dice with a
        /// four showing.
        /// </summary>
        /// <param name="dice">Sorted list of the die faces that have been rolled.</param>
        /// <returns>The calculated fours score.</returns>
        private static int CalculateFours(List<int> dice)
        {
            return CalculateUpperSectionCategory(dice, (int)ScoringCategory.Fours);
        }

        /// <summary>
        /// Calculate the upper section fives score. The score is the sum of all the dice with a
        /// five showing.
        /// </summary>
        /// <param name="dice">Sorted list of the die faces that have been rolled.</param>
        /// <returns>The calculated fives score.</returns>
        private static int CalculateFives(List<int> dice)
        {
            return CalculateUpperSectionCategory(dice, (int)ScoringCategory.Fives);
        }

        /// <summary>
        /// Calculate the upper section sixes score. The score is the sum of all the dice with a
        /// six showing.
        /// </summary>
        /// <param name="dice">Sorted list of the die faces that have been rolled.</param>
        /// <returns>The calculated sixes score.</returns>
        private static int CalculateSixes(List<int> dice)
        {
            return CalculateUpperSectionCategory(dice, (int)ScoringCategory.Sixes);
        }

        /// <summary>
        /// Calculates the score for a roll containing a certain number of dice showing the same
        /// face. The score is the sum of all of the dice if the minimum count is met.
        /// </summary>
        /// <param name="dice">Sorted list of the die faces that have been rolled.</param>
        /// <param name="count">Number of dice required to be showing the same face.</param>
        /// <returns>The sum of all the die faces if requirements are met, or zero if not.</returns>
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

        /// <summary>
        /// Calculates the score for rolling a three of a kind. The score is the sum of all of the
        /// dice if there are three dice with the same face.
        /// </summary>
        /// <param name="dice">Sorted list of the die faces that have been rolled.</param>
        /// <returns>The sum of all the die faces if three contain the same face.</returns>
        private static int CalculateThreeOfAKind(List<int> dice)
        {
            return CalculateCountOfAKind(dice, THREE_OF_A_KIND_COUNT);
        }

        /// <summary>
        /// Calculates the score for rolling a four of a kind. The score is the sum of all of the
        /// dice if there are four dice with the same face.
        /// </summary>
        /// <param name="dice">Sorted list of the die faces that have been rolled.</param>
        /// <returns>The sum of all the die faces if four contain the same face.</returns>
        private static int CalculateFourOfAKind(List<int> dice)
        {
            return CalculateCountOfAKind(dice, FOUR_OF_A_KIND_COUNT);
        }

        /// <summary>
        /// Calculates the score for rolling a full house; two of one face and three of another.
        /// </summary>
        /// <param name="dice">Sorted list of the die faces that have been rolled.</param>
        /// <returns>The full house score if the requirements are met; zero otherwise.</returns>
        private static int CalculateFullHouse(List<int> dice)
        {
            // We can assume that if there is a full house then the lowest index will contain one
            // of the faces and the highest index with contain the other.
            var bottomFaces = dice.FindAll(die => die == dice[0]);
            var topFaces = dice.FindAll(die => die == dice[dice.Count - 1]);

            if ((bottomFaces.Count == 2 && topFaces.Count == 3) ||
                (bottomFaces.Count == 3 && topFaces.Count == 2))
            {
                return FULL_HOUSE_SCORE;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Calculates the score for rolling a small straight (four sequential dice).
        /// </summary>
        /// <param name="dice">Sorted list of the die faces that have been rolled.</param>
        /// <returns>The small straight score if the requirements are met; zero otherwise.</returns>
        private static int CalculateSmallStraight(List<int> dice)
        {
            // Can only be faces 1-2-3-4, 2-3-4-5, or 3-4-5-6
            // Can only be indices 0-1-2-3 or 1-2-3-4
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

        /// <summary>
        /// Calculates the score for rolling a large straight (five sequential dice).
        /// </summary>
        /// <param name="dice">Sorted list of the die faces that have been rolled.</param>
        /// <returns>The large straight score if the requirements are met; zero otherwise.</returns>
        private static int CalculateLargeStraight(List<int> dice)
        {
            // Can only be faces 1-2-3-4-5 or 2-3-4-5-6
            if (dice[1] == dice[0] + 1 &&
                dice[2] == dice[0] + 2 &&
                dice[3] == dice[0] + 3 &&
                dice[4] == dice[0] + 4)
            {
                return LARGE_STRAIGHT_SCORE;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Calculates the score for rolling a Yahtzee (all five dice with the same face).
        /// </summary>
        /// <param name="dice">Sorted list of the die faces that have been rolled.</param>
        /// <returns>The Yahtzee score if the requirement is met; zero otherwise.</returns>
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

        /// <summary>
        /// Calculates the score for taking a chance on the roll.
        /// </summary>
        /// <param name="dice">List of the die faces that have been rolled.</param>
        /// <returns>Sum of all the die faces.</returns>
        private static int CalculateChance(List<int> dice)
        {
            return dice.Sum();
        }

        #endregion Private Methods
    }
}