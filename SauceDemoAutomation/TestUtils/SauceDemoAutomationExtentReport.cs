using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SauceDemoAutomation.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoAutomation.TestUtils
{
    [TestFixture]
    public class SauceDemoAutomationExtentReport: Hooks1
    {
        /*ExtentReports extent=null;

        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\shivani\source\repos\SauceDemoAutomation\SauceDemoAutomation\TestReports\Report.html");
            extent.AttachReporter(htmlReporter);

            extent.AddSystemInfo("Host Name", "Local Host");
            extent.AddSystemInfo("Environment","QA");
            extent.AddSystemInfo("UserName","TestUser");
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }*/


        public static ExtentReports extent;
        public static ExtentTest test;
        public static ExtentHtmlReporter htmlreporter;

        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            htmlreporter = new ExtentHtmlReporter(@"C:\Users\shivani\source\repos\SauceDemoAutomation\SauceDemoAutomation\TestReports\Report.html");
            extent.AttachReporter(htmlreporter);

            extent.AddSystemInfo("HostName","LocalHost");
            extent.AddSystemInfo("Environment","QA");
            extent.AddSystemInfo("UserName","Shivani Sharma");

            //extent.LoadConfig(htmlreporter + "extent-config.xml");//xml file name where extent report configuration //is given.
        }

        [TearDown]
        public void AfterClass()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = ""+TestContext.CurrentContext.Result.StackTrace+"";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if(status == TestStatus.Failed)
            {
                test.Log(Status.Fail, status + errorMessage);
            }

            //extent.EndTest(test);
            driver.Quit();
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
            //extent.Close();
        }

        /* [Test]
        public void Test1()
        {
            //IWebDriver driver = null;
            
            try
            {
                test = extent.CreateTest("Test1").Info("Test Starterd");

                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                test.Log(Status.Info,"Chrome Browser Launched");

                driver.Url="https://www.facebook.com/";

                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
                emailTextField.SendKeys("Selenium c#");
                test.Log(Status.Info, "Email id Entered");
                driver.Quit();
                test.Log(Status.Pass,"Test1 Passed");
                
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
        }

        [Test]
        public void Test2()
        {
            IWebDriver driver = null;
            ExtentTest test = null;
            try
            {
                test = extent.CreateTest("Test2").Info("Test Starterd");

                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                test.Log(Status.Info, "Chrome Browser Launched");

                driver.Url = "https://www.facebook.com/";

                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='abcd']"));
                emailTextField.SendKeys("Selenium c#");
                test.Log(Status.Info, "Email id Entered");
                driver.Quit();
                test.Log(Status.Pass, "Test1 Passed");

            }
            catch (Exception e)
            {

                test.Log(Status.Fail, e.ToString());
                test.Fail("details", MediaEntityBuilder.CreateScreenCaptureFromPath("screenshot.jpg").Build());
                test.AddScreenCaptureFromPath("screenshot.jpg");
                /*Screenshot file = ((ITakesScreenshot)driver).GetScreenshot();
                string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
                string finalpath = path.Substring(0, path.LastIndexOf("bin"));
                file.SaveAsFile(finalpath+ "\\Screenshots\\" + SSName + ".png", ScreenshotImageFormat.Png);
                test.Log("Details", MediaEntityBuilder.CreateScreenCaptureFromPath("\\Screenshots\\" + SSName + ".png").Build());
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
        }*/
    }
}
