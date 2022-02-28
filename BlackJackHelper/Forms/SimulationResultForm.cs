using BlackJackHelper.Logic.Objects;

namespace BlackJackHelper.Forms
{
    public partial class SimulationResultForm : Form
    {
        private SimulationResult _simulationResult;
        public SimulationResultForm()
        {
            InitializeComponent();
        }

        public void SetResult(SimulationResult simulationResult)
        {
            _simulationResult = simulationResult;
            lblEndResult.Text = simulationResult.EndBankRoll.ToString();
        }
    }
}
