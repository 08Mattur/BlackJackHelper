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
            ucDealerSuitClubs.SetProperties(Suit.Clubs, this, true);
            ucDealerSuitDiamonds.SetProperties(Suit.Diamonds, this, true);
            ucDealerSuitHearts.SetProperties(Suit.Hearts, this, true);
            ucDealerSuitSpades.SetProperties(Suit.Spades, this, true);

            ucPlayerSuitClubs.SetProperties(Suit.Clubs, this, false);
            ucPlayerSuitDiamonds.SetProperties(Suit.Diamonds, this, false);
            ucPlayerSuitHearts.SetProperties(Suit.Hearts, this, false);
            ucPlayerSuitSpades.SetProperties(Suit.Spades, this, false);
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
        }

        private void btnNewHand_Click(object sender, EventArgs e)
        {
            _dealerHand = new Hand();
            _playerHand = new Hand();

            lstDealerHand.Items.Clear();

            lblPlayerValue.Text = "";
            lstPlayerHand.Items.Clear();

            lblWhatDo.Text = "";
        }

        private void btnWhatDo_Click(object sender, EventArgs e)
        {
            var shouldHit = _playerEngine.ShouldHit(_playerHand, _dealerHand);

            if (shouldHit)
            {
                lblWhatDo.Text = "Hit";
            } else
            {
                lblWhatDo.Text = "Stick";
            }
        }
    }
}
