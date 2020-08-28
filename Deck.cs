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
        public Stack<Card> Cards { get; set; } // Remember that Stack is Last in First Out
        Hand hand = new Hand();
        public Deck()//Default deck of cards created with 52 cards
        {
            Cards = new Stack<Card>(); // Creation of new deck of cards.
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                Cards.Push(hand.Cards[i]); // push the list of card from Class hand into the Stack
            }
        }

        public void Shuffle() //Shuffle() - will randomly reorder the deck
        {
            //https://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-int-number
            Random rnd = new Random(); // create a randomizer variable
            int shuffle = rnd.Next(0, hand.Cards.Count + 1); // limit the randomizer between 0 to the list of cards

            Cards.Pop();
            Cards.Push(hand.Cards[shuffle]);
            hand.Cards.RemoveAt(shuffle);

        }

        public void Draw()
        {
            Cards.Pop();
        }

        public void Folded() //will return a LIST of the cards in the stack that have folded corners, do not remove the cards from the stack
        {

        }


    }
}