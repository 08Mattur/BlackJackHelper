using BlackJackHelper.Logic.Engines;
using BlackJackHelper.Logic.Enums;
using BlackJackHelper.Logic.Objects;

namespace BlackJackHelper.Logic.Services
{
    public class GameService
    {
        private DealerEngine _dealerEngine;
        private PlayerEngine _playerEngine;
        private Deck _gameDeck;
        private Hand _playerHand;
        private Hand _dealerHand;

        public GameService()
        {
            _dealerEngine = new DealerEngine();
            _playerEngine = new PlayerEngine();
            _gameDeck = new Deck();
            _playerHand = new Hand();
            _dealerHand = new Hand();

            NewDeck(8);
        }

        public int PlayerValue
        {
            get
            {
                return _playerHand.Value;
            }
        }

        public ResultAction WhatShouldPlayerDo()
        {
            if (_dealerHand.Cards.Count > 0)
            {
                return _playerEngine.WhatDo(_playerHand, _dealerHand);
            }
            return ResultAction.Incalculable;
        }

        public double PlayerTotalAdvantage
        {
            get
            {
                return _gameDeck.TotalAdvantage;
            }
        }

        public double TotalCardsInDeck()
        {
            return _gameDeck.Cards.Count();
        }
        public int GetCountInDeck(Face face)
        {
            return _gameDeck.GetCountInDeck(face);
        }

        public void NewDeck(int intDecks)
        {
            _gameDeck = DeckService.BuildNewDeck(intDecks);
            NewHand();
        }

        public void NewHand()
        {
            _dealerHand = new Hand();
            _playerHand = new Hand();
        }

        public void DrawCard(Face face, bool isDealer)
        {
            _gameDeck.RemoveFromDeck(face);

            if (isDealer)
            {
                _dealerHand.AddCard(face);
            }
            else
            {
                _playerHand.AddCard(face);
            }
        }
    }
}
