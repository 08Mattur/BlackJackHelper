﻿using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Engines.PlayerActions.Hards
{
    internal static class NineHard
    {
        internal static ResultAction WhatDo(Face dealerFace)
        {
            switch (dealerFace)
            {
                case Face.Three:
                    return ResultAction.DoubleOrHit;
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