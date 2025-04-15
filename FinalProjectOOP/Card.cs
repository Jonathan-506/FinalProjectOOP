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

        public Card(string name, string suit)
        {
            Name = name;
            Suit = suit;
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
                Cards.Add(new Card(card, "Diamonds"));
                Cards.Add(new Card(card, "Hearts"));
                Cards.Add(new Card(card, "Clubs"));
                Cards.Add(new Card(card, "Spade"));
            }
            
        }

        public void CreateDeckBlackJack()
        {

            Deck deck = new Deck();
            deck.CreateDeck();

            Dictionary<Card, int> deckforBlkJk = deck.Cards.ToDictionary(card => card, card => Tools.GetValue(card));

        }
    }

}
