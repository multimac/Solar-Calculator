using SolarCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace UnitTests
{


    /// <summary>
    ///This is a test class for PowerCalculationTest and is intended
    ///to contain all PowerCalculationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PowerCalculationTest
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
            PowerCalculation_Accessor target = new PowerCalculation_Accessor(); // TODO: Initialize to an appropriate value
            target.btnCalculate.Enabled = false;

            target.CleanUp();
            Assert.IsTrue(target.btnCalculate.Enabled);
        }

        /// <summary>
        ///A test for Output
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SolarCalculator.exe")]
        public void PowerGeneratedTest()
        {
            PowerCalculation_Accessor target = new PowerCalculation_Accessor(); // TODO: Initialize to an appropriate value
            target.btnCalculate.Enabled = false;
            target.label9.Text = "NO-ONE WILL KNOW";

            string stringToOutput = "FOR TEH LULZ"; // TODO: Initialize to an appropriate value
            target.SetPowerGenerated(stringToOutput);

            Assert.IsTrue(target.btnCalculate.Enabled);
            Assert.AreEqual(target.label9.Text, stringToOutput);
        }

        /// <summary>
        ///A test for Output
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SolarCalculator.exe")]
        public void CostTest()
        {
            PowerCalculation_Accessor target = new PowerCalculation_Accessor(); // TODO: Initialize to an appropriate value
            target.btnCalculate.Enabled = false;
            target.label9.Text = "NO-ONE WILL KNOW";

            string stringToOutput = "FOR TEH LULZ"; // TODO: Initialize to an appropriate value
            target.SetExtraInfo(stringToOutput);

            Assert.IsTrue(target.btnCalculate.Enabled);
            Assert.AreEqual(target.label20.Text, stringToOutput);
        }

        /// <summary>
        ///A test for GenerateUriString
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SolarCalculator.exe")]
        public void GenerateUriStringTest()
        {
            PowerCalculation_Accessor target = new PowerCalculation_Accessor(); // TODO: Initialize to an appropriate value
            target.numNumberOfPanels.Value = 5;
            target.numHoursOfDaylight.Value = 8;
            target.numMonthlyUsage.Value = 2;
            target.numPanelOutput.Value = 150;
            target.numPanelEfficiency.Value = 100;
            target.numInverterEfficiency.Value = 99;

            string expected = "http://solarpanelcalc.appspot.com/powercalcxml.jsp?numpanels=5&daylighthours=8&hourlyusage=2&paneloutput=150&panelefficiency=100&inverterefficiency=99"; // TODO: Initialize to an appropriate value

            string actual;
            actual = target.GeneratePowerUriString();

            Assert.AreEqual(expected, actual);
        }
    }
}
