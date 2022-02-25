using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Engines.PlayerActions.Splits
{
    internal static class NineSplits
    {
        internal static ResultAction WhatDo(Face dealerFace)
        {
            switch (dealerFace)
            {
                case Face.Seven:
                    return ResultAction.Stand;
                case Face.Ten:
                    return ResultAction.Stand;
                case Face.Jack:
                    return ResultAction.Stand;
                case Face.Queen:
                    return ResultAction.Stand;
                case Face.King:
                    return ResultAction.Stand;
                case Face.Ace:
                    return ResultAction.Stand;
                default:
                    return ResultAction.Split;
            }
        }
    }
}
