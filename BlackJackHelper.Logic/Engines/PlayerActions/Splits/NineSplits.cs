using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Engines.PlayerActions.Splits
{
    internal static class NineSplits
    {
        internal static ResultAction WhatDo(Card dealerFace)
        {
            switch (dealerFace)
            {
                case Card.Seven:
                    return ResultAction.Stand;
                case Card.Ten:
                    return ResultAction.Stand;
                case Card.Jack:
                    return ResultAction.Stand;
                case Card.Queen:
                    return ResultAction.Stand;
                case Card.King:
                    return ResultAction.Stand;
                case Card.Ace:
                    return ResultAction.Stand;
                default:
                    return ResultAction.Split;
            }
        }
    }
}
