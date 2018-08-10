using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA6PraktiskaisDarbs
{
    class Program
    {
        static void Main(string[] args)
        {
            //UZDEVUMI6.DilstosaVirkne();
            //UZDEVUMI6.Modinatajs();
            //UZDEVUMI6.ATRUMAPARKAPEJS();
            //UZDEVUMI6.neveiksmigais13();
            //SarezgitieUzdevumi.FIZZBUZZ();
            //SarezgitieUzdevumi.SarakstaPiemers();
           // Sarezgitieuzdevumi.KARATAVAS();
            Sarezgitieuzdevumi();

            Karatavas k = new Karatavas();
            k.StartNewGame();

            while(k!.VaiIrAtminets())
                {
                Console.Write("Ievadi burtu:   ");
                string ievade = Console.ReadLine();
                k.MinetBurtu(Convert.ToChar(ievade));

                Console.WriteLine("Vards ir atminēts!");
                Console.ReadLine();
            }
            
        }
    }
}
