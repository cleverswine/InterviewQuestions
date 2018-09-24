using System;
using System.Collections.Generic;
using System.Linq;

namespace Cardshuffle
{
    public class Deck
    {
        private Stack<Card> _cards;
        private static Random rng = new Random();

        public Deck()
        {
            _cards = new Stack<Card>();
            var cards = new List<Card>();

            foreach (var suit in Enum.GetValues(typeof(Suit)))
            {
                // cards 1 - 10
                Enumerable.Range(1, 10).ToList().ForEach(i => cards.Add(new Card { Suit = (Suit)suit, FaceValue = i.ToString(), Value = i }));
                // Face cards
                cards.Add(new Card { Suit = (Suit)suit, FaceValue = "Ace", Value = 10 });
                cards.Add(new Card { Suit = (Suit)suit, FaceValue = "King", Value = 10 });
                cards.Add(new Card { Suit = (Suit)suit, FaceValue = "Queen", Value = 10 });
                cards.Add(new Card { Suit = (Suit)suit, FaceValue = "Jack", Value = 10 });
            };

            Shuffle(cards);
        }

        public Card Next()
        {
            return _cards.Any() ? _cards.Pop() : null;
        }

        private void Shuffle(List<Card> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                _cards.Push(list[k]);
                list[k] = list[n];
            }
        }
    }
}
