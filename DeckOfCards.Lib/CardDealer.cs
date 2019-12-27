using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckOfCards.Models;

namespace DeckOfCards.Lib
{
    /// <summary>
    /// Card dealer class
    /// </summary>
    public class CardDealer : ICardDealer
    {
        private List<Card> _cards = new List<Card>();
        private IEnumerator<Card> _cardsEnumerator;
        
        public CardDealer() 
        {
            BuildDeckOfCards();            
            _cardsEnumerator = _cards.GetEnumerator();            
        }
        

        /// <summary>
        /// Shuffles cards into a random order
        /// </summary>
        public void Shuffle()
        {
            RandomizeCards();
            _cardsEnumerator = _cards.GetEnumerator();
        }

        /// <summary>
        /// Returns one card from the deck. Returns null after all 52 cards ard dealt.
        /// </summary>
        /// <returns></returns>
        public Card DealOneCard()
        {
            _cardsEnumerator.MoveNext();
            return _cardsEnumerator.Current;           
        }
        
        private void BuildDeckOfCards() 
        {
            _cards = new List<Card>();

            foreach (var suit in Enum.GetValues(typeof(CardSuits)).Cast<CardSuits>()) 
            {
                var cards = BuildSuitOfCards(suit);

                _cards.AddRange(cards);
            }            
        }

        private static List<Card> BuildSuitOfCards(CardSuits suit) 
        {
            var cards = new List<Card>();

            for (var i = 0; i < 13; i++)
            {
                var card = new Card
                {
                    NumericValue = i + 1,
                    Suit = suit,
                    Name = CardNames[i]
                };

                cards.Add(card);
            }

            return cards;
        }
                       
        private static readonly string[] CardNames = new string[] 
        {
            "Ace", 
            "2", 
            "3", 
            "4", 
            "5",
            "6", 
            "7", 
            "8", 
            "9", 
            "10", 
            "Jack",
            "Queen", 
            "King"
        };

        private void RandomizeCards()
        {
            var cards = new List<Card>();
            var random = new Random();
            var randomIndex = 0;

            while (_cards.Count > 0)
            {
                randomIndex = random.Next(0, _cards.Count);
                cards.Add(_cards[randomIndex]);
                _cards.RemoveAt(randomIndex);
            }

            _cards = cards;
        }
    }
}
