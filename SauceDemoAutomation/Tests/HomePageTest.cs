using NUnit.Framework;
using SauceDemoAutomation.Hooks;
using SauceDemoAutomation.Pages;
using SauceDemoAutomation.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoAutomation.Tests
{
    class HomePageTest : Hooks1
    {
        LoginPage loginPage = new LoginPage();
        ReadXMLFile_LoginData loginData = new ReadXMLFile_LoginData();
        HomePage homePage = new HomePage();

        [Test]
        public void OpenHomePage()
        {
            //Assert.True(loginPage.Login().WaitTillHomePageLoad(), "Home Page is not loaded.");
            loginData.readLoginData();
            Assert.True(homePage.WaitTillHomePageLoad(), "Home Page is not loaded.");
            homePage.HomePageWebElements();
        }
    }
}
