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
    public partial class GUI : Form
    {
        public delegate void StringDelegate(string input);

        const string TemplateOfflineUri = "http://localhost:8888/powercalcxml.jsp?numpanels={0}&daylighthours={1}&hourlyusage={2}&paneloutput={3}&panelefficiency={4}&inverterefficiency={5}";
        const string TemplateOnlineUri = "http://solarpanelcalc.appspot.com/powercalcxml.jsp?numpanels={0}&daylighthours={1}&hourlyusage={2}&paneloutput={3}&panelefficiency={4}&inverterefficiency={5}";


        public GUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Combine inputs into a URL string to use in the HttpMethods.Request
        /// </summary>
        private string GenerateUriString()
        {
            return string.Format(TemplateOnlineUri, numNumberOfPanels.Text, numHoursOfDaylight.Text, numDaytimeUsage.Text, numPanelOutput.Text, numPanelEfficiency.Text, numInverterEfficiency.Text);
        }
        private void QueryServer(object uriTarget)
        {
            string uriString = uriTarget as string;
            if (uriString == null)
                throw new Exception("Cannot be null.");

            string xmlInput = RESTMethods.Request(new Uri(uriString), RequestMethod.GET);

            // If we get a response
            if (xmlInput == null)
            {
                MessageBox.Show("There was an error connecting to the server");
                CleanUp();
                return;
            }

            xmlInput = xmlInput.Remove(0, xmlInput.IndexOf('>') + 1);

            string systemOutput; // Create an XmlReader to parse the reponse from the server
            using (XmlReader reader = XmlReader.Create(new StringReader(xmlInput)))
            {
                reader.ReadToFollowing("grossoutput"); // Move to the output tag
                systemOutput = reader.ReadElementContentAsString(); // Read the content from that tag as a string
            }
            
            Output(systemOutput);
        }
        private void Output(string stringToOutput)
        {
            if (label9.InvokeRequired)
            {
                StringDelegate call = new StringDelegate(Output);
                BeginInvoke(call, stringToOutput);
            }
            else
            {
                label9.Text = stringToOutput.ToString();
                CleanUp();
            }
        }
        private void CleanUp()
        {
            if (label9.InvokeRequired)
                BeginInvoke(new MethodInvoker(CleanUp));
            else
            {
                btnCalculate.Enabled = true;
            }
        }
        private void Calculate(object sender, EventArgs e)
        {
            btnCalculate.Enabled = false;
            
            ParameterizedThreadStart startInfo = new ParameterizedThreadStart(QueryServer);
            Thread thread = new Thread(startInfo);
            thread.IsBackground = true;

            thread.Start(GenerateUriString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            var MainMenu = new MainMenu();
            this.Hide();
            MainMenu.Show();
        }
    }
}
