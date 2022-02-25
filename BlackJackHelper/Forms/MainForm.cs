using BlackJackHelper.Logic.Engines;
using BlackJackHelper.Logic.Enums;
using BlackJackHelper.Logic.Objects;
using BlackJackHelper.Logic.Services;

namespace BlackJackHelper.Forms
{
    public partial class MainForm : Form
    {
        private Hand _dealerHand { get; set; }
        private Hand _playerHand { get; set; }
        private PlayerEngine _playerEngine { get; set; }
        private double _playerAdvantage { get; set; }
        private Deck _deck { get; set; }

        public MainForm()
        {
            InitializeComponent();
            _dealerHand = new Hand();
            _playerHand = new Hand();
            _playerEngine = new PlayerEngine();
            _playerAdvantage = 0;
            _deck = DeckBuilderService.BuildNewDeck(8);
            BindSuits();
        }

        private void BindSuits()
        {
            ucDealerSuitClubs.SetProperties(this, true);
            ucPlayerSuitClubs.SetProperties(this, false);
        }

        public void AddCard(Card card, bool isDealer)
        {
            UpdateCounter(card.Face);
            _deck.RemoveFromDeck(card.Face);
            CalculateCardsLeft();

            if (isDealer)
            {
                _dealerHand.AddCard(card);
                lstDealerHand.Items.Add(card.Name);
            }
            else
            {
                _playerHand.AddCard(card);
                lstPlayerHand.Items.Add(card.Name);
                lblPlayerValue.Text = _playerHand.Value.ToString();
            }

            if (_dealerHand.Cards.Count > 0)
            {
                WhatDo();
            }
        }

        private void UpdateCounter(Face face)
        {
            switch (face)
            {
                case Face.Two:
                    _playerAdvantage += 1;
                    break;
                case Face.Three:
                    _playerAdvantage += 1;
                    break;
                case Face.Four:
                    _playerAdvantage += 1;
                    break;
                case Face.Five:
                    _playerAdvantage += 1;
                    break;
                case Face.Six:
                    _playerAdvantage += 1;
                    break;
                case Face.Seven:
                    break;
                case Face.Eight:
                    break;
                case Face.Nine:
                    break;
                default:
                    _playerAdvantage -= 1;
                    break;
            }
                       
            lblAdvantageValue.Text = Math.Round((_playerAdvantage/8),3).ToString();
        }

        private void btnNewHand_Click(object sender, EventArgs e)
        {
            NewHand();
        }

        private void NewHand()
        {
            _dealerHand = new Hand();
            _playerHand = new Hand();

            lstDealerHand.Items.Clear();

            lblPlayerValue.Text = "";
            lstPlayerHand.Items.Clear();

            lblWhatDo.Text = "";
            lblWhatDo.ForeColor = Color.Black;
        }

        private void WhatDo()
        {
            var shouldHit = _playerEngine.WhatDo(_playerHand, _dealerHand);

            switch (shouldHit)
            {
                case ResultAction.Hit:
                    lblWhatDo.Text = "Hit";
                    lblWhatDo.ForeColor = Color.Red;
                    break;
                case ResultAction.Stand:
                    lblWhatDo.Text = "You should stand";
                    lblWhatDo.ForeColor = Color.Orange;
                    break;
                case ResultAction.Double:
                    lblWhatDo.Text = "You should double";
                    lblWhatDo.ForeColor = Color.Blue;
                    break;
                case ResultAction.Split:
                    lblWhatDo.Text = "You should split";
                    lblWhatDo.ForeColor = Color.Pink;
                    break;
                case ResultAction.Bust:
                    lblWhatDo.Text = "You are bust";
                    lblWhatDo.ForeColor = Color.Black;
                    break;
                case ResultAction.DoubleOrStand:
                    lblWhatDo.Text = "You should double if you can, stand otherwise.";
                    lblWhatDo.ForeColor = Color.BlueViolet;
                    break;
                case ResultAction.DoubleOrHit:
                    lblWhatDo.Text = "You should double if you can, hit otherwise.";
                    lblWhatDo.ForeColor = Color.Purple;
                    break;
                case ResultAction.Incalculable:
                    lblWhatDo.Text = "This is impossible.";
                    break;
            }
        }

        private void NewDeck()
        {
            _deck = DeckBuilderService.BuildNewDeck(8);
            _playerAdvantage = 0;
            lblAdvantageValue.Text = _playerAdvantage.ToString();
            NewHand();
            CalculateCardsLeft();
        }

        private void CalculateCardsLeft()
        {
            var totalCount = (float)_deck.Cards.Count();
            lblTotalInDeckValue.Text = totalCount.ToString();

            var acesCount = _deck.GetCountInDeck(Face.Ace);
            var twosCount = _deck.GetCountInDeck(Face.Two);
            var threesCount= _deck.GetCountInDeck(Face.Three);
            var foursCount = _deck.GetCountInDeck(Face.Four);
            var fivesCount = _deck.GetCountInDeck(Face.Five);
            var sixesCount = _deck.GetCountInDeck(Face.Six);
            var sevensCount = _deck.GetCountInDeck(Face.Seven);
            var eightsCount = _deck.GetCountInDeck(Face.Eight);
            var ninesCount = _deck.GetCountInDeck(Face.Nine);
            var tensCount = _deck.GetCountInDeck(Face.Ten);

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

            lblAProbability.Text = $"{Math.Round(acesCount / totalCount * 100,2)}%";
            lbl2Probability.Text = $"{Math.Round(twosCount / totalCount * 100, 2)}%";
            lbl3Probability.Text = $"{Math.Round(threesCount / totalCount * 100, 2)}%";
            lbl4Probability.Text = $"{Math.Round(foursCount / totalCount * 100, 2)}%";
            lbl5Probability.Text = $"{Math.Round(fivesCount / totalCount * 100, 2)}%";
            lbl6Probability.Text = $"{Math.Round(sixesCount / totalCount * 100, 2)}%";
            lbl7Probability.Text = $"{Math.Round(sevensCount / totalCount * 100, 2)}%";
            lbl8Probability.Text = $"{Math.Round(eightsCount / totalCount * 100, 2)}%";
            lbl9Probability.Text = $"{Math.Round(ninesCount / totalCount * 100, 2)}%";
            lbl10Probability.Text = $"{Math.Round(tensCount / totalCount * 100,2)}%";
        }
        
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            var key = e.KeyCode;

            var card = new Card();

            switch (key)
            {
                case Keys.NumPad0:
                    card.Face = Face.Ten;
                    AddCard(card, false);
                    break;
                case Keys.NumPad1:
                    card.Face = Face.Ace;
                    AddCard(card, false);
                    break;
                case Keys.NumPad2:
                    card.Face = Face.Two;
                    AddCard(card, false);
                    break;
                case Keys.NumPad3:
                    card.Face = Face.Three;
                    AddCard(card, false);
                    break;
                case Keys.NumPad4:
                    card.Face = Face.Four;
                    AddCard(card, false);
                    break;
                case Keys.NumPad5:
                    card.Face = Face.Five;
                    AddCard(card, false);
                    break;
                case Keys.NumPad6:
                    card.Face = Face.Six;
                    AddCard(card, false);
                    break;
                case Keys.NumPad7:
                    card.Face = Face.Seven;
                    AddCard(card, false);
                    break;
                case Keys.NumPad8:
                    card.Face = Face.Eight;
                    AddCard(card, false);
                    break;
                case Keys.NumPad9:
                    card.Face = Face.Nine;
                    AddCard(card, false);
                    break;
                case Keys.D0:
                    card.Face = Face.Ten;
                    AddCard(card, true);
                    break;
                case Keys.D1:
                    card.Face = Face.Ace;
                    AddCard(card, true);
                    break;
                case Keys.D2:
                    card.Face = Face.Two;
                    AddCard(card, true);
                    break;
                case Keys.D3:
                    card.Face = Face.Three;
                    AddCard(card, true);
                    break;
                case Keys.D4:
                    card.Face = Face.Four;
                    AddCard(card, true);
                    break;
                case Keys.D5:
                    card.Face = Face.Five;
                    AddCard(card, true);
                    break;
                case Keys.D6:
                    card.Face = Face.Six;
                    AddCard(card, true);
                    break;
                case Keys.D7:
                    card.Face = Face.Seven;
                    AddCard(card, true);
                    break;
                case Keys.D8:
                    card.Face = Face.Eight;
                    AddCard(card, true);
                    break;
                case Keys.D9:
                    card.Face = Face.Nine;
                    AddCard(card, true);
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
