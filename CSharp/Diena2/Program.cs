using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Piemers();
            //Vecums();
            //Salidzinat();
            //Menesis();
            //tekstauzd();
            //Kalkulators();
            Gradi();
            Console.ReadLine();
        }

        static void Gradi()
        {
            //Ievade:• grādi• grādu mērvienība('F', 'C' vai ‘K’)• jaunā mērvienība('F', 'C' vai ‘K')
            Console.Write("Ievadiet grādus: ");
            int gradi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadiet mērvienību: ");
            string mervieniba = Console.ReadLine().ToLower();

            Console.Write("Ievadiet nepieciešamo mērvienību:  ");
            string jaunamervieniba = Console.ReadLine();

            Console.Write("Grādi ir: ");
            

            //grādi pārvērsti uz jauno mērvienību
            
            //int kelvini = Celsijs + 273;
           
            // int Farenheits = Convert.ToInt32(Console.ReadLine());
            
            //float Farenheiti = Celsijs * 1.8f + 32;
            //int Rezultats1 = kelvini;
            

            if (mervieniba == "C" || jaunamervieniba== "K")
            {
              
                Console.Write("Pieprasītā mērvienība ir:  " + Rezultats1);
            }
               // int 
               // Console.Write("jauna mervienība: " + jaunamervieniba);
            
                

            
        }

        static void Kalkulators()
        {
            Console.Write("1. skaitlis: ");            
            int sk1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi darbību:  ");
            string darb = Console.ReadLine();

            Console.Write("Ievadi 2. skaitli: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            if (darb == "+")
            {
                int summa = sk1 + sk2;
                Console.Write("Summa: " + summa);
            }
            else if (darb == "-")
            {
                int starpiba = sk1 - sk2;
                Console.Write("Starpība: " + starpiba);
            }
            else if (darb == "*")
            {
                int Reizinajums = sk1 * sk2;
                Console.Write("Reizinājums:  " + Reizinajums);
            }
            else if(darb == "/")
                    {
                int DALIJUMS = sk1 / sk2;
                Console.Write("DALIJUMS: " + DALIJUMS);
            }
            else
            {
                Console.Write("Nezināma darbība.");
            }
                                      
               
           
                    
            
        }
        static void tekstauzd()
        {
            Console.Write("Ievadiet attālumu metros:  ");
            int Attālums = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadiet patērēto laiku: ");
            int laiks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Stundas:  ");
            int stundas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("sekundes:   ");
            int sekundes = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            int KopejaisLaiks = laiks * 60;
            Console.WriteLine("Kopējais Laiks: " + KopejaisLaiks);

            decimal Atrums = Attālums / KopejaisLaiks;
            Console.WriteLine("Ātrums: " + Atrums);

            decimal Atrums2 = (Attālums / 1000) / laiks / (60 * 60);
            Console.WriteLine("ĀTRUMS KM H: " + Atrums2);

            decimal Attalums1 = Attālums / 1000;
            Console.WriteLine("Attālums kilometros: " + Attalums1);

            decimal ATTALUMS2 = Attalums1 * 0.621371m;
            Console.WriteLine("Attālums jūdzēs:  " + ATTALUMS2);

        }

    
        
        
        static void Menesis()
    
        {
            Console.Write("Ievadiet mēnesi: ");
            string Menesis = Console.ReadLine().ToLower();


            if (Menesis == "feb")
            {
                Console.Write("28 dienas");

            }
            else if (Menesis == "apr" || Menesis == "jun" || Menesis == "sep" || Menesis == "nov")
            {
                Console.Write("30 dienas");
            }
     else if(Menesis == "jan" || Menesis=="mar" ||Menesis == "mai" ||Menesis == "jul" || Menesis == "aug" || Menesis == "okt" || Menesis == "dec")
            {
                Console.Write("31 diena");
            }
            else
            {
                Console.Write("Nezināms Mēnesis");
            }
        }

        static void Salidzinat()
        {
        
                Console.Write("Ievadiet pirmo skaitli: ");
            int Pirmais = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadiet otro skaitli:  ");
               int OTRAIS = Convert.ToInt32(Console.ReadLine());

            if(Pirmais>OTRAIS)
            {
                Console.Write("Pirmais ir lielāks par otro");
            }

            else 

                    {
                Console.Write("Otrais ir lielāks par pirmo!");

                    }
        }
        

        static void Vecums()

        {

            int Vecums = Convert.ToInt32(Console.ReadLine());

            if (Vecums >=18)
            {
                Console.Write("Dodies tālāk!");
            }

            else
            {
                Console.Write("Nebūs!");

            }
        }




                static void Piemers()
                {
                    int skaitlis = Atgriezskaitli();
                    if (skaitlis > 10)
                    {
                        Console.Write("Skaitlis ir lielāks par 10");

                    }
                    else if (skaitlis == 10)

                    {
                        Console.Write("skaitlis ir vienāds ar 10");
                    }
                    else if (skaitlis == 9)

                    {
                        Console.Write("Skaitlis ir vienāds ar 9");
                    }
                    else
                    {
                        Console.Write("Skaitlis mazāks par 10");
                    }

                }
                static int Atgriezskaitli()
                {
                    return 5;
                }
            }
        }
