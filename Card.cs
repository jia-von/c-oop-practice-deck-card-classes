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
        private string _suit;
        public string Suit
        {
            get
            {
                return _suit;
            }
            set
            {
                if (value == "Joker")
                {
                    _suit = null;
                }
                else
                {
                    _suit = value;
                }
            }
        }
        public string Number { get; set; }
        public bool FoldedCorner { get; set; }

        public Card() //Default constructor
        {
            Brand = "Bicycle";
            Suit = "Spade";
            Number = "Ace";
            FoldedCorner = false; // False equals that the card looks brand new and not folded


        }
    }


}
