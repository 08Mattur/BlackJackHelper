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
            _mainForm.AddCard(face, _isDealer);
        }
    }
}
