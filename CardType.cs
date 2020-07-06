using System;
using System.Collections.Generic;
using System.Text;

namespace BuildDisplayDeckCards {
    public  class CardType {
        public string CardTypeName { get; set; }
        public int CardValue { get; set; }
        public int CardValueAlt { get; set; }

        public CardType(string cardTypeName, int cardValue, int cardAltValue) {
            this.CardTypeName = cardTypeName;
            this.CardValue = cardValue;
            this.CardValueAlt = cardAltValue;
        }
    }
}
