using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
  public   class Card
    {
        public string Value;
        public char Suit;

        public Card(String value, char suit)
        {
            this.Value = value;
            this.Suit = suit;

        }

        public int GetValue()
        {
            return 0;
        }

    }
}
