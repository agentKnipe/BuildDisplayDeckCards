using System;
using System.Collections.Generic;
using System.Text;

namespace BuildDisplayDeckCards {
    internal class Deck {
        private string[] _suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        private List<CardType> _cardTypes;

        public List<Card> CardsInDeck;

        public Deck() {
            CardsInDeck = new List<Card>();
            _cardTypes = InitCardTypes();

            foreach (var suit in _suits) {
                foreach(var cardType in _cardTypes) {
                    CardsInDeck.Add(new Card(suit, cardType));
                }
            }
        }

        public void Display() {
            foreach(var card in CardsInDeck) {
                Console.WriteLine($"{card.CardType.CardTypeName} of {card.Suit}");
            }
        }

        private List<CardType> InitCardTypes() {
            var cardTypes = new List<CardType>();

            cardTypes.Add(new CardType("2", 2, 2));
            cardTypes.Add(new CardType("3", 3, 3));
            cardTypes.Add(new CardType("4", 4, 4));
            cardTypes.Add(new CardType("5", 5, 5));
            cardTypes.Add(new CardType("6", 6, 6));
            cardTypes.Add(new CardType("7", 7, 7));
            cardTypes.Add(new CardType("8", 8, 8));
            cardTypes.Add(new CardType("9", 9, 9));
            cardTypes.Add(new CardType("10", 10, 10));
            cardTypes.Add(new CardType("Jack", 11, 10));
            cardTypes.Add(new CardType("Queen", 12, 10));
            cardTypes.Add(new CardType("King", 13, 10));
            cardTypes.Add(new CardType("Ace", 14, 11));

            return cardTypes;
        }
    }
}
