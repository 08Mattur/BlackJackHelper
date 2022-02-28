using BlackJackHelper.Logic.Enums;
using BlackJackHelper.Logic.Objects;

namespace BlackJackHelper.Logic.Interfaces
{
    public  interface IStrategy
    {
        public ResultAction WhatShouldPlayerDo(Hand playerHand, Face dealerUpcard)
    }
}
