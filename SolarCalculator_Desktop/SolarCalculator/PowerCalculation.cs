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
    public partial class PowerCalculation : Form
    {
        private class QueryHolder
        {
            public string UrlString;
            public Action<string> Callback;

            public QueryHolder(string urlString, Action<string> callback)
            {
                this.UrlString = urlString;
                this.Callback = callback;
            }
        }

        public delegate string StringReturnDelegate();
        public delegate void StringParseDelegate(string input);

        const string PowerOfflineUri = "http://localhost:8888/powercalcxml.jsp?numpanels={0}&daylighthours={1}&monthlyconsumption={2}&paneloutput={3}&panelefficiency={4}&inverterefficiency={5}&importrate={6}&exportrate={7}";
        const string PowerOnlineUri = "http://solarpanelcalc.appspot.com/powercalcxml.jsp?numpanels={0}&daylighthours={1}&monthlyconsumption={2}&paneloutput={3}&panelefficiency={4}&inverterefficiency={5}&importrate={6}&exportrate={7}";

        const string CostOfflineUri = "http://localhost:8888/costcalcxml.jsp?numpanels={0}&paneloutput={1}";
        const string CostOnlineUri = "http://solarpanelcalc.appspot.com/costcalcxml.jsp?numpanels={0}&paneloutput={1}";


        public PowerCalculation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Combine inputs into a URL string to use in the HttpMethods.Request
        /// </summary>
        private string GeneratePowerUriString()
        {
            if (InvokeRequired)
                return Invoke(new StringReturnDelegate(GeneratePowerUriString)) as string;

            return string.Format(PowerOnlineUri, numNumberOfPanels.Text, numHoursOfDaylight.Text, numMonthlyUsage.Text, numPanelOutput.Text, numPanelEfficiency.Text, numInverterEfficiency.Text, numImportPrice.Value * 100, numExportPrice.Value * 100);
        }
        private string GenerateCostUriString()
        {
            return string.Format(CostOnlineUri, numNumberOfPanels.Text, numPanelOutput.Text);
        }

        private void QueryServer(QueryHolder arguments)
        {
            QueryHolder query = arguments as QueryHolder;
            if (query == null || query.UrlString == null)
                throw new Exception("QueryHolder or UrlString cannot be null");

            string response = RESTMethods.Request(new Uri(query.UrlString), RequestMethod.GET);

            // If we get a response
            if (response == null)
            {
                MessageBox.Show("There was an error connecting to the server");
                CleanUp();
                return;
            }

            if (query.Callback != null)
                query.Callback(response);
        }

        private void Calculate(object sender, EventArgs e)
        {
            btnCalculate.Enabled = false;

            ThreadStart startInfo = new ThreadStart(ContactServer);
            Thread thread = new Thread(startInfo);
            thread.IsBackground = true;

            thread.Start();
        }
        private void ContactServer()
        {
            QueryHolder query = new QueryHolder(GeneratePowerUriString(), SetPowerGenerated);
            QueryServer(query);

            query = new QueryHolder(GenerateCostUriString(), SetExtraInfo);
            QueryServer(query);

            CleanUp();
        }

        float moneyMadePerDay;
        private void SetPowerGenerated(string xmlInput)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new StringParseDelegate(SetPowerGenerated), xmlInput);
                return;
            }

            xmlInput = xmlInput.Remove(0, xmlInput.IndexOf('>') + 1);
            using (XmlReader reader = XmlReader.Create(new StringReader(xmlInput))) // Create an XmlReader to parse the reponse from the server
            {
                float gross, net;
                gross = net = 0.0f;

                reader.ReadToFollowing("grossoutput"); // Move to the output tag
                gross = reader.ReadElementContentAsFloat();

                net = reader.ReadElementContentAsFloat();
                moneyMadePerDay = net * (float)numExportPrice.Value;

                label9.Text = string.Format("Per Day: Gross - {0:0.00} KWh, Net - {1:0.00} KWh", gross, net); // Read the content from that tag as a string
                label10.Text = string.Format("Per Month: Gross - {0:0.00} KWh, Net - {1:0.00} KWh", gross * 30, net * 30); // Read the content from that tag as a string
                label11.Text = string.Format("Per Year: Gross - {0:0.00} KWh, Net - {1:0.00} KWh", gross * 356, net * 356); // Read the content from that tag as a string

                label14.Text = string.Format("Per Day: ${0:0.00}", moneyMadePerDay); // Read the content from that tag as a string
                label13.Text = string.Format("Per Month: ${0:0.00}", moneyMadePerDay * 30); // Read the content from that tag as a string
                label12.Text = string.Format("Per Year: ${0:0.00}", moneyMadePerDay * 356); // Read the content from that tag as a string
            }
        }
        private void SetExtraInfo(string xmlInput)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new StringParseDelegate(SetExtraInfo), xmlInput);
                return;
            }

            xmlInput = xmlInput.Remove(0, xmlInput.IndexOf('>') + 1);
            using (XmlReader reader = XmlReader.Create(new StringReader(xmlInput))) // Create an XmlReader to parse the reponse from the server
            {
                reader.ReadToFollowing("cost"); // Move to the output tag

                float cost = reader.ReadElementContentAsFloat();

                label20.Text = string.Format("System Cost: ${0:0.00}", cost); // Read the content from that tag as a string
                label21.Text = string.Format("Breakeven Time: {0:0} days", Math.Ceiling(cost / moneyMadePerDay));
            }
        }
        private void CleanUp()
        {
            if (InvokeRequired)
                BeginInvoke(new MethodInvoker(CleanUp));
            else
                btnCalculate.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PowerCalculation_FormClosing(object sender, CancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", null, MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                e.Cancel = true;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }
    }
}
