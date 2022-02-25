using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Engines.PlayerActions.Hards
{
    internal static class PlayerHighHard
    {
        internal static ResultAction WhatDo(Face dealerFace)
        {
            switch (dealerFace)
            {
                case Face.Two:
                    return ResultAction.Stand;
                case Face.Three:
                    return ResultAction.Stand;
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
