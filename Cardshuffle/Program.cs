using System;

namespace Cardshuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();
            Console.WriteLine("Here are the first 5 cards");
            for (int i = 0; i < 5; i++)
            {
                var card = deck.Next();
                Console.WriteLine($"{card.FaceValue} of {card.Suit}");
            }
            Console.Read();
        }
    }
}
