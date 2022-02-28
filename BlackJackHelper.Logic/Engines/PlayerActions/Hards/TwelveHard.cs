using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Engines.PlayerActions.Hards
{
    internal static class TwelveHard
    {
        internal static ResultAction WhatDo(Card dealerFace)
        {
            switch (dealerFace)
            {
                case Card.Four:
                    return ResultAction.Stand;
                case Card.Five:
                    return ResultAction.Stand;
                case Card.Six:
                    return ResultAction.Stand;
                default:
                    return ResultAction.Hit;
            }
        }
    }
}
