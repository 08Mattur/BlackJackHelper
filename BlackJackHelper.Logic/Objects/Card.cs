using BlackJackHelper.Logic.Enums;

namespace BlackJackHelper.Logic.Objects
{
    public class Card
    {
        public Face Face { get; set; }

        public string Name
        {
            get
            {
                return $"{Enum.GetName(Face)}";
            }
        }
    }
}
