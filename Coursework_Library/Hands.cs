using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class Hands
    {
        public List<Card> PlayerHand { get; set; } = new List<Card>();
        public List<Card> HiddenCards { get; set; } = new List<Card>();
        public List<Card> RevealedCards { get; set; } = new List<Card>();
        public void DealerRevealCard()
        {
            RevealedCards.Add(HiddenCards[0]);
            HiddenCards.RemoveAt(0);
        }
    }
}
