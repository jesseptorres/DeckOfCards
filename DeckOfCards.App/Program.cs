using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckOfCards.Lib;

namespace DeckOfCards.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardDealer = new CardDealer();
                        
            ShuffleAndDealCards(cardDealer);            

            Console.Read();
        }

        private static void ShuffleAndDealCards(ICardDealer cardDealer) 
        {
            cardDealer.Shuffle();

            for (var i = 0; i < 53; i++)
            {
                var card = cardDealer.DealOneCard();

                if (card != null)
                {
                    Console.WriteLine(card);
                }
                else
                {
                    Console.WriteLine("No more cards to deal");
                }
            }
        }
    }
}
