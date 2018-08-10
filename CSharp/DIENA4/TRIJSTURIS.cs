using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA4
{
    class TRIJSTURIS
    {
        public int MALA1;
        public int MALA2;
        public int MALA3;

        public void Perimetrs()
        {
            int perimetrs = MALA1 + MALA2 + MALA3;
            Console.WriteLine("Perimetrs ir   " + perimetrs);
        }

        public void Laukums()
        {
            double p = (double)(MALA1 + MALA2 + MALA3) / 2;
            double laukums = Math.Sqrt(p*(p-MALA1)*(p-MALA2)*(p-MALA3));
            Console.WriteLine("Laukums = " + laukums);

        }
    }
}
