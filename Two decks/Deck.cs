using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_decks
{
    public class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 0; value < 13; value++)
                {
                    cards.Add(new Card((Card.Value)value, (Card.Suit)suit));
                }
            }
        }
        public Deck(Card[] initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count { get { return cards.Count; } }

        public void AddCard(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Remove(int index)
        {
            Card cardToRemove = cards[index];
            cards.RemoveAt(index);
            return cardToRemove;
        }

        public void Shuffle()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                int n = random.Next(cards.Count);
                Card card = cards[n];
                cards[n] = cards[i];
                cards[i] = card;
            }
        }

        public string[] GetCards()
        {
            string[] names = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
            {
                names[i] = cards[i].value.ToString() + " of " + cards[i].suit.ToString();
            }
            return names;
        }

        public void Sort()
        {
            cards.Sort(new CardsComparer());
        }
    }
}
