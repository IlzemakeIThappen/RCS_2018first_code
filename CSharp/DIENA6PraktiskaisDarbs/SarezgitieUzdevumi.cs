using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA6PraktiskaisDarbs
{

    public class Sarezgitieuzdevumi
    {
           //public static void KARATAVAS()
        //{
                 //ĪPAŠĪBAS:
                //1.vardu saraksts(
           List<string> Vardi;
            //2.minamais vārds (char[])PIEMREAM AKA
            char[] MinamaisVards;
            //3.atminētais vārds (char[]), piemeram _K_
            char[] AtminetaisVards;
            int AtlikusieMeginajumi;
            //KONSTRUKTORS:
            //1.AIZpilda vārdu sarakstu
            public void Karatavas()
            { 
                Vardi = new List<string>()
                {
                    "APPLE",
                    "SUN",
                    "ICE",
                };

            }
            //METODES:
            //1.UZSĀKT jaunu spēli
            //1.1 random jaizvēlas vārds no saraksta
            //1.2 aizpildīt minamais vārds ar vārda burtiem
            //1.3 aizpildīt atminētais vārds ar '_'
            //1.4 lietotājam izvada 'atminetais vards' saturu
            public void StartNewGame()
            {
               Random rnd = new Random();
               Vardi = Vardi.OrderBy(v => rnd.Next()).ToList();
               string vards = Vardi[0];
               MinamaisVards = new char[vards.Length];
               AtminetaisVards = new char[vards.Length];

              for ( int i=0; i< vards.Length; i++)
              {
               MinamaisVards[i] = vards[i];
               AtminetaisVards[i] = '_';
               }
              Console.WriteLine(String.Join("  ", AtminetaisVards));
              }
   
            //2. minētburtu, saņem vienu parametru - burtu
            //2.1 pārbaudīt vai burts ir 'minamais vards' masīvā
            //2.2 ja ir, tad aizstāj 'atminētais vārds' svītriņu tajā pašā pozīcijā ar burtu (for cikls)
            public void MinetBurtu(char burts)
            {
              bool vaiIrVarda = false;
                for (int i = 0; i < MinamaisVards.Length; i++)
                {
                    if (MinamaisVards[i] == burts)
                    {
                        AtminetaisVards[i] = burts;
                    }
                }

                if(vaiIrVarda)
                {
                Console.WriteLine(String.Join(" ", AtminetaisVards));
                }
                else
                {
                Console.WriteLine("Burts nav šajā vārdā");
                 AtlikusieMeginajumi--;
                }
            }
            public bool VaiIrAtminets()
                {

                }
            //3.vai vards ir atminets
            //3.1.vai 'atminetais vards' satur'_'
            public bool VaiIrIzmantots()
            {
            bool irAtminets = false;
            foreach(char burts in AtminetaisVards)
            {
                if (burts == '_')
                {
                    irAtminets = false;
                    break;
                }
            }
            return irAtminets;
        }

            /* Definējiet masīvu ar vārdiem. 
             * Izvēlieties nejaušu vārdu no masīva un izvadiet lietotājam burtu skaitu vārdā. 
             * Ļaujiet lietotājam ievadīt kādu burtu un attēlojiet šo burtu atbilstošajās pozīcijās, 
             * ja tāds eksistē, vai arī samaziniet atlikušo gājienu skaitu, ja dotais burts šajā vārdā neeksistēja.
             * Izvadiet atbilstošu paziņojumu, vai vārds tika uzminēts, vai nē.
              Piemēram, izvēlēts vārds “AKA”. Sākumā lietotājam izvadiet “_ _ _”.
              Pēc pareizas burta ievades attēlojiet “A _ A”, bet pēc nepareizas burta ievades attēlojiet “Burts S nav šajā vārdā. 
              Jums atlikuši 4 mēģinājumi”.
         */
        
    }
}
