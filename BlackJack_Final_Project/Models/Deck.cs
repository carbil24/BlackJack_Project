using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackJack_Final_Project
{
    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            Initialize();
        }

        public List<Card> GetNewDeck()
        {
            List<Card> newDeck = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    newDeck.Add(new Card((Suit)j, (Face)i));
                }
            }

            return newDeck;
        }

        public void Shuffle()
        {
            Random rng = new Random();

            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card card = cards[k];
                cards[k] = cards[n];
                cards[n] = card;
            }
        }


        public List<Card> DealHand()
        {
            List<Card> hand = new List<Card>();
            hand.Add(cards[0]);
            hand.Add(cards[1]);

            cards.RemoveRange(0, 2);

            return hand;
        }

        public Card DrawCard()
        {
            Card card = cards[0];
            cards.Remove(card);

            return card;
        }

        public void Initialize()
        {
            cards = GetNewDeck();
            Shuffle();
        }
    }
}