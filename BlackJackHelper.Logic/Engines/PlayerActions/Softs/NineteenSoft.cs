using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Engines.PlayerActions.Softs
{
    internal static class NineteenSoft
    {
        internal static ResultAction WhatDo(Card dealerFace)
        {
            switch (dealerFace)
            {
                case Card.Six:
                    return ResultAction.DoubleOrStand;
                default:
                    return ResultAction.Stand;
            }
        }
    }
}
