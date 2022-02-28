using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Objects
{
    public class PlayerHand : BaseHand
    {
        public bool IsSoft
        {
            get
            {
                if (Cards.Count >= 2 && Value < 21)
                {
                    foreach (var card in Cards)
                    {
                        if (card == Card.Ace)
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
                    if (Cards[0] == Cards[1])
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
