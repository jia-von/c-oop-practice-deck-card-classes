using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CardGame
{
    public class Deck
    {
        /*
            Create a “Deck” class that has a “Cards” property, which is a stack of cards, and the following methods: -- completed

            Shuffle() - will randomly reorder the deck

            Draw() - will draw the top card of the deck

            Folded() - will return a list of the cards in the stack that have folded corners, do not remove the cards from the stack
         */
        public Stack<Card> Cards { get; set; } // Remember that Stack is Last in First Out
        private static Random rng = new Random();// create rng

        public void Shuffle() //Shuffle() - will randomly reorder the deck
        {
            Cards = new Stack<Card>(Cards.OrderBy(x => rng.Next()));
        }

        public Card Draw()
        {
            return Cards.Pop();
        }

        public List<Card> Folded() //will return a LIST of the cards in the stack that have folded corners, do not remove the cards from the stack
        {
            List<Card> FoldedCorners = new List<Card>();

            foreach (Card card in Cards)
            {
                if (card.FoldedCorner)
                {
                    FoldedCorners.Add(card);
                }
            }
            return FoldedCorners;
        }

    }
}