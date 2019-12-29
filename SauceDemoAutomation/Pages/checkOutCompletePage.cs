using OpenQA.Selenium;
using SauceDemoAutomation.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoAutomation.Pages
{
    public class checkOutCompletePage: Hooks1
    {
        static IWebElement thankYourOrderText => driver.FindElement(By.XPath("//h2[text()='THANK YOU FOR YOUR ORDER']"));

        public bool WaitTillCheckOutCompletePageLoad()
        {
            if (WaitForObject(thankYourOrderText, 10))
                return true;
            else
                return false;
        }

    }

   
}
