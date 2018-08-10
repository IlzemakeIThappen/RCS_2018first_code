using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DATA
{
    public class Card
    {
        //īpašība masts string  suit
        public string Suit;
        //īpašība vērtība string value
        public string Value;
        //konstruktors aizpilda abas īpašības
        public Card(string suit, string value)
        {
        Suit = suit;
        Value = value;
        }
        //getPoints() atgriež kārts skaitlisko vērtību
        public int GetPoints()
            {
          switch(Value)
            {
            case "A":
                 return 11;
            case "K":
            case "Q": 
            case "J":
                 return 10;
            default:
               return Int32.Parse(Value);
            //return convert.toint32(value);
            }
         }
    }
}
