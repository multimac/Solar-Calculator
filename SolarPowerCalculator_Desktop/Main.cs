using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SolarPowerCalculator_Desktop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void chkAdvanced_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toggleAdvanceFields (bool visible)
        {
            lblPanelEfficiency.Visible = visible;
            numPanelEfficiency.Visible = visible;
            lblPanelDegredation.Visible = visible;
            numPanelDegredation.Visible = visible;
            lblPanelDensity.Visible = visible;
            numPanelDensity.Visible = visible;
            lblInverterEfficiency.Visible = visible;
            numInverterEfficiency.Visible = visible;
        }

        private void showInputs()
        {

        }

        private void comboCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCalculate.Enabled = false;
            comboCities.Enabled = false;
            bkgLoadCity.RunWorkerAsync(comboCities.Text);
        }


        private void bkgLoadCity_DoWork(object sender, DoWorkEventArgs e)
        {
            string chosenCity = (string)e.Argument;

            string result = Rest.makeRequest("POST", "http://solarpanelcalc.appspot.com/cityxml.jsp", "", "", "name=" + chosenCity);
            XDocument doc = XDocument.Parse(result);
            XElement cityResult = doc.Descendants("solarcalculator").ElementAtOrDefault(0);
            if (cityResult.Element("error").Value == "noerror")
            {
                Invoke(new MethodInvoker(delegate
                {
                    numRoofTempWinter.Value = Decimal.Parse(cityResult.Element("meanrooftempw").Value);
                    numRoofTempSummer.Value = Decimal.Parse(cityResult.Element("meanrooftemps").Value);
                    numSolarInsolationWinter.Value = Decimal.Parse(cityResult.Element("solarinsolationw").Value);
                    numSolarInsolationSummer.Value = Decimal.Parse(cityResult.Element("solarinsolations").Value);
                    numImportTariff.Value = Decimal.Parse(cityResult.Element("importtariff").Value);
                    numExportTariff.Value = Decimal.Parse(cityResult.Element("exporttariff").Value);
                    numDaylightHoursWinter.Value = Decimal.Parse(cityResult.Element("daylighthoursw").Value);
                    numDaylightHoursSummer.Value = Decimal.Parse(cityResult.Element("daylighthourss").Value);

                }));
            }
        }

        private void chkSimpleSettings_CheckedChanged(object sender, EventArgs e)
        {
            numRoofTempWinter.Enabled = !chkSimpleSettings.Checked;
            numRoofTempSummer.Enabled = !chkSimpleSettings.Checked;
            numSolarInsolationWinter.Enabled = !chkSimpleSettings.Checked;
            numSolarInsolationSummer.Enabled = !chkSimpleSettings.Checked;
            numExportTariff.Enabled = !chkSimpleSettings.Checked;
            numDaylightHoursWinter.Enabled = !chkSimpleSettings.Checked;
            numDaylightHoursSummer.Enabled = !chkSimpleSettings.Checked;
            numPanelEfficiency.Enabled = !chkSimpleSettings.Checked;
            numPanelDegredation.Enabled = !chkSimpleSettings.Checked;
            numPanelDensity.Enabled = !chkSimpleSettings.Checked;
            numTemperatureCoefficient.Enabled = !chkSimpleSettings.Checked;
            numInverterEfficiency.Enabled = !chkSimpleSettings.Checked;

        }

        private string constructPOSTData()
        {
            StringBuilder data = new StringBuilder();
            data.Append("panelcount=" +  numPanelNum.Value.ToString());
            data.Append("&paneloutput=" + numPanelOutput.Value.ToString());
            data.Append("&inverterefficiency=" + numInverterEfficiency.Value.ToString());
            data.Append("&paneldensity=" + numPanelDensity.Value.ToString());
            data.Append("&panelefficiency=" + numPanelEfficiency.Value.ToString());
            data.Append("&paneldegradation=" + numPanelDegredation.Value.ToString());
            data.Append("&tempcoefficient=" + numTemperatureCoefficient.Value.ToString());
            data.Append("&daylighthoursw=" + numDaylightHoursWinter.Value.ToString());
            data.Append("&daylighthourss=" + numDaylightHoursSummer.Value.ToString());
            data.Append("&monthlyconsumptionw=" + numMonthlyWinterConsumption.Value.ToString());
            data.Append("&monthlyconsumptions=" + numMonthlySummerConsumption.Value.ToString());
            data.Append("&exporttariff=" + numExportTariff.Value.ToString());
            data.Append("&importtariff=" + numImportTariff.Value.ToString());
            data.Append("&rooftempw=" + numRoofTempWinter.Value.ToString());
            data.Append("&rooftemps=" + numRoofTempSummer.Value.ToString());
            data.Append("&solarinsolationw=" + numSolarInsolationWinter.Value.ToString());
            data.Append("&solarinsolations=" + numSolarInsolationSummer.Value.ToString());
            return data.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string data = constructPOSTData();
            bkgCalculate.RunWorkerAsync(data);
        }

        private void bkgCalculate_DoWork(object sender, DoWorkEventArgs e)
        {
            string data = (string)e.Argument;

            string result = Rest.makeRequest("POST", "http://solarpanelcalc.appspot.com/calcxml.jsp", "", "", data);
            try
            {
                XDocument doc = XDocument.Parse(result);
                XElement calcResults = doc.Descendants("solarcalculator").ElementAtOrDefault(0);
                if (calcResults.Element("error").Value == "noerror")
                {
                    Invoke(new MethodInvoker(delegate
                    {
                        lblWinterGeneration.Text = "Winter Generation: " + calcResults.Element("grossmonthlyoutputw").Value + "(KWh)";
                        lblSummerGeneration.Text = "Summer Generation: " + calcResults.Element("grossmonthlyoutputs").Value + "(KWh)";
                        lblWinterSavings.Text = "Winter Savings: $" + calcResults.Element("monlthysavingsw").Value;
                        lblSummerSavings.Text = "Summer Savings: $" + calcResults.Element("monlthysavingss").Value;
                        lblFirstYearGeneration.Text = "First Year Generation: " + calcResults.Element("firstyearoutput").Value + "(KWh)";
                        lblFirstYearSavings.Text = "First Year Savings: $" + calcResults.Element("firstyearsavings").Value;
                        lblSystemCost.Text = "System Cost: $" + calcResults.Element("systemcost").Value;
                        lblBreakEven.Text = "Break Even Time: " + calcResults.Element("breakeventime").Value;
                    }));
                }
            }
            catch
            {
                MessageBox.Show("An internal error has occured. Please try your calculation again.");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            comboCities.SelectedIndex = 0;
            chkSimpleSettings.Checked = true;
        }

        private void bkgLoadCity_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnCalculate.Enabled = true;
            comboCities.Enabled = true;
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }



    }
}
