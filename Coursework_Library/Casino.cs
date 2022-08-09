using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Coursework
{
    public enum RoundResult
    {
        PUSH,
        PLAYER_WIN,
        PLAYER_BUST,
        DEALER_WIN,
    }
    public class Casino
    {       
        public Player Player { get; set; }
        public Casino(Player player)
        {
            Player = player;
        }
        public void AddBet(int bet)
        {
            if (bet < 10)
                return;
            if (Player.Balance < bet)
                return;
            if (Player.Bet + bet > 500)
                return;
            Player.Bet += bet;
            Player.Balance -= bet;
        }
        public void DoubleBet()
        {
            Player.Balance -= Player.Bet;
            Player.Bet += Player.Bet;
        }
        private void ClearBet()
        {
            Player.LastWin = 0;
            Player.Bet = 0;
        }
        public void ReturnBet()
        {
            int lastWin = Player.LastWin;
            Player.Balance += Player.Bet;
            ClearBet();
            Player.LastWin = lastWin;
        }
        public void PayoutBet(double win)
        {
            int won = (int)Math.Floor(Player.Bet * win);
            ClearBet();
            Player.LastWin = won;
            Player.Balance += won;
        }
        public void StartRound()
        {
            Player.LastWin = 0;
            Player.LastBet = Player.Bet;
        }
        public void EndRound(RoundResult result)
        {
            switch (result)
            {
                case RoundResult.PUSH:
                    ReturnBet();
                    break;
                case RoundResult.PLAYER_WIN:
                    Player.Wins++;
                    break;
                case RoundResult.PLAYER_BUST:
                    ClearBet();
                    Player.Losses++;
                    break;                
                case RoundResult.DEALER_WIN:
                    ClearBet();
                    Player.Losses++;
                    break;                               
            }
        }
    }
}
