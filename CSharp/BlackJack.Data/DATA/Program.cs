using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DATA
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();

            while (true)
            {
                table.StartNewGame();
                table.PlayerTurn();
                table.DealerTurn();
                table.ShowResult();

                //if (table.PlayAgain()== false)
                if (!table.PlayAgain())
                {
                    break;
                }
            }        
            //3.cikliski uzsākt jaunu spēli


            Console.ReadLine();
        }
    }
}
