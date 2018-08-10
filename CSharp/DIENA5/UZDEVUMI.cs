using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA5
{
    public class UZDEVUMI
    {

        public static void uzdevums28()
        {
            List<PRECE> saraksts = new List<PRECE>();
            saraksts.Add(new PRECE("Dators", 900));

            //List<PRECE> saraksts = new List<PRECE>();
            saraksts.Add(new PRECE("Bikses", 50));

            //List<PRECE> saraksts = new List<PRECE>();
            saraksts.Add(new PRECE("Auto", 10000));

            //List<PRECE> saraksts = new List<PRECE>();
            saraksts.Add(new PRECE("Mobilais", 200));

            //List<PRECE> saraksts = new List<PRECE>();
            saraksts.Add(new PRECE("TV", 550));

            //List<PRECE> saraksts = new List<PRECE>();
            saraksts.Add(new PRECE("Koferis", 100));

            //List<PRECE> saraksts = new List<PRECE>();
            saraksts.Add(new PRECE("Cimdi", 20));

            //List<PRECE> saraksts = new List<PRECE>();
            saraksts.Add(new PRECE("Cepure", 10));

            Console.WriteLine("Pieejamās preces:  ");
            foreach (var p in saraksts)
            {
                Console.WriteLine(p.Nosaukums + "  $" + p.Cena);
            }
            int summa = 0;
            while (true)
            {
                Console.Write("Ievadi preci vai 0, lai pārtrauktu:  ");
                string nosaukums = Console.ReadLine();
                if (nosaukums == "0")
                {
                    break;
                }

                foreach (var pr in saraksts)
                {
                    if (pr.Nosaukums.Equals(nosaukums, StringComparison.OrdinalIgnoreCase))
                    {
                        summa += pr.Cena;
                        break;
                    }
                }
            }
            Console.Write("Summa = $" + summa);
        }
        // jāizvada viss katalogs foreach
        //2. lietotājs ievada preces nosaukumu un ievadi pārtrauc ar 0 if() un while()
        //2.1. while cikļā jāatrod ievadītā prece kataloga (pec nosaukuma) - foreach
        //2.2. paņem atrastās preces cenu un piesaista kopsummai
        //3. IZVADA KOPSUMMU





        public static void uzdevums27()
        {
            List<int> saraksts = new List<int>();
            while (true)
            {
                Console.Write("Ievadiet skaitli vai izejiet ar 0:  ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                if (skaitlis == 0) ;
                {
                    break;
                    //pārtrauc while ciklu
                }

                //izvadiet min un max
                //int min = saraksts.min();
                //int max = saraksts.max();
                int min = saraksts[0];
                int max = saraksts[0];

                //5,3,10 -> izvadīs 0
                foreach (int skaitlis in saraksts)
                {
                    if (skaitlis < min)
                    {
                        min = skaitlis;

                    }
                    else if (skaitlis > max)
                    {
                        max = skaitlis;
                    }
                }
                saraksts.Add(skaitlis);

            }
        }

        public static void uzdevums26()
        {
            List<int> saraksts = new List<int>();
            while (true)
            {
                Console.Write("Ievadiet skaitli vai izejiet ar 0:  ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                if (skaitlis == 0) ;
                {
                    break;
                    //pārtrauc while ciklu
                }
                saraksts.Add(skaitlis);
                int skaits = 0;
                foreach (int skaitlis in saraksts)
                {
                    if (skaitlis == 5)
                    {
                        skaitlis++;
                    }
                }
                Console.Write("Sarakstā ir:  " + skaitlis);
            }
        }

        public static void uzdevums25()
        {
            List<int> saraksts = new List<int>();
            while (true)
            {
                Console.Write("Ievadiet skaitli vai izejiet ar 0:  ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                if (skaitlis == 0) ;
                {
                    break;
                    //pārtrauc while ciklu
                }
                saraksts.Add(skaitlis);
            }
            for (int i = saraksts.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(saraksts[i]);
            }
        }
        public static void uzdevums24()
        {
            int[] saraksts = new int[5];

            int[] skaitli = { 0, 10, 20, 30, 40, 50 };

            for (int i = 0; i < saraksts.Length; i++)
            {
                //izvada skaitli pozīcijā i
                Console.WriteLine(saraksts[i]);
            }


            Console.Write("Ievadiet skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < skaitli.Length; i++)
                if (skaitlis == skaitli[i])
                {
                    Console.Write("Skaitlis atrast pozīcijā: " + i);
                    return;
                }


            Console.Write("skaitlis masīvā nav atrasts!");
        }
    }
}


