using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class Blackjack : Game
    {         
        public override int GetHandValue(List<Card> Hand)
        {
            int value = 0;
            foreach (Card card in Hand)
            {              
                value += card.Value;
            }
            if (value > 21) //Hard or Soft Ace 
            {
                foreach (Card card in Hand)
                {
                    if (card.Value == 11)
                    {
                        value -= card.Value;
                        card.Value = 1;
                        value += card.Value;
                    }
                }
            }          
            return value;
        }      

        private bool IsHandBlackjack(List<Card> Hand)
        {
            if (Hand.Count == 2)
            {
                if (Hand[0].CardNumber == CardNumber.Ace && Hand[1].Value == 10) 
                    return true;
                else if (Hand[1].CardNumber == CardNumber.Ace && Hand[0].Value == 10) 
                    return true;
            }
            return false;
        }

        public override void InitializeRound()
        {
            Deck.Reset();
            Deck.Cards.Select(card =>
            {
                switch (card.CardNumber)
                {
                    case CardNumber.Ace:
                        return card.Value = 11;
                    case CardNumber.Jack:
                        return card.Value = 10;
                    case CardNumber.Queen:
                        return card.Value = 10;
                    case CardNumber.King:
                        return card.Value = 10;
                    default:
                        return card.Value = (int)card.CardNumber;
                }
            }).ToList();

            Deck.Shuffle();

            Hands.PlayerHand = Deck.DealHand(2);
            Hands.HiddenCards = Deck.DealHand(2);
            Hands.RevealedCards = new List<Card>();
            
            Hands.DealerRevealCard();           
        }   
        public override void FinalizeRound()
        {
            Hands.DealerRevealCard();

            if (IsHandBlackjack(Hands.PlayerHand))
            {
                Casino.PayoutBet(2.5);
                Casino.EndRound(RoundResult.PLAYER_WIN);
                return;
            }
            else if (GetHandValue(Hands.PlayerHand) > 21)
            {
                Casino.EndRound(RoundResult.PLAYER_BUST);
                return;
            }
            while (GetHandValue(Hands.RevealedCards) <= 16)
            {
                Hands.RevealedCards.Add(Deck.DrawCard());
            }
            if (GetHandValue(Hands.PlayerHand) > GetHandValue(Hands.RevealedCards) || GetHandValue(Hands.RevealedCards) > 21)
            {                
                Casino.PayoutBet(2);               
                Casino.EndRound(RoundResult.PLAYER_WIN);
                return;
            }
            else if (GetHandValue(Hands.RevealedCards) > GetHandValue(Hands.PlayerHand))
            {
                Casino.EndRound(RoundResult.DEALER_WIN);                
            }
            else
            {
                Casino.EndRound(RoundResult.PUSH);
            }
        }            
    }
}
