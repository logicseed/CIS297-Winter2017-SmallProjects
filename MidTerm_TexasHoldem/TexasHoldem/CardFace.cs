// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

namespace TexasHoldem
{
    /// <summary>
    /// Represents the face of a playing card.
    /// </summary>
    public enum CardFace
    {
        Back, // Sort of an invalid value since it isn't a face.
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        TotalFaces = King
    }
}
