using BlackJackHelper.Logic.Interfaces;
using BlackJackHelper.Logic.Objects;

namespace BlackJackHelper.Logic.Services
{
    public class StrategyService
    {
        private IStrategy _strategy { get; set; }

        public StrategyService()
        {
            _strategy = new DefaultStrategy();
        }

        public IStrategy GetStrategy()
        {
            return _strategy;
        } 
    }
}
