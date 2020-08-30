using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Card
    {
        /*
         *  Create a “Card” class that has the following properties: -- Completed
         *  
            Brand (Bicycle, Bee, etc) -- Completed

            Suit (Diamonds, Hearts, Spades, Clubs) -- Completed

            Number (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King, Joker) -- Completed

            Joker must have a null suit, all others must have a suit -- Completed

            Folded Corner (true / false) -- Completed

         */
        public string Brand { get; set; }
        public enum SuitValue
        {
            Spades,
            Clubs, 
            Hearts,
            Diamonds
        }
        public SuitValue? Suit { get; set; }
        public enum NumberValue
        {
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
            Joker
        }

        private NumberValue _number;
        public NumberValue Number
        {
            get
            {
                return _number;
            }
            set
            {
                // If it's going to be a joker and still has a suit:
                if (value == NumberValue.Joker && Suit != null)
                {
                    // Allow the set to go through, but force suit to be null.
                    _number = value;
                    Suit = null;
                }
                // If it's going to be something other than joker and does not have a suit:
                else if (value != NumberValue.Joker && Suit == null)
                {
                    // Allow the set to go through, but force the suit to be spades (or any other suit really, just has to have one).
                    _number = value;
                    Suit = SuitValue.Spades;
                }
                // If the suit is set, and the value is not joker.
                else
                {
                    _number = value;
                }
            }
        }
        public bool FoldedCorner { get; set; }

    }
}
