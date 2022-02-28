using BlackJackHelper.Logic.Engines;
using BlackJackHelper.Logic.Enums;
using BlackJackHelper.Logic.Objects;

namespace BlackJackHelper.Logic.Services
{
    public class GameService
    {
        private Game _game;

        public GameService()
        {
            _game = new Game();
        }

        public int PlayerValue
        {
            get
            {
                return _game.PlayerValue;
            }
        }
        public int DealerValue
        {
            get
            {
                return _game.DealerValue;
            }
        }

        public bool IsPlayerBlackJack()
        {
            return _game.IsPlayerBlackJack();
        }
        public bool IsDealerBlackJack()
        {
            return _game.IsDealerBlackJack();
        }
        public decimal PlayerTotalAdvantage
        {
            get
            {
                return _game.PlayerTotalAdvantage;
            }
        }
        public int TotalCardsInDeck()
        {
            return _game.CardsLeftInDeck;
        }
        public int GetCountInDeck(Card face)
        {
            return _game.GetCountOfCardInDeck(face);
        }
        public void NewDeck(int intDecks)
        {
            _game.ShuffleDeck();
        }
        public void NewRound()
        {
            _game.NewRound();
        }
        public void DrawCard(Card card, bool isDealer)
        {         
            if (isDealer)
            {
                _game.DealerDrawCard(card);
            }
            else
            {
                _game.PlayerDrawCard(card);
            }
        }
        public PlayerHand PlayerHand
        {
            get
            {
                return _game.PlayerHand;
            }
        }
        public DealerHand DealerHand
        {
            get
            {
                return _game.DealerHand;
            }
        }
    }
}
