using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DATA
{
    public class Dealer: Player
    {
        public override void GiverCard(Card card)
        {
            Cards.Add(card);
        }

        public override bool NeedCard()
        {
            // ja nav sasniegti 17 punkti, tad ir nepieciešama kārts
            return CountPoints() < 17;
        }
    }
}
