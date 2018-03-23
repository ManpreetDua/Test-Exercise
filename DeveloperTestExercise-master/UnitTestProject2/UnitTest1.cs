using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVersionSC1()
        {
            ///Verifying -v version value
            String actualversion, expectedversion;
            clsFuncExecution objclsFuncExecution = new clsFuncExecution();
            actualversion = objclsFuncExecution.funcexecution("-v", "c:/test.txt");
            expectedversion = " File Version: 1.2.45";
            Assert.AreEqual<string>(expectedversion, actualversion, " Validating version values with -v ");

        }
        [TestMethod]
        public void TestVersionSC2()
        {
            ///Verifying --v version value
            String actualversion, expectedversion;
            clsFuncExecution objclsFuncExecution = new clsFuncExecution();
            actualversion = objclsFuncExecution.funcexecution("--v", "c:/test.txt");
            expectedversion = " File Version: 1.2.49";
            Assert.AreEqual<string>(expectedversion, actualversion, "Validating version values with --v");

        }
        [TestMethod]
        public void TestVersionSC3()
        {
            ///Verifying /v version value
            String actualversion, expectedversion;
            clsFuncExecution objclsFuncExecution = new clsFuncExecution();
            actualversion = objclsFuncExecution.funcexecution("/v", "c:/test.txt");
            expectedversion = " File Version: 1.2.40";
            Assert.AreEqual<string>(expectedversion, actualversion, "Validating version values with /v");

        }
        [TestMethod]
        public void TestVersionSC4()
        {
            ///Verifying --version version value
            String actualversion, expectedversion;
            clsFuncExecution objclsFuncExecution = new clsFuncExecution();
            actualversion = objclsFuncExecution.funcexecution("--version", "c:/test.txt");
            expectedversion = " File Version: 1.2.40";
            Assert.AreEqual<string>(expectedversion, actualversion, "Validating version values with --version");

        }

        [TestMethod]
        public void TestSizeSc1()
        {
            ///Verifying -s size value
            string actualsize, expectedsize;
            clsFuncExecution objclsFuncExecution = new clsFuncExecution();
            actualsize = objclsFuncExecution.funcexecution("-s", "c:/test.txt");
            expectedsize = " File Version: 136102";
            Assert.AreEqual<string>(expectedsize, actualsize, "Validating size values with -s");


        }
        [TestMethod]
        public void TestSizeSc2()
        {
            ///Verifying --s size value
            string actualsize, expectedsize;
            clsFuncExecution objclsFuncExecution = new clsFuncExecution();
            actualsize = objclsFuncExecution.funcexecution("--s", "c:/test.txt");
            expectedsize = " File Version: 137102";
            Assert.AreEqual<string>(expectedsize, actualsize, "Validating size values with --s");


        }
        [TestMethod]
        public void TestSizeSc3()
        {
            ///Verifying /s size value
            string actualsize, expectedsize;
            clsFuncExecution objclsFuncExecution = new clsFuncExecution();
            actualsize = objclsFuncExecution.funcexecution("/s", "c:/test.txt");
            expectedsize = " File Version: 137102";
            Assert.AreEqual<string>(expectedsize, actualsize, "Validating size values with /s");


        }
        [TestMethod]
        public void TestSizeSc4()
        {
            ///Verifying --size size value
            string actualsize, expectedsize;
            clsFuncExecution objclsFuncExecution = new clsFuncExecution();
            actualsize = objclsFuncExecution.funcexecution("--size", "c:/test.txt");
            expectedsize = " File Version: 137102";
            Assert.AreEqual<string>(expectedsize, actualsize, "Validating size values with --size");


        }
    }
}
