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
        
        const string TemplateOfflineUri = "http://localhost:8888/outputxml.jsp?numpanels={0}&paneloutput{1}";
        const string TemplateOnlineUri = "http://solarpanelcalc.appspot.com/outputxml.jsp?numpanels={0}&paneloutput{1}";
         
        public CostCalculation()
        {
            InitializeComponent();
        }

        //Combine inputs into a URL string to use in the HttpMethods.Request
        private string GenerateUriString()
        {
            return string.Format(TemplateOnlineUri, numNumPan.Text, numPanOut.Text);
        }

        private void QueryServer(object uriTarget)
        {
            string uriString = uriTarget as string;
            if (uriString == null)
                throw new Exception("Cannot be null.");

            string xmlInput = RESTMethods.Request(new Uri(uriString),RequestMethod.GET);

            //Checking response
            if (xmlInput == null)
            {
                MessageBox.Show("There was an error connecting to the server.");
                CleanUp();
                return;
            }

            xmlInput = xmlInput.Remove(0, xmlInput.IndexOf('>') + 1);

            string systemCost; //Creating xmlReader to parse through response
            using (XmlReader reader = XmlReader.Create(new StringReader(xmlInput)))
            {
                reader.ReadToFollowing("cost");
                systemCost = reader.ReadElementContentAsString();
            }
            Output(systemCost);
        }

        private void Output(string stringToOutput)
        {
            if (lblSysCost.InvokeRequired)
            {
                StringDelegate call = new StringDelegate(Output);
                BeginInvoke(call, stringToOutput);
            }
            else
            {
                lblSysCost.Text = stringToOutput.ToString();
                CleanUp();
            }       
        }

        private void CleanUp() 
        {
            if (lblSysCost.InvokeRequired)
                BeginInvoke(new MethodInvoker(CleanUp));
            else
            {
                btnCalc.Enabled = true;
            }        
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var MainMenu = new MainMenu();
            this.Hide();
            MainMenu.Show();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            btnCalc.Enabled = false;

            ParameterizedThreadStart startInfo = new ParameterizedThreadStart(QueryServer);
            Thread thread = new Thread(startInfo);
            thread.IsBackground = true;

            thread.Start(GenerateUriString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
