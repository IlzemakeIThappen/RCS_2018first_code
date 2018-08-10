using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA4
{
    public class TAISNSTURIS
    {
        public int mala1;
        public int mala2;
        //laukums
        //perimetrs

        public void laukums()
        {
            Console.WriteLine("   Laukums  +   "  + mala1 * mala2);
        }

        public void perimetrs()
        {
            int perimetrs = (mala1 + mala2) * 2;
            Console.WriteLine("Perimetrs =   " + perimetrs);
        }
    }
}
