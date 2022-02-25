using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Engines.PlayerActions.Softs
{
    internal static class NineteenSoft
    {
        internal static ResultAction WhatDo(Face dealerFace)
        {
            switch (dealerFace)
            {
                case Face.Six:
                    return ResultAction.DoubleOrStand;
                default:
                    return ResultAction.Stand;
            }
        }
    }
}
