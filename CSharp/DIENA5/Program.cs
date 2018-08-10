using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // IedzivotajsAdrese();
            //MasivaPiemers();
            //UZDEVUMI.uzdevums24();
            //UZDEVUMI.uzdevums25();
            //UZDEVUMI.uzdevums26();
            //UZDEVUMI.uzdevums27();
            //UZDEVUMI.uzdevums28();
            //SarakstaPiemers();

            Console.ReadLine();
        }

        static void SarakstaPiemers()
        {
            List<int> saraksts = new List<int>();
            saraksts.Add(5);
            saraksts.Add(10);
            saraksts.Add(17);

            foreach(int sk in saraksts)
            {
                Console.WriteLine(sk);
            }
            for (int i=0; i < saraksts.Count;i++)
            {
                Console.WriteLine(saraksts[i]);
            }

        }
        static void MasivaPiemers()
        {
            //int skaitlis1 = 5;
            //int skaitlis2 = 10;
            int[] saraksts = new int[3];
            saraksts[0] = 5;
            saraksts[1] = 10;
            saraksts[2] = 19;
            //saraksts[3] <- parādītu kļūda, jo ir no 0 līdz 2
            int[] saraksts2 = { 5, 10, 19 };
            int SkaitsMasiva = saraksts2.Length; //3 mūsu gadījumā

            for(int i=0; i<saraksts.Length; i++)
            {
                //izvada skaitli pozīcijā i
                Console.WriteLine(saraksts[i]);
            }

            //izvadīs 5 10 19
            foreach(int skaitlis in saraksts2)
            {
                Console.WriteLine(skaitlis);
            }
        }
        static void IedzivotajsAdrese()
        {
            IEDZIVOTAJS iedz = new IEDZIVOTAJS();
            iedz.Vards = "Andris";
            iedz.Uzvards = "Berzins";
            iedz.Dzivesvieta = new ADRESE();
            iedz.Dzivesvieta.Valsts = "Latvija";
            iedz.Dzivesvieta.Pilseta = "Rīga";
            iedz.Dzivesvieta.Iela = "Brīvības gatve";
            iedz.Dzivesvieta.MajasNr = "100";
            iedz.Dzivesvieta.DzivoklaNr = 5;

            iedz.Apraksts();

        }
    }
}
