using AventStack.ExtentReports;
using NUnit.Framework;
using SauceDemoAutomation.Hooks;
using SauceDemoAutomation.Pages;
using SauceDemoAutomation.TestData;
using SauceDemoAutomation.TestUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoAutomation.Tests
{
    public class LoginTest : Hooks1
    {
        ReadXMLFile_LoginData read = new ReadXMLFile_LoginData();

        [Test]
        public void LoginToSauceDemo()
        {
            //ReadXMLFile_LoginData read = new ReadXMLFile_LoginData();
            //new LoginPage().Login(username, password);
            read.readLoginData();
        }
    }
}
