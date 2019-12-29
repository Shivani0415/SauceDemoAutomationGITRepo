using NUnit.Framework;
using NUnit.Framework.Interfaces;
//using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoAutomation.TestUtils
{
    /*[TestFixture]
    public class AutomationExtentReports
    {
        public ExtentReports extent;//using ExtentReport class is used to generate your HTML report
        public ExtentTest test;//using ExtentTest class we generate the log information into the report like pass, fail, skip etc.

        [OneTimeSetUp]//This is onetimsetup for your entire class means it will be executed only once.
        public void StartReport()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            string reportPath = projectPath + "Reports\\SauceDemoAutomationReport.html";//path of your project where your report file would be stored.
            extent = new TestReports(reportPath, true);//replacing the existing report with the new report

            extent
            .AddSystemInfo("Host Name", "Shivani")
            .AddSystemInfo("Environment", "QA")
            .AddSystemInfo("User Name", "Shivani Sharma");
            extent.LoadConfig(projectPath + "extent-config.xml");//xml file name where extent report configuration is given.
        }

        [Test]//Now we are writing code for pass or fail the test cases.
        public void DemoReportPass(string passMessage)
        {
            test = extent.StartTest(passMessage);
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        }

        [Test]
        public void DemoReportFail(string failMessage)
        {
            test = extent.StartTest(failMessage);
            Assert.IsTrue(false);
            test.Log(LogStatus.Pass, "Assert Fail as condition is False");
        }

        [TearDown]//block will be executed for each and every test method in this class after executing of the test
        public void GetResult()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == TestStatus.Failed)
            {
                test.Log(LogStatus.Fail, stackTrace + errorMessage);
            }
            extent.EndTest(test);
        }

        [OneTimeTearDown]//it will execute only once on this class. 
        public void EndReport()
        {
            extent.Flush();
            extent.Close();
        }
    }*/
}