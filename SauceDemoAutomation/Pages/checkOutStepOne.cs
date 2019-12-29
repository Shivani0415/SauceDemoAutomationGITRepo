using OpenQA.Selenium;
using SauceDemoAutomation.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SauceDemoAutomation.Pages;

namespace SauceDemoAutomation.Pages
{
    public class checkOutStepOne: Hooks1
    {
        static IWebElement yourInformation => driver.FindElement(By.XPath("//div[text()='Checkout: Your Information']"));
        static IWebElement firstName => driver.FindElement(By.Id("first-name"));
        static IWebElement lastName => driver.FindElement(By.Id("last-name"));
        static IWebElement postalCode => driver.FindElement(By.Id("postal-code"));
        static IWebElement continuePage => driver.FindElement(By.XPath("//input[@value='CONTINUE']")); 

        public bool WaitTillcheckOutStepOnePageLoad()
        {
            if (WaitForObject(yourInformation, 10))
                return true;
            else
                return false;
        }
        public checkOutStepTwoPage checkOutYourInformation(string FirstName, string LastName, string PostalCode)
        {
            firstName.SendKeys(FirstName);
            lastName.SendKeys(LastName);
            postalCode.SendKeys(PostalCode);
            continuePage.Click();
            return new checkOutStepTwoPage();
        }
    }
}
