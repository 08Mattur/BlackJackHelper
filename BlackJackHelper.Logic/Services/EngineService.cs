using BlackJackHelper.Logic.Engines;
using BlackJackHelper.Logic.Enums;
using BlackJackHelper.Logic.Objects;

namespace BlackJackHelper.Logic.Services
{
    public class EngineService
    {
        private PlayerEngine _playerEngine;
        private DealerEngine _dealerEngine;

        public EngineService()
        {
            _playerEngine = new PlayerEngine();
            _dealerEngine = new DealerEngine();
        }

        public ResultAction WhatShouldPlayerDo(PlayerHand player, DealerHand dealer)
        {
            return _playerEngine.WhatDo(player, dealer);
        }

        public ResultAction WhatShouldDealerDo(DealerHand dealer)
        {
            return _dealerEngine.WhatShouldDealerDo(dealer);
        }
    }
}
