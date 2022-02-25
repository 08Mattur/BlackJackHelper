using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Engines.PlayerActions.Hards
{
    internal static class TwelveHard
    {
        internal static ResultAction WhatDo(Face dealerFace)
        {
            switch (dealerFace)
            {
                case Face.Four:
                    return ResultAction.Stand;
                case Face.Five:
                    return ResultAction.Stand;
                case Face.Six:
                    return ResultAction.Stand;
                default:
                    return ResultAction.Hit;
            }
        }
    }
}
