using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Engines.PlayerActions.Splits
{
    internal static class SixSplits
    {
        internal static ResultAction WhatDo(Face dealerFace)
        {
            switch (dealerFace)
            {
                case Face.Three:
                    return ResultAction.Split;
                case Face.Four:
                    return ResultAction.Split;
                case Face.Five:
                    return ResultAction.Split;
                case Face.Six:
                    return ResultAction.Split;
                default:
                    return ResultAction.Hit;
            }
        }
    }
}
