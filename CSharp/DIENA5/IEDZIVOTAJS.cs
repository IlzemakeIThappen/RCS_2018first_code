using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA5
{
    public class IEDZIVOTAJS
    {
        public string Vards;
        public string Uzvards;

        //strukturēta adrese
        public ADRESE Dzivesvieta;
        public void Apraksts()
        {
            Console.Write(Vards  + " " + Uzvards + "    dzīvo  " + Dzivesvieta.PilnaAdrese());
        }
    }

}
