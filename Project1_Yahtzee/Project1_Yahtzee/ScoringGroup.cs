// Marc King - mjking@umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

namespace Project1_Yahtzee
{
    /// <summary>
    /// The various scoring categories are placed into two major groups.
    /// </summary>
    public enum ScoringGroup
    {
        /// <summary>
        /// The upper section is for scoring categories that contain rolls that consist of summing the number of occurances of a specific die face, and a bonus score if a minimum of 63 points are scored in the upper section.
        /// </summary>
        UpperSection,
        /// <summary>
        /// The lower section is for scoring categories that contain rolls with various special combinations of die faces; many of which resemble poker hands.
        /// </summary>
        LowerSection
    }
}