using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public enum Suit
    {
        Club = 1,
        Diamond = 2,
        Heart = 3,
        Spades = 4,
    }
    public enum CardNumber
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }
    public class Card
    {
        public Suit Suit { get; set; }
        public CardNumber CardNumber { get; set; }
        public int Value { get; set; }
        public string Image { get; set; }           
    }
}
