using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DATA
{
    public class Deck
    {
        public string[] Suits = { "H", "S", "D", "C" };
        public string[] Values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        //īpašība cards(List<Card>
        public List<Card> Cards;
        //konstruktors (bez parametriem)
        public Deck()
        {
            Cards = new List<Card>();
              foreach(string suit in Suits)
                {
                    foreach(string value in Values)
                  {
                    Cards.Add(new Card(suit, value));
                  }
                }
         }
        //kostruktors azipilda kāršu sarakstu ar visām 52 kārtīm

            public void shuffle()
                {
            Random rnd = new Random();
            Cards = Cards.OrderBy(c => rnd.Next()).ToList();
                 }
        
        //void shuffle()- sajauc Cards
        //Cards getCard()- atgriež vienu kārti no saraksta un izdzēs no tā 
        public Card GetCards()
        {
            //paņem kārti no saraksta
            Card card = Cards [0];
            //izdzēš no saraksta
            Cards.Remove(card);
            //atgriež kā rezultātu
            return card;

        }

    }
}
