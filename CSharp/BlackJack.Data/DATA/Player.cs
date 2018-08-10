using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DATA
{
    public class Player
    {
        //īpašība cards (List<Card>)
       public List<Card> Cards;
        //List<Card>
        
        // konstruktors (bez parametriem)
        // definē Cards sarakstu
        public Player()
        {
            Cards = null;
            Cards = new List<Card>();
        }

        //saskaita cik speletajam ir Cards punkti int CountPoints()
        public int CountPoints()
        {
            int POINTS = 0;
            int AceCount = 0;
            foreach (Card c in Cards)
            {
                POINTS += c.GetPoints();
                //ja ir dūzis, tad palielinam skaitu
                if (c.Value == "A")
                {
                    AceCount++;
                }


            }
                //3.3 todo -apstrādāt dūžus
                //ja punktu skaits pārsniedz 21
                //un ir kāds dūzis, tad par katru ņem nost
                //10 punktu, kamēr nepārsniedz 21
                //vai beidzas dūži
                while (POINTS > 21 && AceCount > 0)
                {
                    POINTS -=10;
                    AceCount--;
                }
                return POINTS;
            
        }
        //void giveCard(Card card)-pievieno kārti sarakstam
        //bool needCard() - vai nepieciešama vēl kārts bool = true or false
        public virtual void GiverCard(Card card)
            {
             Cards.Add(card);
            Console.WriteLine("Spēlētājs saņēma  " + card.Suit + card.Value);
            Console.WriteLine("Punkti =  " + CountPoints());
            }
        public virtual bool NeedCard()
        {
            Console.Write("Vai nepieciešama kārts (j/n)  ");
            string atbilde = Console.ReadLine();

            //1.ja spēlētājam ir virs 21, tad pārtraukt vaicāšanu player

            if (CountPoints() > 21)
            {
                return false;
            }

            if (atbilde.ToLower() == "j")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
