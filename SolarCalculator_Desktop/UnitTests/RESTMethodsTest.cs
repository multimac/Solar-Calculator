using SolarCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for RESTMethodsTest and is intended
    ///to contain all RESTMethodsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RESTMethodsTest
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
        ///A test for Request
        ///</summary>
        [TestMethod()]
        public void RequestTest()
        {
            Uri target = new Uri("http://solarpanelcalc.appspot.com/outputxml.jsp?numpanels=5&daylighthours=8&hourlyusage=2&paneloutput=150&panelefficiency=100&inverterefficiency=98"); // TODO: Initialize to an appropriate value
            RequestMethod method = RequestMethod.GET; // TODO: Initialize to an appropriate value
            string expected = "<?xml version=\"1.0\" ?><solorcalculator><grossoutput>5.88</grossoutput><netoutput>5.864</netoutput></solorcalculator>"; // TODO: Initialize to an appropriate value

            string actual;
            actual = RESTMethods.Request(target, method);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Request
        ///</summary>
        [TestMethod()]
        public void RequestTest1()
        {
            Uri target = new Uri("http://solarpanelcalc.appspot.com/outputxml.jsp?numpanels=5&daylighthours=8&hourlyusage=2&paneloutput=150&panelefficiency=100&inverterefficiency=98"); // TODO: Initialize to an appropriate value
            RequestMethod method = RequestMethod.GET; // TODO: Initialize to an appropriate value
            ContentType type = ContentType.Text_XML; // TODO: Initialize to an appropriate value
            byte[] data = null; // TODO: Initialize to an appropriate value
            string expected = "<?xml version=\"1.0\" ?><solorcalculator><grossoutput>5.88</grossoutput><netoutput>5.864</netoutput></solorcalculator>"; // TODO: Initialize to an appropriate value

            string actual;
            actual = RESTMethods.Request(target, method, type, data);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Request
        ///</summary>
        [TestMethod()]
        public void RequestTest2()
        {
            Uri target = new Uri("http://solarpanelcalc.appspot.com/"); // TODO: Initialize to an appropriate value
            RequestMethod method = RequestMethod.POST; // TODO: Initialize to an appropriate value
            ContentType type = ContentType.Text_XML; // TODO: Initialize to an appropriate value
            byte[] data = Encoding.ASCII.GetBytes("numpanels=5&daylighthours=8&hourlyusage=2&paneloutput=150&panelefficiency=100&inverterefficiency=98"); // TODO: Initialize to an appropriate value
            string expected = "<?xml version=\"1.0\" ?><solorcalculator><grossoutput>5.88</grossoutput><netoutput>5.864</netoutput></solorcalculator>"; // TODO: Initialize to an appropriate value

            string actual;
            actual = RESTMethods.Request(target, method, type, data);
            Assert.AreEqual(expected, actual);
        }
    }
}
