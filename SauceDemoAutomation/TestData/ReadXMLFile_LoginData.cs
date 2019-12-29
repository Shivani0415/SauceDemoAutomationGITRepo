using NUnit.Framework;
using SauceDemoAutomation.Hooks;
using SauceDemoAutomation.Pages;
using SauceDemoAutomation.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SauceDemoAutomation.TestData
{
    public class ReadXMLFile_LoginData
    {
        string username="";
        string password="";
        LoginPage login = new LoginPage();
        //static void Main(string[] args) {

            public void readLoginData()
            {
            XmlDocument Xdoc = new XmlDocument();
            Xdoc.Load("C:\\Users\\shivani\\source\\repos\\SauceDemoAutomation\\SauceDemoAutomation\\TestData\\LoginData.xml");    

            XmlTextReader xtr = new XmlTextReader("C:\\Users\\shivani\\source\\repos\\SauceDemoAutomation\\SauceDemoAutomation\\TestData\\LoginData.xml");

            while (xtr.Read())
            {
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "UserName")
                {
                    username = xtr.ReadElementString();
                    //Console.WriteLine("UserName ="+s1);
                    //System.Diagnostics.Debug.WriteLine("UserName =" + username);
                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Password")
                {
                    password = xtr.ReadElementString();
                    //Console.WriteLine("UserName ="+s1);
                    //System.Diagnostics.Debug.WriteLine("UserName =" + password);
                }
            }
            //new LoginTest().LoginToSauceDemo(username,password);
            login.Login(username, password);
        }
        /* [TestMethod]
         [DeploymentItem("C:\\Users\\shivani\\source\\repos\\SauceDemoAutomation\\SauceDemoAutomation\\TestData\\LoginData.xml")]
         [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                    "C:\\Users\\shivani\\source\\repos\\SauceDemoAutomation\\SauceDemoAutomation\\TestData\\LoginData.xml",
                    "Test1",
                     DataAccessMethod.Sequential)]
         public void ReadLogin()
         {
             //int a1 = Int32.Parse((string)TestContext.DataRow["A1"]);
             string username = TestContext.Equals()
             //int a2 = Int32.Parse((string)TestContext.DataRow["A2"]);
             //int result = Int32.Parse((string)TestContext.DataRow["Result"]);
             //ExecSumTest(a1, a2, result);
         }

        private static void ExecSumTest(int a1, int a2, int result)
         {
             Assert.AreEqual(a1 + a2, result);
         }*/
    }
}