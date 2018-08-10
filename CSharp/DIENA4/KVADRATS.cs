using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA4
{
    public class KVADRATS
    {              
            public String krasasnosaukums;
            public int malasgarums;
            
        

        public void krasasnoteiksana()
        {
            Console.WriteLine("kvadrāts ir  " + krasasnosaukums  +  "   krāsā");
        }

        public void laukums()
        {
            int laukums = malasgarums + malasgarums;
        }

        public void perimetrs()
        {
            Console.WriteLine("Perimetrs =   " + malasgarums * malasgarums);
        }


        


    }
}
