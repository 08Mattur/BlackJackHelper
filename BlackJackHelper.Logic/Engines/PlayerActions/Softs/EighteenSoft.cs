using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Engines.PlayerActions.Softs
{
    internal static class EighteenSoft
    {
        internal static ResultAction WhatDo(Face dealerFace)
        {
            switch (dealerFace)
            {
                case Face.Two:
                    return ResultAction.DoubleOrStand;
                case Face.Three:
                    return ResultAction.DoubleOrStand;
                case Face.Four:
                    return ResultAction.DoubleOrStand;
                case Face.Five:
                    return ResultAction.DoubleOrStand;
                case Face.Six:
                    return ResultAction.DoubleOrStand;
                case Face.Seven:
                    return ResultAction.Stand;
                case Face.Eight:
                    return ResultAction.Stand;
                default:
                    return ResultAction.Hit;
            }
        }
    }
}
