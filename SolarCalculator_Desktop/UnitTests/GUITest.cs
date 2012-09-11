using SolarCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for GUITest and is intended
    ///to contain all GUITest Unit Tests
    ///</summary>
    [TestClass()]
    public class GUITest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for CleanUp
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SolarCalculator.exe")]
        public void CleanUpTest()
        {
            GUI_Accessor target = new GUI_Accessor(); // TODO: Initialize to an appropriate value
            target.btnCalculate.Enabled = false;

            target.CleanUp();
            Assert.IsTrue(target.btnCalculate.Enabled);
        }

        /// <summary>
        ///A test for Output
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SolarCalculator.exe")]
        public void OutputTest()
        {
            GUI_Accessor target = new GUI_Accessor(); // TODO: Initialize to an appropriate value
            target.btnCalculate.Enabled = false;
            target.label9.Text = "NO-ONE WILL KNOW";

            string stringToOutput = "FOR TEH LULZ"; // TODO: Initialize to an appropriate value
            target.Output(stringToOutput);

            Assert.IsTrue(target.btnCalculate.Enabled);
            Assert.AreEqual(target.label9.Text, stringToOutput);
        }

        /// <summary>
        ///A test for GenerateUriString
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SolarCalculator.exe")]
        public void GenerateUriStringTest()
        {
            GUI_Accessor target = new GUI_Accessor(); // TODO: Initialize to an appropriate value
            target.numNumberOfPanels.Value = 5;
            target.numHoursOfDaylight.Value = 8;
            target.numDaytimeUsage.Value = 2;
            target.numPanelOutput.Value = 150;
            target.numPanelEfficiency.Value = 100;
            target.numInverterEfficiency.Value = 99;

            string expected = "http://solarpanelcalc.appspot.com/outputxml.jsp?numpanels=5&daylighthours=8&hourlyusage=2&paneloutput=150&panelefficiency=100&inverterefficiency=99"; // TODO: Initialize to an appropriate value

            string actual;
            actual = target.GenerateUriString();

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for QueryServer
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SolarCalculator.exe")]
        public void QueryServerTest()
        {
            GUI_Accessor target = new GUI_Accessor(); // TODO: Initialize to an appropriate value
            target.btnCalculate.Enabled = false;
            target.label9.Text = "NO-ONE WILL KNOW";

            string uriTarget = "http://solarpanelcalc.appspot.com/outputxml.jsp?numpanels=5&daylighthours=8&hourlyusage=2&paneloutput=150&panelefficiency=100&inverterefficiency=99"; // TODO: Initialize to an appropriate value

            target.QueryServer(uriTarget);

            Assert.IsTrue(target.btnCalculate.Enabled);
            Assert.AreEqual(target.label9.Text, "5.94");
        }
    }
}
