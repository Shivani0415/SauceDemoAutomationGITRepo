using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SauceDemoAutomation.TestUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SauceDemoAutomation.Hooks
{
    [TestFixture]
    public class Hooks1 : Common
    {
        [SetUp]
        public void MySetUp()
        {
            //DesiredCapabilities ds = new DesiredCapabilities();
            //ChromeOptions options = new ChromeOptions();
            //options.AddArguments("--disable-infobars");

            driver = new ChromeDriver();
            Thread.Sleep(5000);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Thread.Sleep(5000);
            Assert.AreEqual("https://www.saucedemo.com/", driver.Url);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
/*[SetUpFixture]TestFixture
public clas

    
    s MySetUpClass
{
    public static IWebDriver driver;
    [OneTimeSetUp]
    public static void OneTimeSetUp()
    {
        driver = new ChromeDriver();
    }
    [OneTimeTearDown]
   public static void OneTimeTearDown() => driver.Quit();
}*/
