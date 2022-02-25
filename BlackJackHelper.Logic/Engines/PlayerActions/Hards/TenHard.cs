using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Engines.PlayerActions.Hards
{
    internal static class TenHard
    {
        internal static ResultAction WhatDo(Face dealerFace)
        {
            switch (dealerFace)
            {
                case Face.Ten:
                    return ResultAction.Hit;
                case Face.Jack:
                    return ResultAction.Hit;
                case Face.Queen:
                    return ResultAction.Hit;
                case Face.King:
                    return ResultAction.Hit;
                case Face.Ace:
                    return ResultAction.Hit;
                default:
                    return ResultAction.DoubleOrHit;
            }
        }
    }
}
