using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIENA4
{
    class Program
    {
        //static void Main(string[] args)

        // {
        //Piemers();
        //KVADRATS();

        // Console.ReadLine();

        // }
        static void SKOLENS(string[] args)
        {

        }
        static void TRIJSTURIS (string[] args)
        {
            TRIJSTURIS t = new TRIJSTURIS();
            t.MALA1 = 3;
            t.MALA2 = 4;
            t.MALA3 = 7;
            t.Perimetrs();
            t.Laukums();

            Console.ReadLine();
        }

        static void APLIS(string[] args)
        {
            APLIS APL = new APLIS();
            APL.Radius = 6;
            APL.Laukums();
            APL.Perimetrs();
            Console.ReadLine();
        }

        static void TAISNSTURIS(string[] args)
        {
            TAISNSTURIS taisn = new TAISNSTURIS();
            taisn.mala1 = 5;
            taisn.mala2 = 10;
            taisn.laukums();
            taisn.perimetrs();

            Console.ReadLine();

        }

        static void KVADRATS(string[] args)
        {
            KVADRATS KV1 = new KVADRATS();
            KV1.krasasnosaukums = "ZAĻA";
            KV1.malasgarums = 5;
            KV1.laukums();
            KV1.perimetrs();
            KV1.krasasnoteiksana();

            Console.ReadLine();
            //TAISNSTŪRIS APLIS TRIJSTŪRIS
            //taisnsturis mala1 mala2 +laukums + perimetrs
            //aplis - radius
        }

        static void Piemers(string[] args)
        {
            //auto1 un auto 2 ir objekts
            //auto ir klase
            AUTO auto1 = new AUTO();
            auto1.MaxAtrums = 200;
            auto1.Krasa = "MELNĀ";
            auto1.Braukt();
            auto1.KrasasNoteiksana();

            AUTO auto2 = new AUTO();
            auto2.MaxAtrums = 150;
            auto2.Krasa = "SARKANĀ";
            auto2.Braukt();
            auto2.KrasasNoteiksana();


            Console.ReadLine();
        }
    }
}
