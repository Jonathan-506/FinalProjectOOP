using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectOOP
{


    public class Card
    {
        public string Name { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }

        public Card(string name, string suit, int value)
        {
            Name = name;
            Suit = suit;
            Value = value;
        }

        internal static void AceValue(Card card, int total)
        {

            if (card.Name == "Ace" && total <= 10)
            {
                card.Value = 11;

            }
            else if (card.Name == "Ace" && total > 10)
            {
                card.Value = 1;
            }

        }

    }
    public class Deck
    {

        public List<Card> Cards { get; set; } 

        public Deck()
        {
            
        }

        public void CreateDeck()
        {
            List<string> cards = new List<string> {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
            Cards = new List<Card>();

            foreach (string card in cards)
            {
                Cards.Add(new Card(card, "Diamonds", Tools.GetValue(card)));
                Cards.Add(new Card(card, "Hearts", Tools.GetValue(card)));
                Cards.Add(new Card(card, "Clubs", Tools.GetValue(card)));
                Cards.Add(new Card(card, "Spade", Tools.GetValue(card)));
            }
            
        }

        //public static List< int> CreateDeckBlackJack(List<Card> deckforBlkJk)
        //{

        //    Deck deck = new Deck();
        //    deck.CreateDeck();

        //    return deckforBlkJk = deck.Cards.ToDictionary(card => card, card.Value => Tools.GetValue(card));

        //}
    }

}
