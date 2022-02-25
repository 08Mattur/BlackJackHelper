using BlackJackHelper.Logic.Objects;

namespace BlackJackHelper.Logic.Services
{
    public class DeckBuilderService
    {
        public static Deck BuildNewDeck(int intDecks)
        {
            return new Deck(intDecks);
        }
    }
}
