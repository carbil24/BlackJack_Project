using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackJack_Final_Project
{
    public class Player
    {
        public int Chips { get; set; } = 500;
        public int Bet { get; set; }
        public int Wins { get; set; }
        public int HandsCompleted { get; set; } = 1;

        public List<Card> Hand { get; set; }

        public void AddBet(int bet)
        {
            Bet += bet;
            Chips -= bet;
        }

        public void ClearBet()
        {
            Bet = 0;
        }

        public void ReturnBet()
        {
            Chips += Bet;
            ClearBet();
        }

        //This check if the player won with blackjack
        public int WinBet(bool blackjack)
        {
            int chipsWon;
            if (blackjack)
            {
                chipsWon = (int)Math.Floor(Bet * 1.5);
            }
            else
            {
                chipsWon = Bet * 2;
            }

            Chips += chipsWon;
            ClearBet();
            return chipsWon;
        }

        //Applies the value of player's hand
        public int GetHandValue()
        {
            int value = 0;
            foreach (Card card in Hand)
            {
                value += card.Value;
            }
            return value;
        }

    }
}