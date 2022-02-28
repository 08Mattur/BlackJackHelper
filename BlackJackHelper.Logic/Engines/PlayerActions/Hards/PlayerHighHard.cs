using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Engines.PlayerActions.Hards
{
    internal static class PlayerHighHard
    {
        internal static ResultAction WhatDo(Card dealerFace)
        {
            switch (dealerFace)
            {
                case Card.Two:
                    return ResultAction.Stand;
                case Card.Three:
                    return ResultAction.Stand;
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
