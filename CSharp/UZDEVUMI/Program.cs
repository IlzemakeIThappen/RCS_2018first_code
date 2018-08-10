using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA1_UZDEVUMI
{
    class Program
    {
        static void Main(string[] args)
        {
            //VardaIzvade();
            //SkaitluSumma();
            //Gradi();
            //Starpiba();
            //Reizinajums();
            //Dalijums();
            //Reizinajums3();
            //DalijumaAtlikums();
                      
              
        }

        


        static void DalijumaAtlikums()
        {
            //paprasa ievadīt pirmo skaitli
            Console.Write("Ievadi 1.skaitli:  ");
            int Pirmais = Convert.ToInt32(Console.ReadLine());

            //paprasa ievadīt otro skaitli
            Console.Write("Ievadi 2.skaitli:  ");
            int Otrais = Convert.ToInt32(Console.ReadLine());
           
            //definējam darbibu
            int Rezultats7 = Pirmais /  Otrais;
            int Atlikums = Pirmais % Otrais;
            //izvada skaitļu summu
            Console.Write("Rezultats: " + Rezultats7  + "   Atlikums:" + Atlikums );

            Console.ReadLine();

           
        }
        static void Reizinajums3()
        {
            //paprasa ievadīt pirmo skaitli
            Console.Write("Ievadi 1.skaitli:  ");
            int Pirmais = Convert.ToInt32(Console.ReadLine());

            //paprasa ievadīt otro skaitli
            Console.Write("Ievadi 2.skaitli:  ");
            int Otrais = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi 3.skaitli: ");
            int Tresais = Convert.ToInt32(Console.ReadLine());
            //definējam darbibu
            int Rezultats4uzd = Pirmais * Otrais * Tresais ;
            //izvada skaitļu summu
            Console.Write("Rezultats: " + Rezultats4uzd);

            Console.ReadLine();

          
        }
        static void Dalijums()
        {
            //paprasa ievadīt pirmo skaitli
            Console.Write("Ievadi 1.skaitli:  ");
            int Pirmais = Convert.ToInt32(Console.ReadLine());

            //paprasa ievadīt otro skaitli
            Console.Write("Ievadi 2.skaitli:  ");
            int Otrais = Convert.ToInt32(Console.ReadLine());


            //definējam darbibu
            int Rezultats4 = Pirmais /  Otrais;
            //izvada skaitļu summu
            Console.Write("Rezultats: " + Rezultats4);

            Console.ReadLine();
          
     
        }
        static void Reizinajums()
        {
            //paprasa ievadīt pirmo skaitli
            Console.Write("Ievadi 1.skaitli:  ");
            int Pirmais = Convert.ToInt32(Console.ReadLine());

            //paprasa ievadīt otro skaitli
            Console.Write("Ievadi 2.skaitli:  ");
            int Otrais = Convert.ToInt32(Console.ReadLine());

            int Rezultats3 = Pirmais * Otrais;
            Console.Write("Rezultats: " + Rezultats3);
            Console.ReadLine();

        }
        static void Starpiba()
        {
            //paprasa ievadīt pirmo skaitli
            Console.Write("Ievadi 1.skaitli:  ");
            int Pirmais = Convert.ToInt32(Console.ReadLine());

            //paprasa ievadīt otro skaitli
            Console.Write("Ievadi 2.skaitli:  ");
            int Otrais = Convert.ToInt32(Console.ReadLine());

            int Rezultats2 = Pirmais - Otrais;
            Console.Write("Rezultats: " + Rezultats2);
            Console.ReadLine();

        }
        static void SkaitluSumma()
        {
            //paprasa ievadīt pirmo skaitli
            Console.Write("Ievadi 1.skaitli:  ");
            int Pirmais = Convert.ToInt32(Console.ReadLine());

            //paprasa ievadīt otro skaitli
            Console.Write("Ievadi 2.skaitli:  ");
            int Otrais = Convert.ToInt32(Console.ReadLine());


            //definējam darbibu
            int Rezultats = Pirmais + Otrais;
            //izvada skaitļu summu
            Console.Write("Rezultats: " + Rezultats);

            Console.ReadLine();

            

        }
        static void Gradi()
        {

            //ievade
            Console.Write("Ievadi grādus pēc Celsija:   ");
            int Celsijs = Convert.ToInt32(Console.ReadLine());

            //izvade
            int kelvini = Celsijs + 273;
            float Farenheiti = Celsijs * 1.8f + 32;

            Console.WriteLine("Kelvini = " + kelvini);
            Console.WriteLine("Farenheiti =  " + Farenheiti);

            Console.ReadLine();
           
        }
        

        static void VardaIzvade()
        {
            //teksta izvade
            Console.Write("Ievadi vārdu: ");

            //teksta ievade
            string vards = Console.ReadLine();

            Console.Write("Ievadi uzvārdu: ");
            string uzvards = Console.ReadLine();

            //vecuma ievade
            Console.Write("Ievadi vecumu: ");
            int vecums = Convert.ToInt32(Console.ReadLine());

            //vēl viens variants, ja tikai jānolasa... string vecumsStrings = console.Readline();

            //teksta izvade
            Console.Write("Tevi sauc: " + vards + "  " + uzvards+ "   " + "Tavs vecums:  " + vecums + "gadi");

            //lai konsoles logs paliek atvērts
            Console.ReadLine();
           
        }

    }
}
