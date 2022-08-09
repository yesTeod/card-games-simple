using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public abstract class Action
    {              
        public string Image { get; private set; }        
        public Action(string image)
        {
            Image = image;
        }
        public abstract void DoAction(Game game);
        public abstract string SetName(Game game);
    }
    public class Hit : Action
    {
        public Hit() 
            : base("hit.png")
        {
        }       
        public override void DoAction(Game game)
        {
            if (game.GetHandValue(game.Hands.PlayerHand) >= 21)
            {
                game.FinalizeRound();
                return;
            }
            game.Hands.PlayerHand.Add(game.Deck.DrawCard());          
        }
        public override string SetName(Game game)
        {
            if(game.GetHandValue(game.Hands.PlayerHand) >= 21)
            {
                return "Hit";
            }
            return "HitContinue";
        }
    }
    public class Double : Action
    {
        public Double()
            : base("double.png")
        {
        }
        public override void DoAction(Game game)
        {
            if (game.Casino.Player.Balance < game.Casino.Player.Bet * 2)
            {
                game.Hands.PlayerHand.Add(game.Deck.DrawCard());
                return;
            }
            game.Casino.DoubleBet();

            game.Hands.PlayerHand.Add(game.Deck.DrawCard());

            game.FinalizeRound();
        }
        public override string SetName(Game game)
        {
            if (game.Casino.Player.Balance < game.Casino.Player.Bet * 2)
            {
                game.Hands.PlayerHand.Add(game.Deck.DrawCard());
                return "DoubleContinue";               
            }
            return "Double";
        }
    }
    public class StandBJ : Action
    {
        public StandBJ()
            : base("stand.png")
        {           
        }      
        public override void DoAction(Game game)
        {
            game.FinalizeRound();
        }
        public override string SetName(Game game)
        {
            return "StandBJ";
        }
    }
    public class StandPoker : Action
    {
        public StandPoker()
            : base("stand.png")
        {            
        }
        public override void DoAction(Game game)
        {
            for (int i = game.Hands.HiddenCards.Count; i > 0; --i)
                game.Hands.DealerRevealCard();
            game.Casino.EndRound(RoundResult.DEALER_WIN);
        }
        public override string SetName(Game game)
        {
            return "StandPoker";
        }
    }
    public class Play : Action
    {
        public Play()
            : base("yes_all.png")
        {            
        }       
        public override void DoAction(Game game)
        {
            game.Casino.DoubleBet();

            game.FinalizeRound();
        }
        public override string SetName(Game game)
        {
            return "Play";
        }
    }    
}
