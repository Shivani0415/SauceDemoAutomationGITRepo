using OpenQA.Selenium;
using SauceDemoAutomation.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoAutomation.Pages
{
    public class CartPage : Hooks1
    {
        static IWebElement yourCart => driver.FindElement(By.XPath("//div[text()='Your Cart']"));
        static IWebElement checkOut => driver.FindElement(By.LinkText("CHECKOUT"));

        public bool WaitTillCartpageLoad()
        {
            if (WaitForObject(yourCart, 10))
                return true;
            else
                return false;
        }

        public checkOutStepOne CheckOut()
        {
            checkOut.Click();
            return new checkOutStepOne();
        }

    }
}
