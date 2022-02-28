using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Engines.PlayerActions.Splits
{
    internal static class TwoAndThreeSplits
    {
        internal static ResultAction WhatDo(Card dealerFace)
        {
            switch (dealerFace)
            {
                case Card.Four:
                    return ResultAction.Split;
                case Card.Five:
                    return ResultAction.Split;
                case Card.Six:
                    return ResultAction.Split;
                case Card.Seven:
                    return ResultAction.Split;
                default:
                    return ResultAction.Hit;
            }
        }
    }
}
