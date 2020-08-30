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
            string[] suits = new string[] { "Heart", "Diamonds", "Spade", "Clubs"}; // Create an array of suit for my deck of cards
            
            //Create an array of numbers for the cards. 
            string[] numbers = new string[] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" }; 
            
            foreach(string suit in suits)
            {
                foreach(string number in numbers)
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
                Number = "Joker",
                Suit = null,
                FoldedCorner = false
            });

            theDeck.Cards.Push(new Card()
            {
                Brand = "Bicycle",
                Number = "Joker",
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
