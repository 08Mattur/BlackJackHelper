using BlackJackHelper.Logic.Objects;

namespace BlackJackHelper.Logic.Services
{
    public class DeckBuilderService
    {
        public static Deck BuildNewDeck(int intdecks)
        {
            var finalDeck = new Deck();

            for (int i = 0; i < intdecks-1; i++)
            {
                var deck = new Deck();
                foreach(var deckCard in deck.Cards)
                {
                    finalDeck.Cards.Add(deckCard);
                }
            }

            return finalDeck;
        }
    }
}
