using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using SauceDemoAutomation.Hooks;
using SauceDemoAutomation.TestData;
using SauceDemoAutomation.TestUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SauceDemoAutomation.Pages
{
    public class LoginPage : SauceDemoAutomationExtentReport
    {
        static IWebElement txt_UserName => driver.FindElement(By.Id("user-name"));
        static IWebElement txt_Password => driver.FindElement(By.Id("password"));
        static IWebElement btn_Submit => driver.FindElement(By.XPath("//input[@type='submit']"));
        static IWebElement loginPageLogo => driver.FindElement(By.XPath("//div[@class='bot_column']"));
        static IWebElement productlogo => driver.FindElement(By.XPath("//div[text()='Products']"));

        /*public bool WaitTillLoginPageLoad()
        {
            if (WaitForObject(loginPageLogo, 10))
                return true;
            else
                return false;
        }*/

        public void Login(string userName, string password)
        {
            //ExtentTest test = null;
            try
            {
                //Start Report
                test = extent.CreateTest("Login Report");//"Login Report" method name
                //Log 'info'
                test.Log(Status.Info,"Login Report Info");
                //Pass Scenario
                txt_UserName.SendKeys(userName);
                txt_Password.SendKeys(password);
                btn_Submit.Click();
                Thread.Sleep(5000);

                Assert.Multiple(() =>
                {
                /*Assert.IsTrue(true);
                test.Log(Status.Pass, "Login Test Passed");

                Assert.IsTrue(false);
                test.Log(Status.Fail, "Login Test Failed");*/

                Assert.That(productlogo.Text,Is.Not.Null);
                test.Log(Status.Pass, "Login Test Passed");
                });

                Assert.Multiple(() =>
                {
                    Assert.That(productlogo.Text, Is.Null);
                    test.Log(Status.Fail, "Login Test Failed");

                    string screenshotPath = new SauceDemoAutomationScreenshot().Capture("FailScreenshot");
                });
                //return new HomePage();
            }
            catch (Exception)
            {
                /*if (e.InnerException == null)
                {
                    string err = e.InnerException.Message;
                    throw e;
                }*/

                throw;
            }
            //return new HomePage();

        }




        /*public HomePage Login(string userName, string password)
        {
            //ExtentTest test = null;
               //Start Report
                test = extent.CreateTest("Login Report");//"Login Report" method name
                //Log 'info'
                test.Log(Status.Info,"Login Report Info");
                //Pass Scenario
                txt_UserName.SendKeys(userName);
                txt_Password.SendKeys(password);
                btn_Submit.Click();
                Thread.Sleep(5000);

                Assert.Multiple(() =>
                {
                Assert.IsTrue(true);
                test.Log(Status.Pass, "Login Test Passed");

                Assert.IsTrue(false);
                test.Log(Status.Fail, "Login Test Failed");

                Assert.That(productlogo.Text,Is.Not.Null);
                test.Log(Status.Pass, "Login Test Passed");
                });

                Assert.Multiple(() =>
                {
                    Assert.That(productlogo.Text, Is.Null);
                    test.Log(Status.Fail, "Login Test Failed");

                    string screenshotPath = new SauceDemoAutomationScreenshot().Capture("FailScreenshot");
                });

                return new HomePage();
            }*/
            
            
        }
    }
