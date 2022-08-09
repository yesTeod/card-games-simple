using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class ThreeCardPoker : Game
    {
        public override string GetHandName(List<Card> Hand)
        {
            var hand = GetHandValue(Hand);
            var highCard = HighCard(Hand);
            var handName = "";

            switch (hand)
            {
                case 0:
                    switch (highCard)
                    {
                        case 11:
                            handName = "Jack High";
                            break;
                        case 12:
                            handName = "Queen High";
                            break;
                        case 13:
                            handName = "King High";
                            break;
                        case 14:
                            handName = "Ace High";
                            break;
                        default:
                            handName = HighCard(Hand).ToString() + " High";
                            break;
                    }
                    break;
                case 1:
                    handName = "Pair";
                    break;
                case 2:
                    handName = "Flush";
                    break;
                case 3:
                    handName = "Straight";
                    break;
                case 4:
                    handName = "Three of a kind";
                    break;
                case 5:
                    handName = "Straight Flush";
                    break;
                case 15:
                    handName = "Mini Royal";
                    break;
            }
            return handName;
        }
        public override int GetHandValue(List<Card> Hand)
        {
            if (IsPair(Hand))
                return 1;
            else if (IsThreeOfAKind(Hand))
                return 4;
            else if (IsStraight(Hand) && IsFlush(Hand)) // Straight Flush
            {
                if (IsAceStraight(Hand)) // Mini Royal
                    return 15;
                return 5;
            }
            else if (IsStraight(Hand))
                return 3;
            else if (IsFlush(Hand))
                return 2;
            return 0;
        }
        private bool IsStraight(List<Card> Hand)
        {
            return Hand.GroupBy(card => card.CardNumber).Count() == Hand.Count()
                && Hand.Max(card => (int)card.CardNumber) - Hand.Min(card => (int)card.CardNumber) == 2
                || IsAceStraight(Hand);
        }
        private bool IsAceStraight(List<Card> Hand)
        {
            return Hand.GroupBy(card => card.CardNumber).Count() == Hand.Count()
                && Hand.Max(card => (int)card.CardNumber) - Hand.Min(card => (int)card.CardNumber) == 12
                && Hand.Where(card => (int)card.CardNumber == 12 || (int)card.CardNumber == 2).Count() == 1;
        }
        private bool IsFlush(List<Card> Hand)
        {
            if (Hand.GroupBy(card => card.Suit).Count() == 1)
                return true;
            return false;
        }
        private bool IsThreeOfAKind(List<Card> Hand)
        {
            if (Hand.GroupBy(card => card.CardNumber).Count() == 1)
                return true;
            return false;
        }
        private bool IsPair(List<Card> Hand)
        {
            if (Hand.GroupBy(card => card.CardNumber).Count() == 2)
                return true;
            return false;
        }
        private int HighCard(List<Card> Hand)
        {
            if (Hand.Min(card => (int)card.CardNumber) == 1)
                return 14;
            return Hand.Max(card => (int)card.CardNumber);
        }
        public override void InitializeRound()
        {
            Deck.Reset();          

            Deck.Shuffle();

            Hands.PlayerHand = Deck.DealHand(3);
            Hands.HiddenCards = Deck.DealHand(3);
            Hands.RevealedCards = new List<Card>();

        }
        public override void FinalizeRound()
        {
            for (int i = Hands.HiddenCards.Count; i > 0; --i)
                Hands.DealerRevealCard();

            if (GetHandValue(Hands.PlayerHand) > GetHandValue(Hands.RevealedCards))
            {
                if (IsPair(Hands.PlayerHand))
                {
                    Casino.PayoutBet(2);
                    Casino.EndRound(RoundResult.PLAYER_WIN);
                    return;
                }
                Casino.PayoutBet(GetHandValue(Hands.PlayerHand));
                Casino.EndRound(RoundResult.PLAYER_WIN);
            }
            else if (GetHandValue(Hands.RevealedCards) > GetHandValue(Hands.PlayerHand))
            {
                Casino.EndRound(RoundResult.DEALER_WIN);
            }
            else
            {
                if (HighCard(Hands.PlayerHand) == HighCard(Hands.RevealedCards))
                    Casino.EndRound(RoundResult.PUSH);
                else if (HighCard(Hands.PlayerHand) > HighCard(Hands.RevealedCards))
                {
                    Casino.PayoutBet(2);
                    Casino.EndRound(RoundResult.PLAYER_WIN);
                    return;
                }
                Casino.EndRound(RoundResult.DEALER_WIN);
            }
        }       
    }
}
