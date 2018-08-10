using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZERIENUAUTOMATS.DATI
{
    public class Automats
    {

        public double Summa;
        public Automats()
        {
            Summa = 0.0;
        }

        public void Iemaksat(double  summa)
        {
            Summa += summa;
        }

        public void PirktDzerienu()
        {
            if (Summa <=0.8)
            {
                Console.WriteLine("Nepietiek līdzekļu!");
            }
            else
            {
                Summa -= 0.8;
                Console.WriteLine("Atlikums:  " + Summa);
            }
        }

        public void IzdotAtlikumu()
        {
            Console.WriteLine("Tu saņēmi:  " + Summa);
            Summa = 0;
        }
        public void Darbibas()
        {
            Console.WriteLine("izvēlies darbību:  ");
            Console.WriteLine("-  Iemaksat (i)  ");
            Console.WriteLine("-  Pirkt (p)  ");
            Console.WriteLine("- izdod atlikumu (a)  ");
            Console.WriteLine("beigt darbu (b)  ");

            while(true)
            {
                Console.Write("Darbiba:  ");
                string darbiba = Console.ReadLine().ToLower();
                if (darbiba == "b")
                {
                    break;
                }

                switch(darbiba)
                {
                    case "i":
                        Console.Write("IEVADI summu:   ");
                        double summa = Convert.ToDouble(Console.ReadLine());
                        Iemaksat(summa);
                        break;
                    case "p":
                        PirktDzerienu();
                        break;
                    case "a":
                        IzdotAtlikumu();
                        break;
                }
            }
        }

        /*
        public DZERIENUAUTOMATS(double iemaksataSumma, double atlikums)
        {

            iemaksataSumma = IemaksataSumma;
            Atlikums = atlikums;
        }
        
        public void List<DZERIENUAUTOMATS> IEMAKSAT;
                
            IEMAKSAT = new List<DZERIENUAUTOMATS>()
                        {
              


            }

        */


    }
}
