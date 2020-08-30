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
        public string Suit { get; set; }
        public string _number;
        public string Number {
            get
            {
                return _number;
            }
            set
            {
                if(value == "Joker")
                {
                    _number = "Joker";
                    Suit = null;
                }
                else
                {
                    _number = value;
                }
            } 
        }

        public bool FoldedCorner { get; set; }

        public Card() //Default constructor
        {
            Brand = "Default Brand";
            Suit = "Default Suit";
            Number = "Default Number";
            FoldedCorner = false; // False equals that the card looks brand new and not folded
        }
    }
}
