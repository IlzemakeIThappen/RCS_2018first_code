using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA4
{
    
    public class AUTO
    {
        //auto īpašība-krāsa
        public String Krasa;
        //auto īpašība max ātrums
        public int MaxAtrums;

        public void Braukt()
        {
            Console.WriteLine("Auto brauc! MaxAtrums = " + MaxAtrums);
        }
        public void KrasasNoteiksana()
        {
            Console.WriteLine("auto ir  " + Krasa + "krāsā");
        }
        public static void BrauktStatic(int maxAtrums)
        {
            Console.WriteLine();
        }
    }
}
