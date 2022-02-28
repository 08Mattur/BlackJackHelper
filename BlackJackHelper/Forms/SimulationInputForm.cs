using BlackJackHelper.Logic.Services;
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
    public partial class SimulationInputForm : Form
    {
        public SimulationInputForm()
        {
            InitializeComponent();
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            var bank = Convert.ToDouble(txtInitialBank.Text);
            var amount = Convert.ToDouble(txtAmountPerBet.Text);
            var hands = Convert.ToInt32(txtHandsToPlay.Text);
            var simulationService = new SimulationService(bank, amount, hands);

            var result = simulationService.Simulate();
            var form = new SimulationResultForm();
            form.SetResult(result);
            form.ShowDialog();
            this.Close();
        }
    }
}
