using System;
using System.Collections.Generic;
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
        public Stack<Card> Cards { get; set; }

        public Deck()//Default deck of cards created. 
        {
            Cards = new Stack<Card>(); // Creation of new deck of cards.
        }
        public void Shuffle()
        {

        }

        public void Draw()
        {

        }

        public void Folded () //will return a LIST of the cards in the stack that have folded corners, do not remove the cards from the stack
        {

        }


    }
}
