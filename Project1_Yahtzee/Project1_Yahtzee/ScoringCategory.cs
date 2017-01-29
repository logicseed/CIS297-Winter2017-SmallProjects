// Marc King - mjking@umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

namespace Project1_Yahtzee
{
    /// <summary>
    /// The various methods of scoring a roll of the dice.
    /// </summary>
    /// <remarks>A score card can only contain a single score for each of these categories for a single game.</remarks>
    public enum ScoringCategory
    {
        /// <summary>
        /// Additional 35 points if the rest of the upper section totals 63 or more points.
        /// </summary>
        Bonus,
        /// <summary>
        /// Sum of dice showing face 1.
        /// </summary>
        Aces,
        /// <summary>
        /// Sum of dice showing face 2.
        /// </summary>
        Twos,
        /// <summary>
        /// Sum of dice showing face 3.
        /// </summary>
        Threes,
        /// <summary>
        /// Sum of dice showing face 4.
        /// </summary>
        Fours,
        /// <summary>
        /// Sum of dice showing face 5.
        /// </summary>
        Fives,
        /// <summary>
        /// Sum of dice showing face 6.
        /// </summary>
        Sixes,
        /// <summary>
        /// Sum all dice if at least three show the same face.
        /// </summary>
        ThreeOfAKind,
        /// <summary>
        /// Sum all dice if at least four show the same face.
        /// </summary>
        FourOfAKind,
        /// <summary>
        /// Three of one face and two of another; worth 25 points.
        /// </summary>
        FullHouse,
        /// <summary>
        /// Four sequential faces; worth 30 points. (e.g. 1-2-3-4, 2-3-4-5, 3-4-5-6)
        /// </summary>
        SmallStraight,
        /// <summary>
        /// Five sequential faces; worth 40 points. (e.g. 1-2-3-4-5, 2-3-4-5-6)
        /// </summary>
        LargeStraight,
        /// <summary>
        /// All five dice show the same face; worth 50 points.
        /// </summary>
        Yahtzee,
        /// <summary>
        /// Sum of all dice with any combination.
        /// </summary>
        Chance
    }
}