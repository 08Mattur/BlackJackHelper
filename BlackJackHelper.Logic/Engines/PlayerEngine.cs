using BlackJackHelper.Logic.Engines.PlayerActions.Hards;
using BlackJackHelper.Logic.Engines.PlayerActions.Softs;
using BlackJackHelper.Logic.Engines.PlayerActions.Splits;
using BlackJackHelper.Logic.Enums;
using BlackJackHelper.Logic.Interfaces;
using BlackJackHelper.Logic.Objects;

namespace BlackJackHelper.Logic.Engines
{
    public class PlayerEngine
    {
        private IStrategy _strategy;

        public PlayerEngine(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public ResultAction WhatDo(Hand playerHand, Face dealerFace)
        {
           return _strategy.WhatShouldPlayerDo(playerHand, dealerFace);            
        }       
    }
}
