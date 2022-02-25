namespace BlackJackHelper.Controls
{
    public partial class Suit : UserControl
    {
        private Logic.Enums.Suit _suit;
        private Forms.MainForm? _mainForm;
        private bool _isDealer;

        public Suit()
        {
            InitializeComponent();
        }

        public void SetProperties(Logic.Enums.Suit suit, Forms.MainForm mainForm, bool isDealer)
        {
            _suit = suit;
            _mainForm = mainForm;
            _isDealer = isDealer;
            AddSuit();
        }

        private void AddSuit()
        {
            switch (_suit)
            {
                case Logic.Enums.Suit.Clubs:
                    AddTextToButtons("♣");
                    break;
                case Logic.Enums.Suit.Diamonds:
                    AddTextToButtons("♦");
                    ChangeButtonColour();
                    break;
                case Logic.Enums.Suit.Hearts:
                    AddTextToButtons("♥");
                    ChangeButtonColour();
                    break;
                case Logic.Enums.Suit.Spades:
                    AddTextToButtons("♠");
                    break;
                default: throw new NotImplementedException();
            }
        }
        private void AddTextToButtons(string suit)
        {
            btnAddAce.Text += suit;
            btnAddTwo.Text += suit;
            btnAddThree.Text += suit;
            btnAddFour.Text += suit;
            btnAddFive.Text += suit;
            btnAddSix.Text += suit;
            btnAddSeven.Text += suit;
            btnAddEight.Text += suit;
            btnAddNine.Text += suit;
            btnAddTen.Text += suit;
            btnAddJack.Text += suit;
            btnAddQueen.Text += suit;
            btnAddKing.Text += suit;
        }
        private void ChangeButtonColour()
        {
            btnAddAce.ForeColor = Color.Red;
            btnAddTwo.ForeColor = Color.Red;
            btnAddThree.ForeColor = Color.Red;
            btnAddFour.ForeColor = Color.Red;
            btnAddFive.ForeColor = Color.Red;
            btnAddSix.ForeColor = Color.Red;
            btnAddSeven.ForeColor = Color.Red;
            btnAddEight.ForeColor = Color.Red;
            btnAddNine.ForeColor = Color.Red;
            btnAddTen.ForeColor = Color.Red;
            btnAddJack.ForeColor = Color.Red;
            btnAddQueen.ForeColor = Color.Red;
            btnAddKing.ForeColor = Color.Red;
        }

        private void btnAddAce_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Face.Ace);
        }

        private void btnAddTwo_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Face.Two);
        }

        private void btnAddThree_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Face.Three);
        }

        private void btnAddFour_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Face.Four);
        }

        private void btnAddFive_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Face.Five);
        }

        private void btnAddSix_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Face.Six);
        }

        private void btnAddSeven_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Face.Seven);
        }

        private void btnAddEight_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Face.Eight);
        }

        private void btnAddNine_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Face.Nine);
        }

        private void btnAddTen_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Face.Ten);
        }

        private void btnAddJack_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Face.Jack);
        }

        private void btnAddQueen_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Face.Queen);
        }

        private void btnAddKing_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Face.King);
        }

        private void AddCard(Logic.Enums.Face face)
        {
            var card = new Logic.Objects.Card()
            {
                Face = face,
                Suit = _suit
            };
            _mainForm.AddCard(card, _isDealer);
        }
    }
}
