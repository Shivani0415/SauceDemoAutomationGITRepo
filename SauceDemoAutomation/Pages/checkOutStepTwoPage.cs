using OpenQA.Selenium;
using SauceDemoAutomation.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoAutomation.Pages
{
    public class checkOutStepTwoPage: Hooks1
    {
        static IWebElement checkOutOverview => driver.FindElement(By.XPath("//div[text()='Checkout: Overview']"));
        static IWebElement finish => driver.FindElement(By.LinkText("FINISH"));

        public bool WaitTillCheckOutStepTwoPageLoad()
        {
            if (WaitForObject(checkOutOverview, 10))
                return true;
            else
                return false;
        }

        public checkOutCompletePage clickOnFinishBtn()
        {
            finish.Click();
            return new checkOutCompletePage();
        }

    }
}
