using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Objects
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
        }

        public Deck(int deckCount)
        {
            Cards = new List<Card>();

            for (int i = 0; i < deckCount; i++)
            {
                foreach (int j in Enum.GetValues(typeof(Face)))
                {
                    var face = (Face)j;

                    for (int x = 0; x < 4; x++)
                    {
                        Cards.Add(new Card()
                        {
                            Face = face
                        });
                    }
                }
            }            
        }

        public int GetCountInDeck(Face face)
        {
            if (face == Face.Ten)
            {
                return GetTensInDeck();
            }

            var counter = 0;
            foreach (var card in Cards)
            {
                if (card.Face == face)
                {
                    counter++;
                }
            }
            return counter;
        }
        
        private int GetTensInDeck()
        {
            var counter = 0;
            foreach (var card in Cards)
            {
                if (card.Face == Face.Ten ||
                    card.Face == Face.Jack ||
                    card.Face == Face.Queen ||
                    card.Face == Face.King)
                {
                    counter++;
                }
            }
            return counter;
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
