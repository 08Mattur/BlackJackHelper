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

            BindDropdowns();
        }

        private void BindDropdowns()
        {
            BindSuitDropdowns();
            BindFaceDropdowns();
        }

        private void BindSuitDropdowns()
        {
            var suits = Enum.GetNames(typeof(Logic.Enums.Suit));

            for (int i = 0; i < suits.Length; i++)
            {
                cmbDealerSuit.Items.Add(suits[i].ToString());
                cmbPlayerSuit.Items.Add(suits[i].ToString());
            }
        }

        private void BindFaceDropdowns()
        {
            var faces = Enum.GetNames(typeof(Logic.Enums.Face));

            for (int i = 0; i < faces.Length; i++)
            {
                cmbDealerFace.Items.Add(faces[i].ToString());
                cmbPlayerFace.Items.Add(faces[i].ToString());
            }
        }

        private void btnAddDealerCard_Click(object sender, EventArgs e)
        {
            var card = new Card()
            {
                Face = (Face)cmbDealerFace.SelectedIndex,
                Suit = (Suit)cmbDealerSuit.SelectedIndex,
            };
            _dealerHand.AddCard(card);
            lstDealerHand.Items.Add(card.Name);

            lblDealerValue.Text = _dealerHand.Value.ToString();
        }

        private void btnNewHand_Click(object sender, EventArgs e)
        {
            _dealerHand = new Hand();
            _playerHand = new Hand();

            lblDealerValue.Text = "";
            lstDealerHand.Items.Clear();
            cmbDealerFace.SelectedIndex = -1;
            cmbDealerSuit.SelectedIndex = -1;

            lblPlayerValue.Text = "";
            lstPlayerHand.Items.Clear();
            cmbPlayerFace.SelectedIndex = -1;
            cmbPlayerSuit.SelectedIndex = -1;

            lblWhatDo.Text = "";
        }

        private void btnAddPlayerCard_Click(object sender, EventArgs e)
        {
            var card = new Card()
            {
                Face = (Face)cmbPlayerFace.SelectedIndex,
                Suit = (Suit)cmbPlayerSuit.SelectedIndex
            };
            _playerHand.AddCard(card);
            lstPlayerHand.Items.Add(card.Name);

            lblPlayerValue.Text = _playerHand.Value.ToString();
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
