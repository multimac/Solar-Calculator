using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SolarCalculator
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCost_Click(object sender, EventArgs e)
        {
            var CostGui = new CostCalculation();
            this.Hide();
            CostGui.Show();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            var OutputGui = new GUI();
            this.Hide();
            OutputGui.Show();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirm Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
