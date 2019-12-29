using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SauceDemoAutomation.Pages;
using SauceDemoAutomation.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SauceDemoAutomation.Pages
{
    public class HomePage : Hooks1
    {
        static IWebElement slct_SortContainer => driver.FindElement(By.CssSelector("select.product_sort_container"));
        static IWebElement element => driver.FindElement(By.XPath("//div[text()='Sauce Labs Fleece Jacket']"));
        static IWebElement addToCart => driver.FindElement(By.XPath("//descendant::div[text()='Sauce Labs Fleece Jacket']/ancestor::*[@class='inventory_item']/descendant::button[text()='ADD TO CART']"));
        static IWebElement inventory_comparison => driver.FindElement(By.XPath("//descendant::div[text()='Sauce Labs Fleece Jacket']/ancestor::*[@class='inventory_item']/descendant::button[text()='REMOVE']"));
        static IWebElement addToCartNumber => driver.FindElement(By.XPath("//span[@class='fa-layers-counter shopping_cart_badge']"));
        
        IJavaScriptExecutor js = driver as IJavaScriptExecutor;

        public bool WaitTillHomePageLoad() {
            if (WaitForObject(slct_SortContainer,15))
                return true;
            else
                return false;
        }
        public CartPage HomePageWebElements()
        {
            SelectElement select = new SelectElement(slct_SortContainer);
            select.SelectByText("Price (low to high)");
            Thread.Sleep(2000);
            try
            {
                //js.ExecuteScript("window.scrollBy(0,500);");
                js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            }
            catch (Exception)
            {
                addToCart.Click();
                Thread.Sleep(5000);
            }
            Assert.AreEqual("REMOVE", inventory_comparison.Text);
            Assert.AreEqual("1", addToCartNumber.Text);
            addToCartNumber.Click();
            return new CartPage();
        }
    }
}
