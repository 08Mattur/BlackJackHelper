using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Objects
{
    public class Deck
    {
        private int _decks;
        
        public Deck()
        {
            Cards = new List<Card>();
            PlayerAdvantage = 0;
        }

        public Deck(int deckCount)
        {
            Cards = new List<Card>();
            PlayerAdvantage = 0;
            _decks = deckCount;

            for (int i = 0; i < _decks; i++)
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

        public List<Card> Cards { get; set; }

        public int PlayerAdvantage { get; set; }

        public double TotalAdvantage { 
            get
            {
                var decksLeft = Math.Round(Cards.Count / (double)52);

                return Math.Round(PlayerAdvantage / decksLeft, 2);
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
            UpdateCounter(face);
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
        private void UpdateCounter(Face face)
        {
            switch (face)
            {
                case Face.Two:
                    PlayerAdvantage += 1;
                    break;
                case Face.Three:
                    PlayerAdvantage += 1;
                    break;
                case Face.Four:
                    PlayerAdvantage += 1;
                    break;
                case Face.Five:
                    PlayerAdvantage += 1;
                    break;
                case Face.Six:
                    PlayerAdvantage += 1;
                    break;
                case Face.Seven:
                    break;
                case Face.Eight:
                    break;
                case Face.Nine:
                    break;
                default:
                    PlayerAdvantage -= 1;
                    break;
            }
        }
    }
}
