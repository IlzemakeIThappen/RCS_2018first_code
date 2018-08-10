using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA4
{
    public class APLIS
    {
        public int Radius;

        public void Laukums()
        {
            double Laukums = Math.PI * Radius * Radius;
            Console.WriteLine("LAUKUMS =  " + Laukums);
            //trijsturim Math.Sqrt()
        }

        public void Perimetrs()
        {
            double Perimetrs = Math.PI*Radius*2;
            Console.WriteLine("laukums =  " + Perimetrs);
        }
    }
}
