using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Objects
{
    public class BaseHand
    {
        public List<Card> Cards { get; set; }

        public BaseHand()
        {
            Cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
        
        public bool IsBlackJack()
        {
            if (Cards.Count == 2)
            {
                var hasAce = false;
                var hasTen = false;
                foreach (var card in Cards)
                {
                    if (card == Card.Ace)
                    {
                        hasAce = true;
                    }
                    if (card == Card.Ten ||
                    card == Card.Jack ||
                    card == Card.Queen ||
                    card == Card.King)
                    {
                        hasTen = true;
                    }
                }

                return hasAce && hasTen;
            }
            return false;
        }

        public int Value
        {
            get
            {
                var val = 0;
                var aceCount = 0;
                foreach (var card in Cards)
                {
                    val += GetCardValue(card);
                    if (card == Card.Ace)
                    {
                        aceCount++;
                    }
                }

                if (aceCount > 0)
                {
                    for (var i = 0; i < aceCount; i++)
                    {
                        if (val <= 21)
                        {
                            break;
                        }
                        val -= 10;
                    }
                }

                return val;
            }
        }

        private int GetCardValue(Card card)
        {
            switch (card)
            {
                case Card.Two:
                    return 2;
                case Card.Three:
                    return 3;
                case Card.Four:
                    return 4;
                case Card.Five:
                    return 5;
                case Card.Six:
                    return 6;
                case Card.Seven:
                    return 7;
                case Card.Eight:
                    return 8;
                case Card.Nine:
                    return 9;
                case Card.Ten:
                    return 10;
                case Card.Jack:
                    return 10;
                case Card.Queen:
                    return 10;
                case Card.King:
                    return 10;
                default: return 11;
            }
        }
    }
}
