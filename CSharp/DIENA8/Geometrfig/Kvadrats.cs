using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA8
{
    public class Kvadrats: Geometrfig.Taisnsturis
    {
        public Kvadrats(double mala)
            //base() - izsaukts virsklases konstruktors
            : base(mala,mala)
        {

        }
      /* public double MalasGarums;

        public Kvadrats(double mala)
        {
            MalasGarums = mala;
        }

        public double perimetrs()
        {
            double perimetrs = MalasGarums* 4;
            return perimetrs;
        }

        void Geometriskafigura.laukums()
        {
            double laukums = MalasGarums * MalasGarums;
            Console.WriteLine("Laukums =  " + laukums);
        }  
        */
    }
}
