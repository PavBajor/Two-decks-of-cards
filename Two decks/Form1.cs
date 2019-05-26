using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Two_decks
{
    public partial class Form1 : Form
    {
        Deck deck1;
        Deck deck2;
        Random random = new Random();

        void RedrawDeck(int deckNo)
        {
            if (deckNo==1)
            {
                listBox1.Items.Clear();
                string[] array = deck1.GetCards();

                for (int i = 0; i < array.Length; i++)
                {
                    listBox1.Items.Add(array[i]);
                }
            }
            if (deckNo==2)
            {
                listBox2.Items.Clear();
                string[] array = deck2.GetCards();

                for (int i = 0; i < array.Length; i++)
                {
                    listBox2.Items.Add(array[i]);
                }
            }
        }

        void ResetDeck(int deckNo)
        {
            if (deckNo==1)
            {
                deck1 = new Deck();
            }
            if (deckNo==2)
            {
                
                deck2 = new Deck(new Card[] { });
                for (int i = 0; i < random.Next(1, 11); i++)
                {
                    deck2.AddCard(new Card((Card.Value)random.Next(13), (Card.Suit)random.Next(4)));
                    deck2.Sort();
                }
            }
        }
        
        public Form1()
        {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void resetDeckOne_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void resetDeckTwo_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void shuffleDeckOne_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void shuffleDeckTwo_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void moveCardToDeckTwo_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex>=0)
            {
                if (deck1.Count>0)
                {
                    deck2.AddCard(deck1.Remove(listBox1.SelectedIndex));
                    RedrawDeck(1);
                    RedrawDeck(2);
                }
               
            }
            
        }

        private void moveCardToDeckOne_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                if (deck2.Count > 0)
                {
                    deck1.AddCard(deck2.Remove(listBox2.SelectedIndex));
                    RedrawDeck(1);
                    RedrawDeck(2);
                }

            }
        }
    }
}
