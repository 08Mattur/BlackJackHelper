using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Objects
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                foreach (int j in Enum.GetValues(typeof(Face)))
                {
                    Cards.Add(new Card()
                    {
                        Face = (Face)j
                    });
                }
            }
        }

        public void RemoveFromDeck(Face face)
        {
            foreach (Card card in Cards)
            {
                if (card.Face == face)
                {
                    Cards.Remove(card);
                    break;
                }
            }
        }
    }
}
