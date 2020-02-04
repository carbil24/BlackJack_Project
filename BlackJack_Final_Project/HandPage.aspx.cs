using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace BlackJack_Final_Project
{
    public partial class HandPage : System.Web.UI.Page
    {
        private Deck _deck;
        private Player _player;
        private Dealer _dealer;

        public Deck deck
        {
            get
            {
                return _deck;
            }

            set
            {
                _deck = value;
            }
        }

        public Player player
        {
            get
            {
                return _player;
            }

            set
            {
                _player = value;
            }
        }

        public Dealer dealer
        {
            get
            {
                return _dealer;
            }

            set
            {
                _dealer = value;
            }
        }
        private enum RoundResult
        {
            PUSH,
            PLAYER_WIN,
            PLAYER_BUST,
            PLAYER_BLACKJACK,
            DEALER_WIN,
        }
         
        //This stores the messages to show according of the result of the hand.
        void EndRound(RoundResult result)
        {
            StringBuilder message = new StringBuilder();

            switch (result)
            {
                case RoundResult.PUSH:
                    player.ReturnBet();
                    message.Append("You and Dealer Push.");
                    break;
                case RoundResult.PLAYER_WIN:
                    message.Append("You Win $" + player.WinBet(false));
                    break;
                case RoundResult.PLAYER_BUST:
                    player.ClearBet();
                    message.Append("You Bust!");
                    break;
                case RoundResult.PLAYER_BLACKJACK:
                    message.Append("You Win $" + player.WinBet(true) + " with Blackjack.");
                    break;
                case RoundResult.DEALER_WIN:
                    player.ClearBet();
                    message.Append("Dealer Wins.");
                    break;
            }


            if (player.Chips <= 0)
            {
                message.AppendLine("<br/>" + Session["name"].ToString() + ", you lost your money after " + (player.HandsCompleted - 1) + " rounds.");
            }

            lblMessage.Text = message.ToString();
            lblMessage.Visible = true;
            btnOK.Visible = true;
            lblShowBet.Visible = false;
            btnHit.Visible = false;
            btnStand.Visible = false;
        }

        //It shows the player's cards
        public void ShowPlayerHand()
        {
            int degree = -25;

            lblShowBet.Text = "Bet: $" + player.Bet + "  ";
            lblBank.Text = "Bank: $" + player.Chips + "  ";
            lblWins.Text = "Wins: " + player.Wins;
            lblRound.Text = "Round #" + player.HandsCompleted;
            lblPlayerHand.Text = Session["name"].ToString();
            lblPlayerHandValue.Text = player.GetHandValue().ToString();

            playerCards.Controls.Clear();
            foreach (Card card in player.Hand)
            {
                //This is to rotate the cards
                degree += 10;

                HtmlGenericControl li = new HtmlGenericControl("li");
                li.InnerHtml = "<img src='/img/" + card.PictureURL + ".png' width='100px' height='163px' style='transform: rotate(" + degree + "deg);' />";
                li.Attributes.Add("class", "overlap");

                //li.InnerText = card.PictureURL;
                playerCards.Controls.Add(li);
            }
        }

        //It shows the delaer's cards
        public void ShowDealerHand()
        {
            int degree = -25;

            lblDealerHand.Text = "Dealer";
            lblDealerHandValue.Text = dealer.GetHandValue().ToString();
            dealerCards.Controls.Clear();

            foreach (Card card in dealer.RevealedCards)
            {
                //This is to rotate the cards
                degree += 10;

                HtmlGenericControl li = new HtmlGenericControl("li");
                li.InnerHtml = "<img src='/img/" + card.PictureURL + ".png' width='100px' height='163px' style='transform: rotate(" + degree + "deg);' />";
                li.Attributes.Add("class", "overlap");
                //li.InnerText = card.PictureURL;
                dealerCards.Controls.Add(li);

            }

            for (int i = 0; i < dealer.HiddenCards.Count; i++)
            {
                HtmlGenericControl li = new HtmlGenericControl("li");
                li.InnerHtml = "<img src='/img/purple_back.png' width='100px' height='163px' style='transform: rotate(-5deg);'/>";
                li.Attributes.Add("class", "overlap");
                dealerCards.Controls.Add(li);
            }
        }

        //This checks the results of a hand after the player gets more than 21 or after the player stands.
        public void CheckResult()
        {
            dealer.RevealCard();
            ShowPlayerHand();
            ShowDealerHand();


            if (player.GetHandValue() > 21)
            {
                EndRound(RoundResult.PLAYER_BUST);
                player.HandsCompleted++;
                return;
            }

            // The dealer plays after the player stands.
            while (dealer.GetHandValue() <= 16)
            {
                dealer.RevealedCards.Add(deck.DrawCard());
                ShowPlayerHand();
                ShowDealerHand();
            }

            if (player.GetHandValue() > dealer.GetHandValue())
            {
                player.Wins++;
                if (Game.IsHandBlackjack(player.Hand))
                {
                    EndRound(RoundResult.PLAYER_BLACKJACK);

                }
                else
                {
                    EndRound(RoundResult.PLAYER_WIN);
                }
            }
            else if (dealer.GetHandValue() > 21)
            {
                player.Wins++;
                EndRound(RoundResult.PLAYER_WIN);


            }
            else if (dealer.GetHandValue() > player.GetHandValue())
            {
                EndRound(RoundResult.DEALER_WIN);


            }
            else
            {
                EndRound(RoundResult.PUSH);

            }

            player.HandsCompleted++;

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            player = (Player)Session["player"];
            dealer = (Dealer)Session["dealer"];
            deck = (Deck)Session["deck"];
            lblMessage.Visible = false;
            btnOK.Visible = false;

            ShowPlayerHand();
            ShowDealerHand();
        }

        protected void btnHit_Click(object sender, EventArgs e)
        {
            player.Hand.Add(deck.DrawCard());

            //This changes the value of the aces if the player has more than 21.
            if (player.GetHandValue() >= 21)
            {
                foreach (Card card in player.Hand)
                {
                    if (card.Value == 11)
                    {
                        card.Value = 1;
                        break;
                    }
                }
            }

            ShowPlayerHand();
            ShowDealerHand();


            if (player.GetHandValue() > 21)
            {
                CheckResult();
            }
        }

        protected void btnStand_Click(object sender, EventArgs e)
        {
            CheckResult();
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (player.Chips <= 0)
            {
                player.HandsCompleted = 1;
                player.Wins = 0;
                player.Chips = 500;
                player.Bet = 0;
                Session.Abandon();
                Response.Redirect("default.aspx");
            }
            else
            {
                Response.Redirect("DealPage.aspx");
            }
        }

        protected void btnSurrender_Click(object sender, EventArgs e)
        {
            player.Hand.Clear();
            CheckResult();

        }
    }
}