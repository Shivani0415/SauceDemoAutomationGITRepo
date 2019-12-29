using NUnit.Framework;
using SauceDemoAutomation.Pages;
using SauceDemoAutomation.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SauceDemoAutomation.TestData;
//using SauceDemoAutomation.TestData;

namespace SauceDemoAutomation.Tests
{
    public class CartTest: Hooks1
    {
        //LoginPage loginpage = new LoginPage();
        ReadXMLFile_LoginData loginData = new ReadXMLFile_LoginData();
        HomePage homepage = new HomePage();
        CartPage cartpage = new CartPage();
        ReadXMLFile_CheckOutStepOne checkoutstepone = new ReadXMLFile_CheckOutStepOne();
        ///checkOutStepOne stepOne = new checkOutStepOne();
        checkOutStepTwoPage stepTwo = new checkOutStepTwoPage();

        [Test]
        public void proceedToCart()
        {
            //Assert.True(loginpage.Login().WaitTillHomePageLoad(), "Home Page is not loaded.");
            loginData.readLoginData();
            Assert.True(homepage.WaitTillHomePageLoad(), "Home Page is not loaded.");
            Assert.True(homepage.HomePageWebElements().WaitTillCartpageLoad(), "Cart Page is not loaded.");
            //cartpage.CheckOut();
            Assert.True(cartpage.CheckOut().WaitTillcheckOutStepOnePageLoad(), "CheckOut Step One Page is not loaded");
            checkoutstepone.readStepOneData();
            Assert.True(stepTwo.WaitTillCheckOutStepTwoPageLoad(), "CheckOut Step Two  is not loaded");
            Assert.True(stepTwo.clickOnFinishBtn().WaitTillCheckOutCompletePageLoad(), "CheckOut Complete Page is not loaded");

        }
    }
}
