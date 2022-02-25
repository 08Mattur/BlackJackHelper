using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Objects
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();

            foreach (int i in Enum.GetValues(typeof(Suit)))
            {
                foreach (int j in Enum.GetValues(typeof(Face)))
                {
                    Cards.Add(new Card()
                    {
                        Face = (Face)j,
                        Suit = (Suit)i
                    });
                }
            }
        }

        public void RemoveFromDeck(Face face, Suit suit)
        {
            foreach (Card card in Cards)
            {
                if (card.Face == face && card.Suit == suit)
                {
                    Cards.Remove(card);
                    break;
                }
            }
        }
    }
}
