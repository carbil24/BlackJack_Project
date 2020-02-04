using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackJack_Final_Project
{
    public class Dealer
    {
        public List<Card> HiddenCards { get; set; } = new List<Card>();
        public List<Card> RevealedCards { get; set; } = new List<Card>();


        public void RevealCard()
        {
            try
            {
                RevealedCards.Add(HiddenCards[0]);
                HiddenCards.RemoveAt(0);
            }
            catch
            {
                
            }
        }

        public int GetHandValue()
        {
            int value = 0;
            foreach (Card card in RevealedCards)
            {
                value += card.Value;
            }
            return value;
        }

    }
}