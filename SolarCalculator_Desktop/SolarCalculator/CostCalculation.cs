using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Threading;

namespace SolarCalculator
{
    public partial class CostCalculation : Form
    {
        
        public delegate void StringDelegate(string input);

        //Todo: Const Strings, don't know how to use

        /*
         * const string TemplateOfflineUri = "http://localhost:8888/outputxml.jsp?";
         * const string TemplateOnlineUri = "http://solarpanelcalc.appspot.com/outputxml.jsp?";
         */


        public CostCalculation()
        {
            InitializeComponent();
        }

        //Combine inputs into a URL string to use in the HttpMethods.Request
        private string GenerateUriString() {

            //return string.Format;
        }

        private void CostCalculation_FormClosing(object sender, FormClosingEventArgs e)
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
