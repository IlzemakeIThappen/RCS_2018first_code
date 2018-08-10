using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA3
{
    class Uzdevumi
    {
        static void Main(string[] args)
        {
            Class2.valsts20;
            //uzdevumi.Uzdevums2();
            //Class2.uzdevums3;
            //Class2.uzdevums4;
            //Class2.uzdevumi5;
        
            Console.ReadLine();
        }

    public static void uzdevums6()
    {
        Console.write("Ievadi, cik būs skaitļi: ");
        int daudzums =Convert.ToInt32(Console.ReadLine());

        Console.Write("1 skaitlis ");
        int skaitlis=

    }
    public static void uzdevums5()
    {
        Console.Write("Ievadi N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int SUMMA = 0;

        for(int i=1; i<=N;i++ )
        {
            SUMMA += 1;
            Console.WriteLine(i);
                
        }
        Console.Write("Summa =  " + summa);
    }



    public static void uzdevums4()
    {
        Console.Write("Ievadi skaitu: ");
        int skaitlis = Convert.ToInt32(Console.ReadLine());
        for(int i=1; i<=skaitlis; i++  )

        {
            int kvadrats = i * i;
            Console.WriteLine(i + "=>" + kvadrats);
        }

    }
        public static void uzdevums3()
        {
            Console.Write("Ievadi gadu:  ");
            int gads = Convert.ToInt32(Console.ReadLine());
            for(int i=gads; i<=DateTime.Now.Year; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Uzdevums2()
        {
            for (int i = 1; i <= 10; i++) ;

        }//i++ = i=i+1 katru reizi palielinās par 1
         //i=i+2 =   i+=2
    public static void valsts20()
        {
            Console.Write("Ievadiet valsti: ");
            string valsts = Console.ReadLine().ToLower();
            valsts = Char.ToUpper(valsts[0]) + valsts.Substring(1);

        
            switch (valsts)
            {
                case "Igaunija":
                    Console.Write(valsts + "Tallina");
                    break;

                case "Somija":
                    Console.Write("Helsinki");
                    break;

                case "Ukraina":
                    Console.Write("Kijeva");
                    break;

                case "Zviedrija":
                    Console.Write("Stokholma");

                    break;

                case "Krievija":
                    Console.Write("Maskava");
                    break;
                default:
                    Console.Write("Nezināma valsts");
                    break;
            }
        }

        static void Piemers()
        {
            string mervieniba = "C";
            switch (mervieniba)
            {
                case "C":
                    Console.Write("Ievadīti Celsiji");
                    break;
                case "F":
                    Console.Write("Ievadīti Fārenheiti");
                    break;
                case "K":
                    Console.Write("Ievadīti Kelvini");
                    break;
                case "z":
                case "A":
                    Console.Write("Ievadīti A VAI Z");
                    break;
                default:
                    Console.Write("nezināma mērvienība");
                    break;
            }
        }
    }

