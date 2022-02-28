using BlackJackHelper.Logic.Engines;
using BlackJackHelper.Logic.Enums;
using BlackJackHelper.Logic.Objects;
using BlackJackHelper.Logic.Services;

namespace BlackJackHelper.Forms
{
    public partial class MainForm : Form
    {
        private GameService _gameService { get; set; }
        private EngineService _engineService { get; set; }

        public MainForm()
        {
            InitializeComponent();
            _gameService = new GameService();
            _engineService = new EngineService();

            BindSuits();
        }

        private void BindSuits()
        {
            ucDealerSuitClubs.SetProperties(this, true);
            ucPlayerSuitClubs.SetProperties(this, false);
        }
        private void AddDealerCard(Card face)
        {
            _gameService.DrawCard(face, true);
            lstDealerHand.Items.Add(Enum.GetName(face));
        }
        private void AddPlayercard(Card face)
        {
            _gameService.DrawCard(face, false);
            lstPlayerHand.Items.Add(Enum.GetName(face));
        }
        
        private void UpdateLabelsText()
        {
            lblAdvantageValue.Text = _gameService.PlayerTotalAdvantage.ToString();
            lblPlayerValue.Text = _gameService.PlayerValue.ToString();
            
            FormatSuggestionMessage(_engineService.WhatShouldPlayerDo(_gameService.PlayerHand, _gameService.DealerHand));
        }
        private void FormatSuggestionMessage(ResultAction playerSuggestedAction)
        {
            switch (playerSuggestedAction)
            {
                case ResultAction.Hit:
                    lblWhatDo.Text = "Hit";
                    lblWhatDo.ForeColor = Color.Red;
                    break;
                case ResultAction.Stand:
                    lblWhatDo.Text = "Stand";
                    lblWhatDo.ForeColor = Color.Orange;
                    break;
                case ResultAction.Double:
                    lblWhatDo.Text = "Double";
                    lblWhatDo.ForeColor = Color.Blue;
                    break;
                case ResultAction.Split:
                    lblWhatDo.Text = "Split";
                    lblWhatDo.ForeColor = Color.Pink;
                    break;
                case ResultAction.Bust:
                    lblWhatDo.Text = "Bust";
                    lblWhatDo.ForeColor = Color.Black;
                    break;
                case ResultAction.DoubleOrStand:
                    lblWhatDo.Text = "Double or Stand";
                    lblWhatDo.ForeColor = Color.BlueViolet;
                    break;
                case ResultAction.DoubleOrHit:
                    lblWhatDo.Text = "Double or Hit";
                    lblWhatDo.ForeColor = Color.Purple;
                    break;
                case ResultAction.Incalculable:
                    lblWhatDo.Text = "This is impossible.";
                    break;
            }
        }
        private void NewHand()
        {
            _gameService.NewRound();

            ClearOptions();

            lblPlayerValue.Text = "";
            lblWhatDo.Text = "";
            lblWhatDo.ForeColor = Color.Black;
        }
        private void NewDeck()
        {
            _gameService.NewDeck(8);
            ClearOptions();
            UpdateLabelsText();
            CalculateCardsLeft();
        }
        private void CalculateCardsLeft()
        {
            var totalCount = (double)_gameService.TotalCardsInDeck();
            lblTotalInDeckValue.Text = totalCount.ToString();

            var acesCount = _gameService.GetCountInDeck(Card.Ace);
            var twosCount = _gameService.GetCountInDeck(Card.Two);
            var threesCount = _gameService.GetCountInDeck(Card.Three);
            var foursCount = _gameService.GetCountInDeck(Card.Four);
            var fivesCount = _gameService.GetCountInDeck(Card.Five);
            var sixesCount = _gameService.GetCountInDeck(Card.Six);
            var sevensCount = _gameService.GetCountInDeck(Card.Seven);
            var eightsCount = _gameService.GetCountInDeck(Card.Eight);
            var ninesCount = _gameService.GetCountInDeck(Card.Nine);
            var tensCount = _gameService.GetCountInDeck(Card.Ten);

            lblAInDeck.Text = acesCount.ToString();
            lbl2InDeck.Text = twosCount.ToString();
            lbl3InDeck.Text = threesCount.ToString();
            lbl4InDeck.Text = foursCount.ToString();
            lbl5InDeck.Text = fivesCount.ToString();
            lbl6InDeck.Text = sixesCount.ToString();
            lbl7InDeck.Text = sevensCount.ToString();
            lbl8InDeck.Text = eightsCount.ToString();
            lbl9InDeck.Text = ninesCount.ToString();
            lbl10InDeck.Text = tensCount.ToString();

            lblAProbability.Text = $"{Math.Round(acesCount / totalCount * 100, 2)}%";
            lbl2Probability.Text = $"{Math.Round(twosCount / totalCount * 100, 2)}%";
            lbl3Probability.Text = $"{Math.Round(threesCount / totalCount * 100, 2)}%";
            lbl4Probability.Text = $"{Math.Round(foursCount / totalCount * 100, 2)}%";
            lbl5Probability.Text = $"{Math.Round(fivesCount / totalCount * 100, 2)}%";
            lbl6Probability.Text = $"{Math.Round(sixesCount / totalCount * 100, 2)}%";
            lbl7Probability.Text = $"{Math.Round(sevensCount / totalCount * 100, 2)}%";
            lbl8Probability.Text = $"{Math.Round(eightsCount / totalCount * 100, 2)}%";
            lbl9Probability.Text = $"{Math.Round(ninesCount / totalCount * 100, 2)}%";
            lbl10Probability.Text = $"{Math.Round(tensCount / totalCount * 100, 2)}%";
        }
        private void ClearOptions()
        {
            lstDealerHand.Items.Clear();
            lstPlayerHand.Items.Clear();
        }
        public void AddCard(Card face, bool isDealer)
        {
            if (isDealer)
            {
                AddDealerCard(face);
            }
            else
            {
                AddPlayercard(face);
            }
            UpdateLabelsText();

            CalculateCardsLeft();
        }

        private void btnNewHand_Click(object sender, EventArgs e)
        {
            NewHand();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            var key = e.KeyCode;

            switch (key)
            {
                case Keys.NumPad0: 
                    AddCard(Card.Ten, false);
                    break;
                case Keys.NumPad1:
                    AddCard(Card.Ace, false);
                    break;
                case Keys.NumPad2:
                    AddCard(Card.Two, false);
                    break;
                case Keys.NumPad3:
                    AddCard(Card.Three, false);
                    break;
                case Keys.NumPad4:
                    AddCard(Card.Four, false);
                    break;
                case Keys.NumPad5:
                    AddCard(Card.Five, false);
                    break;
                case Keys.NumPad6:
                    AddCard(Card.Six, false);
                    break;
                case Keys.NumPad7:
                    AddCard(Card.Seven, false);
                    break;
                case Keys.NumPad8:
                    AddCard(Card.Eight, false);
                    break;
                case Keys.NumPad9:
                    AddCard(Card.Nine, false);
                    break;
                case Keys.D0:
                    AddCard(Card.Ten, true);
                    break;
                case Keys.D1:
                    AddCard(Card.Ace, true);
                    break;
                case Keys.D2:
                    AddCard(Card.Two, true);
                    break;
                case Keys.D3:
                    AddCard(Card.Three, true);
                    break;
                case Keys.D4:
                    AddCard(Card.Four, true);
                    break;
                case Keys.D5:
                    AddCard(Card.Five, true);
                    break;
                case Keys.D6:
                    AddCard(Card.Six, true);
                    break;
                case Keys.D7:
                    AddCard(Card.Seven, true);
                    break;
                case Keys.D8:
                    AddCard(Card.Eight, true);
                    break;
                case Keys.D9:
                    AddCard(Card.Nine, true);
                    break;
                case Keys.Back:
                    NewHand();
                    break;
                case Keys.F12:
                    NewDeck();
                    break;
            }
        }

        private void btnNewDeck_Click(object sender, EventArgs e)
        {
            NewDeck();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SimulationInputForm();
            form.ShowDialog();
        }
    }
}
