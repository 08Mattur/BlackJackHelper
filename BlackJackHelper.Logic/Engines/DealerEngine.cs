using BlackJackHelper.Logic.Objects;

namespace BlackJackHelper.Logic.Engines
{
    public class DealerEngine
    {
        public bool ShouldHit(Hand hand)
        {
            if (IsAbove17(hand))
            {
                return false;
            }
            return true;
        }

        private bool IsAbove17(Hand hand)
        {
            if (hand.Value >= 17){
                return true;
            }
            return false;
        }
    }
}
