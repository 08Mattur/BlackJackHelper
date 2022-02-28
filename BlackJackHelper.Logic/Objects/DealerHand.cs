using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Objects
{
    public class DealerHand : BaseHand
    {
        public Card Upcard
        {
            get
            {
                return Cards[0];
            }
        }
    }
}
