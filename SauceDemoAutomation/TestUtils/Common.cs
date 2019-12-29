using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SauceDemoAutomation.TestUtils
{
    public class Common
    {
        //Login Credentials
        //public readonly String userName = "performance_glitch_user";
        //public readonly String password = "secret_sauce";

        //WebDriver instance
        public static IWebDriver driver;

        //checkOutStepOne
        //public readonly String FirstName = "performance";
        //public readonly String LastName = "glitch";
        //public readonly String PostalCode = "411014";

        //
        public bool WaitForObject(IWebElement element, int timeOut = 30) {
            for (int i = 0; i < timeOut; i++)
            {
                try
                {
                    if (element.Displayed)
                    {
                        return true;
                    }
                }
                catch (Exception)
                {
                    Thread.Sleep(1000);
                }
            }
            return false;
        }
    }
}
