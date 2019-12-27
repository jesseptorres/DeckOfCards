using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards.Models
{
    public class Card
    {
        public int NumericValue { get; set; }

        public CardSuits Suit { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} of {Suit.ToString()}";
        }
    }    
}
