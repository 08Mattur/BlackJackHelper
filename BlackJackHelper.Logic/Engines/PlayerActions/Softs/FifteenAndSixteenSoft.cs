using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Engines.PlayerActions.Softs
{
    internal static class FifteenAndSixteenSoft
    {
        internal static ResultAction WhatDo(Face dealerFace)
        {
            switch (dealerFace)
            {
                case Face.Four:
                    return ResultAction.DoubleOrHit;
                case Face.Five:
                    return ResultAction.DoubleOrHit;
                case Face.Six:
                    return ResultAction.DoubleOrHit;
                default:
                    return ResultAction.Hit;
            }
        }
    }
}
