using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Engines.PlayerActions.Hards
{
    internal static class NineHard
    {
        internal static ResultAction WhatDo(Card dealerFace)
        {
            switch (dealerFace)
            {
                case Card.Three:
                    return ResultAction.DoubleOrHit;
                case Card.Four:
                    return ResultAction.DoubleOrHit;
                case Card.Five:
                    return ResultAction.DoubleOrHit;
                case Card.Six:
                    return ResultAction.DoubleOrHit;
                default:
                    return ResultAction.Hit;
            }
        }
    }
}
