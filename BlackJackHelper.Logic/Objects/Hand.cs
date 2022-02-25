using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Objects
{
    public class Hand
    {
        public Hand()
        {
            Cards = new List<Card>();
        }

        private int GetCardValue(Card card)
        {
            switch (card.Face)
            {
                case Face.Two:
                    return 2;
                case Face.Three:
                    return 3;
                case Face.Four:
                    return 4;
                case Face.Five:
                    return 5;
                case Face.Six:
                    return 6;
                case Face.Seven:
                    return 7;
                case Face.Eight:
                    return 8;
                case Face.Nine:
                    return 9;
                case Face.Ten:
                    return 10;
                case Face.Jack:
                    return 10;
                case Face.Queen:
                    return 10;
                case Face.King:
                    return 10;
                default: return 11;
            }
        }

        public List<Card> Cards { get; set; }

        public int Value
        {
            get
            {
                var val = 0;
                var hasAce = false;
                foreach (var card in Cards)
                {
                    val += GetCardValue(card);
                    if (card.Face == Face.Ace)
                    {
                        hasAce = true;
                    }
                }

                if (val > 21 && hasAce)
                {
                    val -= 10;
                }

                return val;
            }
        }

        public bool IsSoft
        {
            get
            {
                if (Cards.Count == 2)
                {
                    foreach (var card in Cards)
                    {
                        if (card.Face == Face.Ace)
                        {
                            return true;
                        }
                    }
                }                
                return false;
            }
        }

        public bool IsPair
        {
            get
            {
                if (Cards.Count == 2)
                {
                    if (Cards[0].Face == Cards[1].Face)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
    }
}
