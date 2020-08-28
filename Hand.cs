using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Hand
    {
        //Create a “Hand” class that has a “Cards” property, which is a list of cards. 
        public List<Card> Cards { get; set; } // List is are indexed like an array

        public Hand()
        {
            Cards = new List<Card>(); //list one card called Diamond Ace
            string[] numbers = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            for (int i = 0; i < numbers.Length; i++)
            {
                //link: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1
                Cards.Add(new Card() { Brand = "Bicycle", Suit = "Spade", Number = numbers[i], FoldedCorner = false });
                Cards.Add(new Card() { Brand = "Bicycle", Suit = "Clubs", Number = numbers[i], FoldedCorner = false });
                Cards.Add(new Card() { Brand = "Bicycle", Suit = "Diamond", Number = numbers[i], FoldedCorner = false });
                Cards.Add(new Card() { Brand = "Bicycle", Suit = "Hearts", Number = numbers[i], FoldedCorner = false });
            }

        }

    }
}

