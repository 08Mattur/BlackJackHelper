using BlackJackHelper.Logic.Objects;

namespace BlackJackHelper.Logic.Engines
{
    public class PlayerEngine
    {
        private int _playerHandValue = 0;
        private int _dealerHandValue = 0;

        public bool ShouldHit(Hand playerHand, Hand dealerHand)
        {
            _playerHandValue = playerHand.Value;
            _dealerHandValue = dealerHand.Value;

            if (playerHand.IsSoft)
            {
                return ShouldHitWhenSoft();
            }

            if(_dealerHandValue < 7)
            {
                return ShouldHitWhenDealerLow();
            }

            return ShouldHitWhenDealerHigh();
        }

        private bool ShouldHitWhenSoft()
        {
            if (_playerHandValue >= 19)
            {
                return false;
            }

            return true;
        }

        private bool ShouldHitWhenDealerLow()
        {
            if (_playerHandValue >= 12)
            {
                return false;
            }
            return true;
        }

        private bool ShouldHitWhenDealerHigh()
        {
            if (_playerHandValue >= 17)
            {
                return false;
            }
            return true;
        }
    }
}
