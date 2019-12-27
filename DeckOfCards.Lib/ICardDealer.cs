using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckOfCards.Models;

namespace DeckOfCards.Lib
{
    public interface ICardDealer
    {
        void Shuffle();

        Card DealOneCard();
    }
}
