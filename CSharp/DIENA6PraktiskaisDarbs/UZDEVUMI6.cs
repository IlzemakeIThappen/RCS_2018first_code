using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA6PraktiskaisDarbs
{
    public class UZDEVUMI6
    {
           public static void FIZZBUZZ()
            {
                // List<int> virkne = new List<int>();

                Console.Write("Ievadiet sākuma vērtību:  ");
                int skaitlis1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ievadiet beigu vērtību:  ");
                int skaitlis2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Skaitļu virkne: ");
                // int atlikums = Convert.ToInt32(Console.ReadLine());
                //atlikums = skaitlis1 % skaitlis2;


                //for (int i = skaitlis1; i <= skaitlis2; i++)
                //{
                /*if (atlikums == 0)
                {
                    Console.WriteLine("Fizz" + i);
                }*/
                // Console.WriteLine(i);
                //}
                double rezultats3;
                double rezultats5;

                for (int i = skaitlis1; i <= skaitlis2; i++)
                {
                    rezultats3 = i % 3;
                    rezultats5 = i % 5;

                    if (rezultats3 == 0 && rezultats5 > 0)
                    {
                        Console.Write("Fizz\n");
                    }
                    else if (rezultats5 == 0 && rezultats3 > 0)
                    {
                        Console.Write("Buzz\n");
                    }
                    else if (rezultats5 == 0 && rezultats3 == 0)
                    {
                        Console.Write("FizzBuzz\n");
                    }
                    else
                    {
                        Console.Write(i + "\n");
                    }
                }
                Console.ReadLine();
            }

            public static void neveiksmigais13()
        {

            List<int> saraksts = new List<int>();
           int summa = 0;

            while (true)
            {
                Console.Write("Ievadi skaitli, lai pārtrauktu ievadi raksti 13.  ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                if (skaitlis == 13)
                {
                    break;
                    //pārtrauc while ciklu
                }
                saraksts.Add(skaitlis);
            }
            Console.Write("Ievadīto skaitļu summa ir: ");
            //int summa = Convert.ToInt32(Console.ReadLine());
               foreach(int skaitlis in saraksts)
                {
                summa += skaitlis;
                
               }
            Console.WriteLine(summa);
            Console.ReadLine();

            
                //saraksts.Add(skaitlis)    
            

        
                //int sum = List.sum();

                /*
                saraksts.Add(skaitlis);
                saraksts.Add(summa);
            
                foreach (int summa in saraksts)
                {
                    if (skaitlis != -1)
                    {
                        summa = +;
                        Console.Readline();
                    }
                }
                Console.Write("Sarakstā ir:  " + skaitlis);
                
            
                }
                

           
            
        
    */
            public static void ATRUMAPARKAPEJS()
        {
            Console.Write("Ievadiet savu ātrumu! ");
            int atrums = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vai Jums ir dzimšanas diena? J/N");
            string dzimsana = Console.ReadLine();

            if (dzimsana == "J")
            {
                atrums -= 5;
            }
            
            if (atrums <= 60)
            {
                Console.Write("Jūsu soda apmērs ir 0");
                Console.ReadLine();
            }
            else if (atrums >= 60 || atrums <= 80)
            {
                Console.Write("Jūsu soda apmērs ir 1");
                Console.ReadLine();
            }
            else if (atrums > 80)
            {
                Console.Write("Jūsu soda apmērs ir 2");
                Console.ReadLine();
            }

            
        }

        public static void Modinatajs()
        {
            Console.Write("Ievadiet nedēļas dienu:   ");
            string diena = Console.ReadLine();

            Console.Write("Vai Jums ir atvaļinājums? Ievadiet J vai N: ");
            string atvalinajums = Console.ReadLine();

            if (atvalinajums == "J")
            {
                Console.Write("Tev jāceļas 10.00");
                Console.ReadLine();
            }

            else if (atvalinajums == "N" || diena == "P" || diena == "O" || diena == "T" || diena == "C" || diena == "Piekt")
            {
                Console.Write("Tev jāceļas 7.00");
                Console.ReadLine();
            }
             
            else if (atvalinajums == "N" || diena == "SE" || diena == "SV")
            {

                Console.Write("Tev jāceļas 7.00!");
                Console.ReadLine();
            }
            /*
            if (diena == "P" || diena == "O" || diena == "T" || diena == "C" || diena == "Piekt")
            {
                Console.Write("Tev jāceļas 10.00!");
            }
            */
        }
        public static void DilstosaVirkne()
        {
            List<int> virkne = new List<int>();


            while (true)
            {
                Console.Write("Ievadiet skaitli:  ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());


                for (int i = skaitlis - 1; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }

            }

        }

    }
}

