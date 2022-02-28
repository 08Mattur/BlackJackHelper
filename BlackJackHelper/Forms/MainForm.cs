using BlackJackHelper.Logic.Engines;
using BlackJackHelper.Logic.Enums;
using BlackJackHelper.Logic.Objects;
using BlackJackHelper.Logic.Services;

namespace BlackJackHelper.Forms
{
    public partial class MainForm : Form
    {
        private GameService _gameService { get; set; }
        private StrategyService _strategyService { get; set; }

        public MainForm()
        {
            InitializeComponent();
            _strategyService = new StrategyService();            
            _gameService = new GameService(_strategyService.GetStrategy());
            BindSuits();
        }

        private void BindSuits()
        {
            ucDealerSuitClubs.SetProperties(this, true);
            ucPlayerSuitClubs.SetProperties(this, false);
        }

        private void AddDealerCard(Face face)
        {
            _gameService.DrawCard(face, true);
            lstDealerHand.Items.Add(Enum.GetName(face));

            FormatSuggestionMessage(_gameService.WhatShouldPlayerDo());
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
        private void AddPlayercard(Face face)
        {
            _gameService.DrawCard(face, false);
            lstPlayerHand.Items.Add(Enum.GetName(face));
        }
        private void UpdateLabelsText()
        {
            lblAdvantageValue.Text = _gameService.PlayerTotalAdvantage.ToString();
            lblPlayerValue.Text = _gameService.PlayerValue.ToString();
            FormatSuggestionMessage(_gameService.WhatShouldPlayerDo());
        }
        private void NewHand()
        {
            _gameService.NewHand();

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
            var totalCount = _gameService.TotalCardsInDeck();
            lblTotalInDeckValue.Text = totalCount.ToString();

            var acesCount = _gameService.GetCountInDeck(Face.Ace);
            var twosCount = _gameService.GetCountInDeck(Face.Two);
            var threesCount = _gameService.GetCountInDeck(Face.Three);
            var foursCount = _gameService.GetCountInDeck(Face.Four);
            var fivesCount = _gameService.GetCountInDeck(Face.Five);
            var sixesCount = _gameService.GetCountInDeck(Face.Six);
            var sevensCount = _gameService.GetCountInDeck(Face.Seven);
            var eightsCount = _gameService.GetCountInDeck(Face.Eight);
            var ninesCount = _gameService.GetCountInDeck(Face.Nine);
            var tensCount = _gameService.GetCountInDeck(Face.Ten);

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
        public void AddCard(Face face, bool isDealer)
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
                    AddCard(Face.Ten, false);
                    break;
                case Keys.NumPad1:
                    AddCard(Face.Ace, false);
                    break;
                case Keys.NumPad2:
                    AddCard(Face.Two, false);
                    break;
                case Keys.NumPad3:
                    AddCard(Face.Three, false);
                    break;
                case Keys.NumPad4:
                    AddCard(Face.Four, false);
                    break;
                case Keys.NumPad5:
                    AddCard(Face.Five, false);
                    break;
                case Keys.NumPad6:
                    AddCard(Face.Six, false);
                    break;
                case Keys.NumPad7:
                    AddCard(Face.Seven, false);
                    break;
                case Keys.NumPad8:
                    AddCard(Face.Eight, false);
                    break;
                case Keys.NumPad9:
                    AddCard(Face.Nine, false);
                    break;
                case Keys.D0:
                    AddCard(Face.Ten, true);
                    break;
                case Keys.D1:
                    AddCard(Face.Ace, true);
                    break;
                case Keys.D2:
                    AddCard(Face.Two, true);
                    break;
                case Keys.D3:
                    AddCard(Face.Three, true);
                    break;
                case Keys.D4:
                    AddCard(Face.Four, true);
                    break;
                case Keys.D5:
                    AddCard(Face.Five, true);
                    break;
                case Keys.D6:
                    AddCard(Face.Six, true);
                    break;
                case Keys.D7:
                    AddCard(Face.Seven, true);
                    break;
                case Keys.D8:
                    AddCard(Face.Eight, true);
                    break;
                case Keys.D9:
                    AddCard(Face.Nine, true);
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
    }
}
