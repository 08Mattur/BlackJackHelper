using BlackJackHelper.Logic.Objects;

namespace BlackJackHelper.Logic.Services
{
    public static class DeckService
    {
        private static Random rng;

        static DeckService()
        {
            rng = new Random();
        }

        public static Deck BuildNewDeck(int intDecks)
        {
            var deck = new Deck(intDecks);

            deck.Cards.Shuffle();

            return deck;
        }

        private static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1) {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
