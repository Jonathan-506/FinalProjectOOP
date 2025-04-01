using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectOOP
{

    public class Card
    {
        public string Name { get; set; }

        public int Value { get; set; }


        public Card()
        {

        }


    }

    public class DeckOfCards
    {
        public List<Card> Deck { get; set; } = new List<Card>();

        public DeckOfCards()
        {

        }

        public void AddCard(string name, int value)
        {
     

        }
    }

}
