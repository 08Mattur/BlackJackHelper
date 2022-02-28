using BlackJackHelper.Logic.Enums;
using BlackJackHelper.Logic.Objects;

namespace BlackJackHelper.Logic.Services
{
    public class SimulationService
    {
        private double _initialBankRoll;
        private double _currentBankRoll;
        private double _amountPerBet;
        private int _handCounter;
        private GameService? _currentGame;
        private EngineService _engineService;
        private SimulationResult? _simulationResult;
        private bool _hasDoubledDown = false;

        public SimulationService(double bankroll, double amountPerBet, int numberOfHands)
        {
            _initialBankRoll = bankroll;
            _currentBankRoll = bankroll;
            _amountPerBet = amountPerBet;
            _handCounter = numberOfHands;
            _engineService = new EngineService();
        }

        public SimulationResult Simulate()
        {
            _currentGame = new GameService();
            _simulationResult = new SimulationResult();

            _simulationResult.StartBankRoll = _initialBankRoll;
            _simulationResult.AmountPerBet = _amountPerBet;

            var gamesSimulated = 0;

            while (gamesSimulated < _handCounter && _currentBankRoll > _amountPerBet)
            {
                gamesSimulated++;
                _simulationResult.HandsPlayed++;
                _currentBankRoll -= _amountPerBet;

                StartNewHand();
                                
                ResultAction whatPlayerDo, whatDealerDo;
                PlayerAndDealerActions(out whatPlayerDo, out whatDealerDo);
                GameResult(whatPlayerDo, whatDealerDo);               
            }

            _simulationResult.EndBankRoll = _currentBankRoll;
            return _simulationResult;
        }

        private void GameResult(ResultAction whatPlayerDo, ResultAction whatDealerDo)
        {
            if (!CheckIfBlackJackEnd())
            {
                if (whatPlayerDo == ResultAction.Bust)
                {
                    DealerWin();
                    if (whatDealerDo == ResultAction.Bust)
                    {
                        _simulationResult.DealerBust++;
                    }
                    return;
                }
                if (whatDealerDo == ResultAction.Bust)
                {
                    PlayerWin();
                    _simulationResult.DealerBust++;
                    return;
                }
                if (_currentGame.PlayerValue > _currentGame.DealerValue)
                {
                    PlayerWin();
                    return;
                }
                if (_currentGame.PlayerValue == _currentGame.DealerValue)
                {
                    Draw();
                    return;
                }
                if (_currentGame.PlayerValue < _currentGame.DealerValue)
                {
                    DealerWin();
                    return;
                }
            }           
        }
        private void PlayerAndDealerActions(out ResultAction whatPlayerDo, out ResultAction whatDealerDo)
        {
            var playerHand = _currentGame.PlayerHand;
            var dealerHand = _currentGame.DealerHand;

            whatPlayerDo = _engineService.WhatShouldPlayerDo(playerHand, dealerHand);
            var currentCycle = 0;
            while (whatPlayerDo != ResultAction.Bust && whatPlayerDo != ResultAction.Stand)
            {                
                // Break if looping.
                if (currentCycle > 9)
                {
                    whatPlayerDo = ResultAction.Stand;
                    break;
                }

                PlayerAction(whatPlayerDo);
                whatPlayerDo = _engineService.WhatShouldPlayerDo(playerHand, dealerHand);
                currentCycle++;
            }

            whatDealerDo = _engineService.WhatShouldDealerDo(dealerHand);
            while (whatDealerDo != ResultAction.Bust && whatDealerDo != ResultAction.Stand)
            {
                _currentGame.DrawCard(RandomCard(), true);
                whatDealerDo = _engineService.WhatShouldDealerDo(dealerHand);
            }
        }
        private void StartNewHand()
        {
            if (_currentGame.TotalCardsInDeck() < 150)
            {
                _currentGame.NewDeck(8);
            }
            else
            {
                _currentGame.NewRound();
            }

            _hasDoubledDown = false;

            _currentGame.DrawCard(RandomCard(), false);
            _currentGame.DrawCard(RandomCard(), true);
            _currentGame.DrawCard(RandomCard(), false);
            _currentGame.DrawCard(RandomCard(), true);
        }
        private Card RandomCard()
        {
            var rng = new Random();
            var posFaces = Enum.GetValues(typeof(Card));
            var randomFace = (Card)posFaces.GetValue(rng.Next(posFaces.Length));

            if (_currentGame?.GetCountInDeck(randomFace) == 0)
            {
                randomFace = RandomCard();
            }
            return randomFace;
        }
        private bool CheckIfBlackJackEnd()
        {
            var dealerBlackJack = _currentGame.IsDealerBlackJack();
            if (_currentGame.IsPlayerBlackJack())
            {
                _simulationResult.PlayerBlackJack++;
                if (dealerBlackJack)
                {
                    _simulationResult.DealerBlackJack++;
                    Draw();
                }
                PlayerWin(true);
                return true;
            }
            if (dealerBlackJack)
            {
                _simulationResult.DealerBlackJack++;
                DealerWin();
                return true;
            }
            return false;
        }
        private void PlayerWin(bool isBlackJack = false)
        {
            var multiplier = (double)1;
            if (isBlackJack)
            {
                multiplier = 2.5;
            }
            if (_hasDoubledDown)
            {
                multiplier = 2;
            }

            _currentBankRoll += _amountPerBet * multiplier;
            _simulationResult.HandsWon++;
        }
        private void DealerWin()
        {
            _simulationResult.HandsLost++;
        }
        private void Draw()
        {
            _currentBankRoll += _amountPerBet;
            _simulationResult.HandsDrawn++;
        }
        private void PlayerAction(ResultAction action)
        {
            switch (action)
            {
                case ResultAction.Hit:
                    Hit();
                    break;
                case ResultAction.DoubleOrHit:
                    if (_currentGame.PlayerHand.Cards.Count > 2)
                    {
                        Hit();
                        break;
                    }
                    DoubleDown();
                    break;
                case ResultAction.Double:
                    DoubleDown();
                    break;
                case ResultAction.Split:
                    if (_currentGame.PlayerHand.Value < 16)
                    {
                        Hit();
                    }
                    break;
                case ResultAction.DoubleOrStand:
                    if (_currentGame.PlayerHand.Cards.Count == 2)
                    {
                        DoubleDown();
                    }
                    break;                    
            }
        }
        private void DoubleDown()
        {
            _hasDoubledDown = true;
            _currentBankRoll -= _amountPerBet;
        }
        private void Hit()
        {
            _currentGame.DrawCard(RandomCard(), false);
        }
    }
}
