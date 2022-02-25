using BlackJackHelper.Logic.Engines;
using BlackJackHelper.Logic.Enums;
using BlackJackHelper.Logic.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackHelper.Forms
{
    public partial class MainForm : Form
    {
        private Hand _dealerHand { get; set; }
        private Hand _playerHand { get; set; }
        private PlayerEngine _playerEngine { get; set; }

        public MainForm()
        {
            InitializeComponent();
            _dealerHand = new Hand();
            _playerHand = new Hand();
            _playerEngine = new PlayerEngine();

            BindSuits();
        }

        private void BindSuits()
        {
            ucDealerSuitClubs.SetProperties(this, true);
            ucPlayerSuitClubs.SetProperties(this, false);
        }

        public void AddCard(Card card, bool isDealer)
        {
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
        }

        private void WhatDo()
        {
            var shouldHit = _playerEngine.WhatDo(_playerHand, _dealerHand);

            switch (shouldHit)
            {
                case ResultAction.Hit:
                    lblWhatDo.Text = "You should hit";
                    break;
                case ResultAction.Stand:
                    lblWhatDo.Text = "You should stand";
                    break;
                case ResultAction.Double:
                    lblWhatDo.Text = "You should double";
                    break;
                case ResultAction.Split:
                    lblWhatDo.Text = "You should split";
                    break;
                case ResultAction.Bust:
                    lblWhatDo.Text = "You are bust";
                    break;
                case ResultAction.DoubleOrStand:
                    lblWhatDo.Text = "You should double if you can, stand otherwise.";
                    break;
                case ResultAction.DoubleOrHit:
                    lblWhatDo.Text = "You should double if you can, hit otherwise.";
                    break;
                case ResultAction.Incalculable:
                    lblWhatDo.Text = "This is impossible.";
                    break;
            }
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
            }
        }
    }
}
