using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENATRIS
{
    public class TRAKIEMASIVI
    {

        public static void whilepiemers()
        {
            //lietotājs ievada skaitļus
            //ievadi pārtrauc ar -1
            int sk = 0;
            int summa = 0;
            while(sk != -1)
            {
                Console.Write("ievadiet skaitli vai - 1, lai pārtrauktu");
                sk = Convert.ToInt32(Console.ReadLine());

                //ja mēs gribam summēt
                if(skaitlis != -1)
                {
                      summa += sk;
                    //summa = summa+sk
                }
                
            }
            Console.Writeline("summa = " + summa);
            int summa2 = 0;
            while(true)
            {
                Console.Write( "Ievadi skaitli vai -1, lai pārtrauktu: ")
                    int sk2 = Convert.ToInt32(Console.ReadLine());
                if(sk2 == -1)
                {
                    break;
                }
                else
                {
                    summa2 += sk2;
                }
                    }
            Console.Writeline("summa2: " + summa2);
        }



        public static void uzdevums20()

        {
            Console.Write("Ievadi skaitli:  ");
            int n = Convert.ToInt32(Console.ReadLine());

            /*
            n=4;
            r=1; a=3=n-r; z=1 =2*r -1;
            r=2; a=2;     z=3
            r=3; a=1;     z=5
            r=4; a=0;     z=7
             r=3
             r=2
             r=1
             */
            //apstrādā katru rindiņu
            for (int r = 1; r <= n; r++)
            {
                //attēlo tukšumu trijsūtim
                for (int a = 1; a <= n - r; a++)
                {
                    Console.Write("   ");
                }
                //attēlo zvaigznītes
                for (int z = 1; z <= 2 * r - 1; z++)
                {
                    Console.Write("*");
                }
                //pārejam jaunā rindā
                Console.WriteLine();
            }
            for (int r=n-1; r >=1; r--)
            {
                for (int a=1; a<=n-r; a++)
            
            {
                    Console.Write("   ");
            }
        }
            public static void uzdevums19()
        {
            Console.Write("Ievadi rindu skaitu:  ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int rinda=1; rinda<=n;rinda++)
            {
                for(int sk=1;sk <=rinda;sk++)
                {
                    Console.Write(sk);
                }
                Console.WriteLine();
            }
        }

        public static void uzdevums18()
        {

            Console.Write("Ievadi N: ");
            int skaits = Convert.ToInt32(Console.ReadLine());

            int i, j, inp;
            int[,] arr1 = new int[skaits, skaits];

           Console.Write("\n\nInput value");
            inp = Convert.ToInt32(Console.ReadLine());

            //  Console.Write("\n\nRead a 2D array of size 3x3 and print the matrix :\n");
            //  Console.Write("------------------------------------------------------\n");  


            /* Stored values into the array*/
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < inp; i++)
            {
                for (j = 0; j < inp; j++)
                {
                    // Console.Write("element - [{0},{1}] : ",i,j);
                    arr1[i, j] = inp;
                }
            }

            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < inp; i++)
            {
                Console.Write("\n");
                for (j = 0; j < inp; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");
        }
    


    //var numbers = new int[skaits, skaits];

    //for (var i = 0; i < skaits; i++)
    //{
    //  var numList = new string[skaits];
    //numList = ReadLine.Split();
    //for (var j = 0; j < skaits; j++)
    //{
    //  numbers[i, j] = Convert.ToInt32(numList[j]);
    //}
    //}
    //int kolonna = 0;

    //for (int i = 1; i <= skaits; i++)

    //kolonna += 1;
    // Console.WriteLine(i);
    //int rezgis = skaits * skaits;
    // Console.WriteLine(rezgis);

    //   Console.Write(kolonna);
    // int skaitlis = Convert.ToInt32(Console.ReadLine());
    // for (int i = 1; i <= skaitlis; i++)

    // int MATRIX_ROWS = skaits;
    //int MATRIX_COLUMNS = skaits;

    //double[,] matrix = new double[MATRIX_ROWS, MATRIX_COLUMNS];


    //for (int i = 0; i < MATRIX_ROWS; i++)
    //{
    //  for (int j = 0; j < MATRIX_COLUMNS; j++)
    //{
    //  double input;
    //Console.Write("Enter value for ({0},{1}): ", i, j);
    //while (!double.TryParse(Console.ReadLine(), out input))
    //{
    //  Console.Write("Enter correct value for ({0},{1}): ", i, j);
    //}
    //matrix[i, j] = input;

    //}
    //}








public static void uzdevums17()
        {
            Console.Write("Ievadi, cik būs skaitļi: ");
            int daudzums = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi šos skaitļus: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            int summa = 0;
            int videja = 0;

            for(int i=1; i<=skaitlis;i++)
            {
                Console.Write("Ievadi skaitli: ");
                int sk = Convert.ToInt32(Console.ReadLine())
                    //palielinām summu par ievadīto skaitli
                    summa += sk;
                //+= ir summa = summa + skaitlis
            }
            videja = (double)summa / skaitlis;
            Console.WriteLine("summa = " + summa);
            Console.WriteLine("vid = " + videja);
            
            }
            //do while
            //Console.Write(skaitlis);
            //for (int i=1; i<= daudzums; i++)
            //int i = Console.ReadLine();
            //int skaits = Convert.ToInt32(Console.ReadLine())
            //while (i<=daudzums)
            //Console.ReadLine();


            //while (skaitlis = daudzums)


        


        public static void Nsumma16()
        {
            Console.Write("Ievadi N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int SUMMA = 0;

            for (int i = 1; i <= N; i++)
            {
                SUMMA += 1;
                Console.WriteLine(i);

                Console.Write("Summa =  " + SUMMA);
            }
        }


        public static void kvadrati15()
        {
            Console.Write("Ievadi skaitu: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= skaitlis; i++)

            {
                int kvadrats = i * i;
                Console.WriteLine(i + "=>" + kvadrats);
            }

        }


        public static void gadi14()
        {
            Console.Write("Ievadi gadu:  ");
            int gads = Convert.ToInt32(Console.ReadLine());
            for (int i = gads; i <= DateTime.Now.Year; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void naturali13()
        {

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }


        }

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
    }

}
