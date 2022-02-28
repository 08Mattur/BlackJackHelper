using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Objects
{
    public class Game
    {
        private Deck _gameDeck = new Deck();
        

        public Game()
        {
            ShuffleDeck();
            NewRound();
        }

        public PlayerHand PlayerHand{ get; private set; }
        public DealerHand DealerHand { get; private set; }
        public void ShuffleDeck()
        {
            _gameDeck = new Deck(8);
            NewRound();
        }
        public void NewRound()
        {
            PlayerHand = new PlayerHand();
            DealerHand = new DealerHand();
        }
        public void DealerDrawCard(Card card)
        {
            _gameDeck.RemoveFromDeck(card);            
                DealerHand.AddCard(card);                        
        }
        public void PlayerDrawCard(Card card)
        {
            _gameDeck.RemoveFromDeck(card);
            PlayerHand.AddCard(card);
        }
        public int PlayerValue
        {
            get
            {
                return PlayerHand.Value;
            }
        }
        public int DealerValue
        {
            get
            {
                return DealerHand.Value;
            }
        }        
        public Card DealerUpcard
        {
            get
            {
                return DealerHand.Upcard;
            }
        }
        public bool IsPlayerBlackJack()
        {
            return PlayerHand.IsBlackJack();
        }
        public bool IsDealerBlackJack()
        {
            return DealerHand.IsBlackJack();
        }
        public int PlayerCurrentAdvantage
        {
            get
            {
                return _gameDeck.PlayerAdvantage;
            }
        }
        public decimal PlayerTotalAdvantage
        {
            get
            {
                return _gameDeck.TotalAdvantage;
            }
        }
        public int CardsLeftInDeck
        {
            get
            {
                return _gameDeck.Cards.Count;
            }
        }
        public int GetCountOfCardInDeck(Card card)
        {
            return _gameDeck.GetCountInDeck(card);
        }
    }
}
