using System;
using System.Collections.Generic;
using System.Text;

namespace BuildDisplayDeckCards {
    internal class Card {
        public string Suit { get; set; }
        public CardType CardType { get; set; }

        public Card(string suit, CardType cardType) {
            this.Suit = suit;
            this.CardType = cardType;
        }
    }
}
