using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using static BlackJack_Final_Project.Suit;
using static BlackJack_Final_Project.Face;


namespace BlackJack_Final_Project
{
    public enum Suit
    {
        Clubs,
        Spades,
        Diamonds,
        Hearts
    }
    public enum Face
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }


    public class Card
    {
        public Suit Suit { get; }
        public Face Face { get; }
        public int Value { get; set; }
        public string PictureURL { get; }

        public Card(Suit suit, Face face)
        {
            Suit = suit;
            Face = face;

            switch (Suit)
            {
                case Clubs:
                    switch (Face)
                    {
                        case Two:
                            PictureURL = "2C";
                            Value = 2;
                            break;
                        case Three:
                            PictureURL = "3C";
                            Value = 3;
                            break;
                        case Four:
                            PictureURL = "4C";
                            Value = 4;
                            break;
                        case Five:
                            PictureURL = "5C";
                            Value = 5;
                            break;
                        case Six:
                            PictureURL = "6C";
                            Value = 6;
                            break;
                        case Seven:
                            PictureURL = "7C";
                            Value = 7;
                            break;
                        case Eight:
                            PictureURL = "8C";
                            Value = 8;
                            break;
                        case Nine:
                            PictureURL = "9C";
                            Value = 9;
                            break;
                        case Ten:
                            PictureURL = "10C";
                            Value = 10;
                            break;
                        case Jack:
                            PictureURL = "JC";
                            Value = 10;
                            break;
                        case Queen:
                            PictureURL = "QC";
                            Value = 10;
                            break;
                        case King:
                            PictureURL = "KC";
                            Value = 10;
                            break;
                        case Ace:
                            PictureURL = "AC";
                            Value = 11;
                            break;
                    }
                    break;
                case Spades:
                    switch (Face)
                    {
                        case Two:
                            PictureURL = "2S";
                            Value = 2;
                            break;
                        case Three:
                            PictureURL = "3S";
                            Value = 3;
                            break;
                        case Four:
                            PictureURL = "4S";
                            Value = 4;
                            break;
                        case Five:
                            PictureURL = "5S";
                            Value = 5;
                            break;
                        case Six:
                            PictureURL = "6S";
                            Value = 6;
                            break;
                        case Seven:
                            PictureURL = "7S";
                            Value = 7;
                            break;
                        case Eight:
                            PictureURL = "8S";
                            Value = 8;
                            break;
                        case Nine:
                            PictureURL = "9S";
                            Value = 9;
                            break;
                        case Ten:
                            PictureURL = "10S";
                            Value = 10;
                            break;
                        case Jack:
                            PictureURL = "JS";
                            Value = 10;
                            break;
                        case Queen:
                            PictureURL = "QS";
                            Value = 10;
                            break;
                        case King:
                            PictureURL = "KS";
                            Value = 10;
                            break;
                        case Ace:
                            PictureURL = "AS";
                            Value = 11;
                            break;
                    }
                    break;
                case Diamonds:
                    switch (Face)
                    {
                        case Two:
                            PictureURL = "2D";
                            Value = 2;
                            break;
                        case Three:
                            PictureURL = "3D";
                            Value = 3;
                            break;
                        case Four:
                            PictureURL = "4D";
                            Value = 4;
                            break;
                        case Five:
                            PictureURL = "5D";
                            Value = 5;
                            break;
                        case Six:
                            PictureURL = "6D";
                            Value = 6;
                            break;
                        case Seven:
                            PictureURL = "7D";
                            Value = 7;
                            break;
                        case Eight:
                            PictureURL = "8D";
                            Value = 8;
                            break;
                        case Nine:
                            PictureURL = "9D";
                            Value = 9;
                            break;
                        case Ten:
                            PictureURL = "10D";
                            Value = 10;
                            break;
                        case Jack:
                            PictureURL = "JD";
                            Value = 10;
                            break;
                        case Queen:
                            PictureURL = "QD";
                            Value = 10;
                            break;
                        case King:
                            PictureURL = "KD";
                            Value = 10;
                            break;
                        case Ace:
                            PictureURL = "AD";
                            Value = 11;
                            break;
                    }
                    break;
                case Hearts:
                    switch (Face)
                    {
                        case Two:
                            PictureURL = "2H";
                            Value = 2;
                            break;
                        case Three:
                            PictureURL = "3H";
                            Value = 3;
                            break;
                        case Four:
                            PictureURL = "4H";
                            Value = 4;
                            break;
                        case Five:
                            PictureURL = "5H";
                            Value = 5;
                            break;
                        case Six:
                            PictureURL = "6H";
                            Value = 6;
                            break;
                        case Seven:
                            PictureURL = "7H";
                            Value = 7;
                            break;
                        case Eight:
                            PictureURL = "8H";
                            Value = 8;
                            break;
                        case Nine:
                            PictureURL = "9H";
                            Value = 9;
                            break;
                        case Ten:
                            PictureURL = "10H";
                            Value = 10;
                            break;
                        case Jack:
                            PictureURL = "JH";
                            Value = 10;
                            break;
                        case Queen:
                            PictureURL = "QH";
                            Value = 10;
                            break;
                        case King:
                            PictureURL = "KH";
                            Value = 10;
                            break;
                        case Ace:
                            PictureURL = "AH";
                            Value = 11;
                            break;
                    }
                    break;
            }

        }
    }
}