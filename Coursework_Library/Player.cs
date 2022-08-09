using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    [Serializable]
    public class Player
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }        
        public int Bet { get; set; }
        public int LastWin { get; set; }
        public int LastBet { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        
        public double WinRate
        {
            get
            {
                if (Wins + Losses == 0)
                    return 0;
                return Math.Round((double)(100 * Wins) / (Wins + Losses),2);
            } 
        }
    }
}
