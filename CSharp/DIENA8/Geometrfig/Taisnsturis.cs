using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA8.Geometrfig
{
    public class Taisnsturis : Geometriskafigura
    {
        public double Mala1;
        public double Mala2;

        public Taisnsturis(double mala1, double mala2)
        {
            Mala1 = mala1;
            Mala2 = mala2;
        }
        public void laukums()
        {
            double laukums = Mala1 * Mala2;
            Console.WriteLine("Laukums =  " + laukums);
        }

        public double perimetrs()
        {
            double perimetrs = 2 * (Mala1 + Mala2);
            return perimetrs;
        }

    }
}
