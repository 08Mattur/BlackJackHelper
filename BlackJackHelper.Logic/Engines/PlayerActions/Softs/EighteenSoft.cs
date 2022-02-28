using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Engines.PlayerActions.Softs
{
    internal static class EighteenSoft
    {
        internal static ResultAction WhatDo(Card dealerFace)
        {
            switch (dealerFace)
            {
                case Card.Two:
                    return ResultAction.DoubleOrStand;
                case Card.Three:
                    return ResultAction.DoubleOrStand;
                case Card.Four:
                    return ResultAction.DoubleOrStand;
                case Card.Five:
                    return ResultAction.DoubleOrStand;
                case Card.Six:
                    return ResultAction.DoubleOrStand;
                case Card.Seven:
                    return ResultAction.Stand;
                case Card.Eight:
                    return ResultAction.Stand;
                default:
                    return ResultAction.Hit;
            }
        }
    }
}
