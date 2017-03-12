// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System.Collections.Generic;
using System.Drawing;

namespace TexasHoldem
{
    /// <summary>
    /// Provides easy access to the appropriate card image for use in the GUI.
    /// 
    /// This should allow us to write something like:
    /// 
    /// something = cardImage[card.suit, card.face];
    /// 
    /// </summary>
    public class CardImage
    {
        private static Dictionary<CardSuit, Dictionary<CardFace, Bitmap>> images;

        // Singleton
        private static CardImage instance;
        private CardImage() { InitializeImages(); }
        public static CardImage Instance
        {
            get
            {
                // Lazy loading
                if (instance == null)
                {
                    instance = new CardImage();
                }
                return instance;
            }
        }

        private static void InitializeImages()
        {
            // Setup card images
            images = new Dictionary<CardSuit, Dictionary<CardFace, Bitmap>>();

            images.Add(CardSuit.Clubs,    new Dictionary<CardFace, Bitmap>());
            images.Add(CardSuit.Diamonds, new Dictionary<CardFace, Bitmap>());
            images.Add(CardSuit.Hearts,   new Dictionary<CardFace, Bitmap>());
            images.Add(CardSuit.Spades,   new Dictionary<CardFace, Bitmap>());

            // Clubs
            images[CardSuit.Clubs].Add(CardFace.Back,  Properties.Resources.Back);
            images[CardSuit.Clubs].Add(CardFace.Ace,   Properties.Resources.C01);
            images[CardSuit.Clubs].Add(CardFace.Two,   Properties.Resources.C02);
            images[CardSuit.Clubs].Add(CardFace.Three, Properties.Resources.C03);
            images[CardSuit.Clubs].Add(CardFace.Four,  Properties.Resources.C04);
            images[CardSuit.Clubs].Add(CardFace.Five,  Properties.Resources.C05);
            images[CardSuit.Clubs].Add(CardFace.Six,   Properties.Resources.C06);
            images[CardSuit.Clubs].Add(CardFace.Seven, Properties.Resources.C07);
            images[CardSuit.Clubs].Add(CardFace.Eight, Properties.Resources.C08);
            images[CardSuit.Clubs].Add(CardFace.Nine,  Properties.Resources.C09);
            images[CardSuit.Clubs].Add(CardFace.Ten,   Properties.Resources.C10);
            images[CardSuit.Clubs].Add(CardFace.Jack,  Properties.Resources.C11);
            images[CardSuit.Clubs].Add(CardFace.Queen, Properties.Resources.C12);
            images[CardSuit.Clubs].Add(CardFace.King,  Properties.Resources.C13);

            // Diamonds
            images[CardSuit.Diamonds].Add(CardFace.Back,  Properties.Resources.Back);
            images[CardSuit.Diamonds].Add(CardFace.Ace,   Properties.Resources.D01);
            images[CardSuit.Diamonds].Add(CardFace.Two,   Properties.Resources.D02);
            images[CardSuit.Diamonds].Add(CardFace.Three, Properties.Resources.D03);
            images[CardSuit.Diamonds].Add(CardFace.Four,  Properties.Resources.D04);
            images[CardSuit.Diamonds].Add(CardFace.Five,  Properties.Resources.D05);
            images[CardSuit.Diamonds].Add(CardFace.Six,   Properties.Resources.D06);
            images[CardSuit.Diamonds].Add(CardFace.Seven, Properties.Resources.D07);
            images[CardSuit.Diamonds].Add(CardFace.Eight, Properties.Resources.D08);
            images[CardSuit.Diamonds].Add(CardFace.Nine,  Properties.Resources.D09);
            images[CardSuit.Diamonds].Add(CardFace.Ten,   Properties.Resources.D10);
            images[CardSuit.Diamonds].Add(CardFace.Jack,  Properties.Resources.D11);
            images[CardSuit.Diamonds].Add(CardFace.Queen, Properties.Resources.D12);
            images[CardSuit.Diamonds].Add(CardFace.King,  Properties.Resources.D13);

            // Hearts
            images[CardSuit.Hearts].Add(CardFace.Back,  Properties.Resources.Back);
            images[CardSuit.Hearts].Add(CardFace.Ace,   Properties.Resources.H01);
            images[CardSuit.Hearts].Add(CardFace.Two,   Properties.Resources.H02);
            images[CardSuit.Hearts].Add(CardFace.Three, Properties.Resources.H03);
            images[CardSuit.Hearts].Add(CardFace.Four,  Properties.Resources.H04);
            images[CardSuit.Hearts].Add(CardFace.Five,  Properties.Resources.H05);
            images[CardSuit.Hearts].Add(CardFace.Six,   Properties.Resources.H06);
            images[CardSuit.Hearts].Add(CardFace.Seven, Properties.Resources.H07);
            images[CardSuit.Hearts].Add(CardFace.Eight, Properties.Resources.H08);
            images[CardSuit.Hearts].Add(CardFace.Nine,  Properties.Resources.H09);
            images[CardSuit.Hearts].Add(CardFace.Ten,   Properties.Resources.H10);
            images[CardSuit.Hearts].Add(CardFace.Jack,  Properties.Resources.H11);
            images[CardSuit.Hearts].Add(CardFace.Queen, Properties.Resources.H12);
            images[CardSuit.Hearts].Add(CardFace.King,  Properties.Resources.H13);

            // Spades
            images[CardSuit.Spades].Add(CardFace.Back,  Properties.Resources.Back);
            images[CardSuit.Spades].Add(CardFace.Ace,   Properties.Resources.S01);
            images[CardSuit.Spades].Add(CardFace.Two,   Properties.Resources.S02);
            images[CardSuit.Spades].Add(CardFace.Three, Properties.Resources.S03);
            images[CardSuit.Spades].Add(CardFace.Four,  Properties.Resources.S04);
            images[CardSuit.Spades].Add(CardFace.Five,  Properties.Resources.S05);
            images[CardSuit.Spades].Add(CardFace.Six,   Properties.Resources.S06);
            images[CardSuit.Spades].Add(CardFace.Seven, Properties.Resources.S07);
            images[CardSuit.Spades].Add(CardFace.Eight, Properties.Resources.S08);
            images[CardSuit.Spades].Add(CardFace.Nine,  Properties.Resources.S09);
            images[CardSuit.Spades].Add(CardFace.Ten,   Properties.Resources.S10);
            images[CardSuit.Spades].Add(CardFace.Jack,  Properties.Resources.S11);
            images[CardSuit.Spades].Add(CardFace.Queen, Properties.Resources.S12);
            images[CardSuit.Spades].Add(CardFace.King,  Properties.Resources.S13);
        }

        public Bitmap this[CardSuit suit, CardFace face]
        {
            get
            {
                return images[suit][face];
            }
        }
    }
}
