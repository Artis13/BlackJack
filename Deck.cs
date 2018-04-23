using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
   public  class Deck
    {
        public char[] Suits = { 'H', 'D', 'S', 'C' };
        public String[] Values = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };



        public List <Card> Cards;

        public Deck()
        {
            Cards = new List<Card>();

            foreach(char s in Suits)
            {
                foreach(string v in Values)
                {
                    // Pievienot kārti kāršu kavai.
                    Cards.Add(new Card(v, s));
                }
            }

        }

        public Card TakeCard()
        {
            Card newCard = Cards.First();
            Cards.RemoveAt(0);

            return newCard;
        }


        public Deck TakeNewDeck()
        {
            return null;
        }

    }
}
