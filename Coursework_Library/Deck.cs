using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class Deck
    {
        public Deck()
        {
            Reset();
        }
        public List<Card> Cards { get; set; }
        public void Reset()
        {
            Cards = Enumerable.Range(1, 4)
                .SelectMany(s => Enumerable.Range(1, 13)
                                    .Select(c => new Card()
                                    {
                                        Suit = (Suit)s,
                                        CardNumber = (CardNumber)c,
                                        Image = $"{s}{c}.png"
                                    }
                                           )
                            )
                   .ToList();
        }
        public void Shuffle()
        {
            Cards = Cards.OrderBy(c => Guid.NewGuid()).ToList();
        }
        public Card DrawCard()
        {
            var card = Cards.FirstOrDefault();
            Cards.Remove(card);

            return card;
        }
        public List<Card> DealHand(int handSize)
        {           
            List<Card> hand = new List<Card>();
            for(int i = 0; i<handSize;++i)
            {
                hand.Add(Cards[i]);
            }
           
            Cards.RemoveRange(0, handSize);

            return hand;
        }
    }
}
