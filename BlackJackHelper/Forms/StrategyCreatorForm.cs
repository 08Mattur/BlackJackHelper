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
    public partial class StrategyCreatorForm : Form
    {
        public StrategyCreatorForm()
        {
            InitializeComponent();
            FillHardGrid();
        }

        private void FillHardGrid()
        {
            var grid = dgvHard;
            grid.Rows.Clear();
            grid.Rows.Add("3");
            grid.Rows.Add("4");
            grid.Rows.Add("5");
            grid.Rows.Add("6");
            grid.Rows.Add("7");
            grid.Rows.Add("8");
            grid.Rows.Add("9");
            grid.Rows.Add("10");
            grid.Rows.Add("11");
            grid.Rows.Add("12");
            grid.Rows.Add("13");
            grid.Rows.Add("14");
            grid.Rows.Add("15");
            grid.Rows.Add("16");
            grid.Rows.Add("17");
            grid.Rows.Add("18");
            grid.Rows.Add("19");
            grid.Rows.Add("20");
            grid.Rows.Add("21");
        }
    }
}
