using BlackJackHelper.Logic.Engines;
using BlackJackHelper.Logic.Objects;

namespace BlackJackHelper.Logic.Services
{
    public class HandService
    {
        public HandService()
        {
            DealerHand = new Hand();
            PlayerHand = new Hand();
            DealerEngine = new DealerEngine();
            PlayerEngine = new PlayerEngine();
        }

        public Hand DealerHand { get; set; }
        public Hand PlayerHand { get; set; }
        public DealerEngine DealerEngine { get; set; }        
        public PlayerEngine PlayerEngine { get; set; }

        public void DealerAddCard(Card card)
        {
            DealerHand.AddCard(card);
        }

        public void PlayerAddCard(Card card)
        {
            PlayerHand.AddCard(card);
        }

        public void ClearHands()
        {
            DealerHand = new Hand();
            PlayerHand = new Hand();
        }

        public bool ShouldPlayerHit()
        {
            return PlayerEngine.ShouldHit(PlayerHand, DealerHand);
        }
    }
}
