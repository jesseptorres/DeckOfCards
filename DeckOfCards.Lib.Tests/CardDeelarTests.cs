using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckOfCards.Models;
using NUnit.Framework;

namespace DeckOfCards.Lib.Tests
{
    [TestFixture]
    public class CardDeelarTests
    {
        [Test]
        public void ShouldReturnDistinctCards()
        {
            var cardDealer = new CardDealer();
            var cards = new List<Card>();

            cardDealer.Shuffle();

            for (var i = 0; i < 52; i++)
            {
                var card = cardDealer.DealOneCard();

                cards.Add(card);
            }

            var count = cards.Distinct().Count();
            Assert.AreEqual(52, count);
        }


        [Test]
        public void ShouldReturnNullAfterDealing52Cards() 
        {
            var cardDealer = new CardDealer();
            Card card = null;

            cardDealer.Shuffle();

            for (var i = 0; i < 53; i++) 
            {
                card = cardDealer.DealOneCard();
            }           
            
            Assert.IsNull(card);
        }

        
    }
}
