using System;
using System.Collections.Generic;

namespace CardGame
{
    class Program
    {
        //Answer to he calss completed on August 28, 2020 by James Grieve
        //Create a new deck with a bunch of cards. 
        static void Main(string[] args)
        {
            Deck theDeck = new Deck()
            {
                Cards = new Stack<Card>()
            };
            
            foreach(Card.SuitValue suit in Enum.GetValues(typeof(Card.SuitValue)))
            {
                foreach(Card.NumberValue number in Enum.GetValues(typeof(Card.NumberValue)))
                {
                    theDeck.Cards.Push(new Card()
                    {
                        Suit = suit,
                        Number = number,
                        Brand = "Bicycle",
                        FoldedCorner = false //FoldedCorner is false because the card is brand new
                    });
                }
            }
            theDeck.Cards.Push(new Card()
            {
                Brand = "Bicycle",
                Number = Card.NumberValue.Joker,
                Suit = null,
                FoldedCorner = false
            });

            theDeck.Cards.Push(new Card()
            {
                Brand = "Bicycle",
                Number = Card.NumberValue.Joker,
                Suit = null,
                FoldedCorner = true
            });

            //foreach (Card i in theDeck.Cards)
            //{
            //    Console.WriteLine($"The {i.Number} of {i.Suit}");
            //}
        }// End of the main
    }
}
