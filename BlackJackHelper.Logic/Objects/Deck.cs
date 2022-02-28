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
                foreach (int j in Enum.GetValues(typeof(Card)))
                {
                    var card = (Card)j;

                    for (int x = 0; x < 4; x++)
                    {
                        Cards.Add(card);
                    }
                }
            }
        }
        public List<Card> Cards { get; set; }
        public int PlayerAdvantage { get; set; }
        public decimal TotalAdvantage
        {
            get
            {
                var decksLeft = (decimal)Cards.Count / 52;
                return Math.Ceiling(PlayerAdvantage / decksLeft);
            }
        }
        public int GetCountInDeck(Card face)
        {
            if (face == Card.Ten)
            {
                return GetTensInDeck();
            }

            var counter = 0;
            foreach (var card in Cards)
            {
                if (card == face)
                {
                    counter++;
                }
            }
            return counter;
        }
        public void RemoveFromDeck(Card face)
        {
            foreach (Card card in Cards)
            {
                if (card == face)
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
                if (card == Card.Ten ||
                    card == Card.Jack ||
                    card == Card.Queen ||
                    card == Card.King)
                {
                    counter++;
                }
            }
            return counter;
        }
        private void UpdateCounter(Card face)
        {
            switch (face)
            {
                case Card.Two:
                    PlayerAdvantage += 1;
                    break;
                case Card.Three:
                    PlayerAdvantage += 1;
                    break;
                case Card.Four:
                    PlayerAdvantage += 1;
                    break;
                case Card.Five:
                    PlayerAdvantage += 1;
                    break;
                case Card.Six:
                    PlayerAdvantage += 1;
                    break;
                case Card.Seven:
                    break;
                case Card.Eight:
                    break;
                case Card.Nine:
                    break;
                default:
                    PlayerAdvantage -= 1;
                    break;
            }
        }
    }
}
