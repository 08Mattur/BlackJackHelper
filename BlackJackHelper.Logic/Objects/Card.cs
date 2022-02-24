using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Objects
{
    public class Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        public string Name
        {
            get
            {
                return $"{Enum.GetName(Face)} of {Enum.GetName(Suit)}";
            }
        }
    }
}
