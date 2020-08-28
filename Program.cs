using System;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            Console.WriteLine($"The card you are looking right now is {newDeck.Cards.Peek().Number} of {newDeck.Cards.Peek().Suit}");
            newDeck.Draw();
            Console.WriteLine($"The card you are looking right now is {newDeck.Cards.Peek().Number} of {newDeck.Cards.Peek().Suit}");
            newDeck.Shuffle();
            Console.WriteLine($"The card you are looking right now is {newDeck.Cards.Peek().Number} of {newDeck.Cards.Peek().Suit}");


            //Hand x = new Hand();
            //Console.WriteLine(x.Cards[20].Number); 

            //Card x = new Card();
            //Console.WriteLine(x.Suit);
        }
    }
}
