using BlackJackHelper.Logic.Enums;
using BlackJackHelper.Logic.Objects;

namespace BlackJackHelper.Logic.Engines
{
    public class DealerEngine
    {
        public ResultAction WhatShouldDealerDo(DealerHand hand)
        {
            if (hand.Value > 21)
            {
                return ResultAction.Bust;
            }
            if (hand.Value >= 17)
            {
                return ResultAction.Stand;
            }
            return ResultAction.Hit;
        }
    }
}
