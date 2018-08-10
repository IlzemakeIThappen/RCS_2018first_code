using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA8
{
    public class Aplis : Geometriskafigura
    {

        public double Radiuss;
        
        public Aplis(double radiuss)
        {
            this.Radiuss = radiuss;
        }
                 
        public void laukums()
        {
            double laukums = Math.PI * Radiuss * Radiuss;
            Console.WriteLine("Laukums ir   " + laukums);
        }

        public double perimetrs()
        {
        double perimetrs = 2 * Math.PI * Radiuss;
        return perimetrs;
        }
    }
}
