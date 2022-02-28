using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Engines.PlayerActions.Hards
{
    internal static class TenHard
    {
        internal static ResultAction WhatDo(Card dealerFace)
        {
            switch (dealerFace)
            {
                case Card.Ten:
                    return ResultAction.Hit;
                case Card.Jack:
                    return ResultAction.Hit;
                case Card.Queen:
                    return ResultAction.Hit;
                case Card.King:
                    return ResultAction.Hit;
                case Card.Ace:
                    return ResultAction.Hit;
                default:
                    return ResultAction.DoubleOrHit;
            }
        }
    }
}
