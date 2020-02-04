using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlackJack_Final_Project
{
    public partial class DealPage : System.Web.UI.Page
    {
        private static Deck deck = new Deck();
        private static Player player = new Player();
        private static Dealer dealer = new Dealer();
        private static int currentBet = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblCurrentChipCount.Text = "Bank: $" + player.Chips;
            lblHand.Text = Session["name"].ToString() +", please bet to begin hand " + player.HandsCompleted + ".";
            btnBet.Visible = false;
            btnReset.Visible = false;
            btnEndGame.Visible = true;
            lblBetValue.Text = "0";
            checkChips();
        }

        void InitializeHands()
        {
            deck.Initialize();

            //Store the hand in the player's hand
            player.Hand = deck.DealHand();

            //Store the hand(two cards) in the dealer's hand but they are hidden
            dealer.HiddenCards = deck.DealHand();

            //Create a list of the dealer's cards
            dealer.RevealedCards = new List<Card>();

            // If player's hand contains two aces, one takes the value of 1.
            if (player.Hand[0].Face == Face.Ace && player.Hand[1].Face == Face.Ace)
            {
                player.Hand[1].Value = 1;
            }

            // If dealer's hand contains two aces, one takes the value of 1.
            if (dealer.HiddenCards[0].Face == Face.Ace && dealer.HiddenCards[1].Face == Face.Ace)
            {
                dealer.HiddenCards[1].Value = 1;
            }


            dealer.RevealCard();
        }

        //It verifies if the current bet is ok to deal.
        bool TakeBet()
        {
            if (currentBet >= Game.MinimumBet && player.Chips >= currentBet)
            {
                player.AddBet(currentBet);
                return true;
            }
            return false;
        }

        protected void btnBet_Click(object sender, EventArgs e)
        {
            if (TakeBet())
            {
                InitializeHands();

                Session["player"] = player;
                Session["dealer"] = dealer;
                Session["deck"] = deck;

                currentBet = 0;

                Response.Redirect("HandPage.aspx");
            }
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            currentBet += 1;
            lblBetValue.Text = currentBet.ToString();
            btnBet.Visible = true;
            btnEndGame.Visible = false;
            btnReset.Visible = true;

        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            currentBet += 5;
            lblBetValue.Text = currentBet.ToString();
            btnBet.Visible = true;
            btnEndGame.Visible = false;
            btnReset.Visible = true;


        }

        protected void btn25_Click(object sender, EventArgs e)
        {
            currentBet += 25;
            lblBetValue.Text = currentBet.ToString();
            btnBet.Visible = true;
            btnEndGame.Visible = false;
            btnReset.Visible = true;

        }

        protected void btn50_Click(object sender, EventArgs e)
        {
            currentBet += 50;
            lblBetValue.Text = currentBet.ToString();
            btnBet.Visible = true;
            btnEndGame.Visible = false;
            btnReset.Visible = true;

        }

        protected void btn100_Click(object sender, EventArgs e)
        {
            currentBet += 100;
            lblBetValue.Text = currentBet.ToString();
            btnBet.Visible = true;
            btnEndGame.Visible = false;
            btnReset.Visible = true;

        }

        protected void btn500_Click(object sender, EventArgs e)
        {
            currentBet += 500;
            lblBetValue.Text = currentBet.ToString();
            btnBet.Visible = true;
            btnEndGame.Visible = false;
            btnReset.Visible = true;

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            currentBet = 0;
            lblBetValue.Text = currentBet.ToString();
            btnBet.Visible = false;
            btnEndGame.Visible = true;
            btnReset.Visible = false;


        }

        //it checks the player's money to show or not to show each chip.
        public void checkChips()
        {
            if (player.Chips < 500)
            {
                btn500.Visible = false;
            }

            if (player.Chips < 100)
            {
                btn100.Visible = false;
            }

            if (player.Chips < 50)
            {
                btn50.Visible = false;
            }

            if (player.Chips < 25)
            {
                btn25.Visible = false;
            }

            if (player.Chips < 5)
            {
                btn5.Visible = false;
            }

            if (player.Chips == 0)
            {
                btn1.Visible = false;
                btnBet.Visible = false;
                btnReset.Visible = false;
                btnEndGame.Visible = true;
            }

        }

        protected void btnEndGame_Click(object sender, EventArgs e)
        {
            //This kill the session and create a new Player object.
            Session.Abandon();
            player = new Player();
            Response.Redirect("default.aspx");
        }
    }
}