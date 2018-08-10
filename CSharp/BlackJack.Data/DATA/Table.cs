using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DATA
{
   public class Table
    {
       private Deck deck;
       private Dealer dealer;
       private Player player;

        public Table()
        {
            deck = new Deck();
            dealer = new Dealer();
            player = new Player();
        }

        //1.void StartNewGame()
        public void StartNewGame()
        //1.1 paņemjaunu kāršu kavu
        {
            deck = new Deck();
            dealer = new Dealer();
            player = new Player();

            //1.2 samaisa kartis
            deck.shuffle();
            //1.3 spēlētājiem piešķir 2 kārtis
            player.GiverCard(deck.GetCards());
            player.GiverCard(deck.GetCards());
            //1.4 dīlerim piešķir 2 kārtis
            dealer.GiverCard(deck.GetCards());
            dealer.GiverCard(deck.GetCards());
        }
        //2.bool PlayAgain()
        //2.1 vaicā lietotājam, vai uzsākt jaunu spēli
        public bool PlayAgain()
        {
            Console.Write("Vai uzsākt jaunu spēli (j/n)?  ");
            string answer = Console.ReadLine();

            return answer.ToLower() == "j";
        }
        //3. void ShowResults()
        //3.1. izvada rezultātu - kurš uzvarēja (vajag loģiku)
        public void ShowResult()
        {
            int playerPoints = player.CountPoints();
            int dealerPoints = dealer.CountPoints();

            // pie rezultāta izvadīt abu šalībnieku punktus table
            Console.WriteLine("Dīlera punkti:  " + dealerPoints);
            Console.WriteLine("Spēlētāja punkti:  " + playerPoints);

            if (playerPoints>21 )
            {
                Console.WriteLine("Tu zaudēji!  ");
            }
            else if (dealerPoints>21)
            {
                Console.WriteLine("Tu uzvarēji!  ");
            }
            else if (playerPoints == dealerPoints)
            {
                Console.WriteLine("Neizšķirts!");
            }
            else if(playerPoints > dealerPoints)
            {
                Console.WriteLine("Tu uzvarēji! ");
            }
            else
            {
                Console.WriteLine("Tu zaudēji! ");
            }


        }
        // 4. void PlayerTurn()
        //4.1 dod kārtis spēlētājam tik ilgi kamēr vēlas
        public void PlayerTurn()
        {
            while (player.NeedCard())
            {
                player.GiverCard(deck.GetCards());
            }
        }
        //5 void DealerTurn()
        //5.1 dod kārtis dīlerim tik ilgi, cik vajag
        public void DealerTurn()
        {
            while (dealer.NeedCard())
            {
                player.GiverCard(deck.GetCards());
            }
        }
    }
}
