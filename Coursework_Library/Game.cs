using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public abstract class Game
    {
        public List<Action> actions;
        public Game()
        {
            actions = new List<Action>();
        }
        public void RegisterAction(Action action)
        {
            actions.Add(action);
        }
        public Deck Deck = new Deck();
        public Hands Hands = new Hands();      
        public Casino Casino { get; set; }
        public virtual string GetHandName(List<Card> Hand)
        {
            return GetHandValue(Hand).ToString();
        }        
        public abstract int GetHandValue(List<Card> Hand);
        public abstract void InitializeRound();
        public abstract void FinalizeRound();
    }
}
