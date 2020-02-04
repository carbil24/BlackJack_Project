using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackJack_Final_Project
{
    public class Game
    {
        public static int MinimumBet { get; } = 1;

        //This checks if it is a blackjack
        public static bool IsHandBlackjack(List<Card> hand)
        {
            if (hand.Count == 2)
            {
                if (hand[0].Face == Face.Ace && hand[1].Value == 10) return true;
                else if (hand[1].Face == Face.Ace && hand[0].Value == 10) return true;
            }
            return false;
        }

    }
}