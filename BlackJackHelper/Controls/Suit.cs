namespace BlackJackHelper.Controls
{
    public partial class Suit : UserControl
    {
        private Forms.MainForm? _mainForm;
        private bool _isDealer;

        public Suit()
        {
            InitializeComponent();
        }

        public void SetProperties(Forms.MainForm mainForm, bool isDealer)
        {
            _mainForm = mainForm;
            _isDealer = isDealer;
        }
 
        private void btnAddAce_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Card.Ace);
        }

        private void btnAddTwo_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Card.Two);
        }

        private void btnAddThree_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Card.Three);
        }

        private void btnAddFour_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Card.Four);
        }

        private void btnAddFive_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Card.Five);
        }

        private void btnAddSix_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Card.Six);
        }

        private void btnAddSeven_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Card.Seven);
        }

        private void btnAddEight_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Card.Eight);
        }

        private void btnAddNine_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Card.Nine);
        }

        private void btnAddTen_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Card.Ten);
        }

        private void btnAddJack_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Card.Jack);
        }

        private void btnAddQueen_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Card.Queen);
        }

        private void btnAddKing_Click(object sender, EventArgs e)
        {
            AddCard(Logic.Enums.Card.King);
        }

        private void AddCard(Logic.Enums.Card card)
        {
            _mainForm.AddCard(card, _isDealer);
        }
    }
}
