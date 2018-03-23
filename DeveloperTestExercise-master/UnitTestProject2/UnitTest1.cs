using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVersion()
        {
            ///Verifying -v version value
            String actualversion = null;
            string[] strArr = { "-v", "--v", "/v","--version" ,"t"};
            clsFuncExecution objclsFuncExecution = new clsFuncExecution();
            for (int i = 0; i < strArr.Length; i++)
            {
                actualversion = objclsFuncExecution.funcexecution(strArr[i], "c:/test.txt");
                if (actualversion.Contains("."))
                {
                    Console.Write("Test Scenario Pass");
                }
                else
                {
                    Console.Write("Test Scenario fail");
                }

            }

        }
        [TestMethod]
        public void TestSize()
        {
            string actualsize = null;
            string[] strArr = { "-s", "--s", "/s", "--size" };
            clsFuncExecution objclsFuncExecution = new clsFuncExecution();
            for (int i = 0; i < strArr.Length; i++)
            {
                actualsize = objclsFuncExecution.funcexecution(strArr[i], "c:/test.txt");
                if (actualsize.Length < 18)
                {
                    Console.Write("Test Scenario Pass");
                }
                else
                {
                    Console.Write("Test Scenario fail");
                }

            }
        }
    }
}
