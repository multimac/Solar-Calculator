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

namespace SolarCalculator
{
    public partial class GUI : Form
    {
        const string TemplateOfflineUri = "http://localhost:8888/outputxml.jsp?numpanels={0}&daylighthours={1}&hourlyusage={2}&paneloutput={3}&panelefficiency={4}&inverterefficiency={5}";
        const string TemplateOnlineUri = "http://solarpanelcalc.appspot.com/outputxml.jsp?numpanels={0}&daylighthours={1}&hourlyusage={2}&paneloutput={3}&panelefficiency={4}&inverterefficiency={5}";

        public GUI()
        {
            InitializeComponent();
        }

        private string GenerateUriString()
        {
            return string.Format(TemplateOnlineUri, txtNumberOfPanels.Text, txtHoursOfDaylight.Text, txtDaytimeUsage.Text, txtSystemSize.Text, txtPanelEfficiency.Text, txtInverterEfficiency.Text);
        }
        private void Calculate(object sender, EventArgs e)
        {
            string xmlInput = HttpMethods.Request(new Uri(GenerateUriString()), RequestMethod.GET);

            if (xmlInput == null)
            {
                MessageBox.Show("There was an error connecting to the server");
                return;
            }

            xmlInput = xmlInput.Remove(0, xmlInput.IndexOf('>'));

            string systemOutput;
            using (XmlReader reader = XmlReader.Create(new StringReader(xmlInput)))
            {
                reader.ReadToFollowing("output");
                systemOutput = reader.ReadElementContentAsString();
            }

            label9.Text = "Power Generated Per Day: " + systemOutput;
        }
    }
}
