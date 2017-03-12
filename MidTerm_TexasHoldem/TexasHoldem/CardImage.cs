// Marc King - mjking @umich.edu
// CIS297 - Winter 2017 - Professor Eric Charnesky
// University of Michigan - Dearborn

using System.Collections.Generic;

namespace TexasHoldem
{
    /// <summary>
    /// Provides easy access to the appropriate card image for use in the GUI.
    /// The card 'images' are Unicode playing card characters.
    /// 
    /// This should allow us to write something like:
    /// 
    /// something = cardImage[card.Suit, card.Face];
    /// 
    /// </summary>
    public class CardImage
    {
        // This should really be a char instead of a string, but since the playing
        // cards are in the extended Unicode, they won't fit in a 16-bit char.
        private static Dictionary<CardSuit, Dictionary<CardFace, string>> images;

        // Singleton
        private static CardImage instance;
        private CardImage() { Initialize(); }
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

        /// <summary>
        /// Initializes the card image dictionaries.
        /// </summary>
        private static void Initialize()
        {
            // Setup card images
            images = new Dictionary<CardSuit, Dictionary<CardFace, string>>();

            images.Add(CardSuit.Clubs,    new Dictionary<CardFace, string>());
            images.Add(CardSuit.Diamonds, new Dictionary<CardFace, string>());
            images.Add(CardSuit.Hearts,   new Dictionary<CardFace, string>());
            images.Add(CardSuit.Spades,   new Dictionary<CardFace, string>());

            // Clubs
            images[CardSuit.Clubs].Add(CardFace.Back,  "🂠");
            images[CardSuit.Clubs].Add(CardFace.Ace,   "🃑");
            images[CardSuit.Clubs].Add(CardFace.Two,   "🃒");
            images[CardSuit.Clubs].Add(CardFace.Three, "🃓");
            images[CardSuit.Clubs].Add(CardFace.Four,  "🃔");
            images[CardSuit.Clubs].Add(CardFace.Five,  "🃕");
            images[CardSuit.Clubs].Add(CardFace.Six,   "🃖");
            images[CardSuit.Clubs].Add(CardFace.Seven, "🃗");
            images[CardSuit.Clubs].Add(CardFace.Eight, "🃘");
            images[CardSuit.Clubs].Add(CardFace.Nine,  "🃙");
            images[CardSuit.Clubs].Add(CardFace.Ten,   "🃚");
            images[CardSuit.Clubs].Add(CardFace.Jack,  "🃛");
            images[CardSuit.Clubs].Add(CardFace.Queen, "🃝");
            images[CardSuit.Clubs].Add(CardFace.King,  "🃞");

            // Diamonds
            images[CardSuit.Diamonds].Add(CardFace.Back,  "🂠");
            images[CardSuit.Diamonds].Add(CardFace.Ace,   "🃁");
            images[CardSuit.Diamonds].Add(CardFace.Two,   "🃂");
            images[CardSuit.Diamonds].Add(CardFace.Three, "🃃");
            images[CardSuit.Diamonds].Add(CardFace.Four,  "🃄");
            images[CardSuit.Diamonds].Add(CardFace.Five,  "🃅");
            images[CardSuit.Diamonds].Add(CardFace.Six,   "🃆");
            images[CardSuit.Diamonds].Add(CardFace.Seven, "🃇");
            images[CardSuit.Diamonds].Add(CardFace.Eight, "🃈");
            images[CardSuit.Diamonds].Add(CardFace.Nine,  "🃉");
            images[CardSuit.Diamonds].Add(CardFace.Ten,   "🃊");
            images[CardSuit.Diamonds].Add(CardFace.Jack,  "🃋");
            images[CardSuit.Diamonds].Add(CardFace.Queen, "🃍");
            images[CardSuit.Diamonds].Add(CardFace.King,  "🃎");

            // Hearts
            images[CardSuit.Hearts].Add(CardFace.Back,  "🂠");
            images[CardSuit.Hearts].Add(CardFace.Ace,   "🂱");
            images[CardSuit.Hearts].Add(CardFace.Two,   "🂲");
            images[CardSuit.Hearts].Add(CardFace.Three, "🂳");
            images[CardSuit.Hearts].Add(CardFace.Four,  "🂴");
            images[CardSuit.Hearts].Add(CardFace.Five,  "🂵");
            images[CardSuit.Hearts].Add(CardFace.Six,   "🂶");
            images[CardSuit.Hearts].Add(CardFace.Seven, "🂷");
            images[CardSuit.Hearts].Add(CardFace.Eight, "🂸");
            images[CardSuit.Hearts].Add(CardFace.Nine,  "🂹");
            images[CardSuit.Hearts].Add(CardFace.Ten,   "🂺");
            images[CardSuit.Hearts].Add(CardFace.Jack,  "🂻");
            images[CardSuit.Hearts].Add(CardFace.Queen, "🂽");
            images[CardSuit.Hearts].Add(CardFace.King,  "🂾");

            // Spades
            images[CardSuit.Spades].Add(CardFace.Back,  "🂠");
            images[CardSuit.Spades].Add(CardFace.Ace,   "🂡");
            images[CardSuit.Spades].Add(CardFace.Two,   "🂢");
            images[CardSuit.Spades].Add(CardFace.Three, "🂣");
            images[CardSuit.Spades].Add(CardFace.Four,  "🂤");
            images[CardSuit.Spades].Add(CardFace.Five,  "🂥");
            images[CardSuit.Spades].Add(CardFace.Six,   "🂦");
            images[CardSuit.Spades].Add(CardFace.Seven, "🂧");
            images[CardSuit.Spades].Add(CardFace.Eight, "🂨");
            images[CardSuit.Spades].Add(CardFace.Nine,  "🂩");
            images[CardSuit.Spades].Add(CardFace.Ten,   "🂪");
            images[CardSuit.Spades].Add(CardFace.Jack,  "🂫");
            images[CardSuit.Spades].Add(CardFace.Queen, "🂭");
            images[CardSuit.Spades].Add(CardFace.King,  "🂮");
        }

        public string this[CardSuit suit, CardFace face]
        {
            get
            {
                return images[suit][face];
            }
        }
    }
}
