using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_decks
{
    public class Card
    {
        public Card(Value value, Suit suit)
        {
            this.suit = suit;
            this.value = value;
        }
        public enum Suit
        {
            Spades,
            Clubs,
            Diamonds,
            Hearts,
        }

        public enum Value
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
        }

        public Suit suit;
        public Value value;
    }
}
