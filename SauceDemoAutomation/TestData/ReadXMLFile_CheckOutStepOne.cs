using SauceDemoAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SauceDemoAutomation.TestData
{
    public class ReadXMLFile_CheckOutStepOne
    {
        string firstName;
        string lastName;
        string postalCode;

        public void readStepOneData()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("C:\\Users\\shivani\\source\\repos\\SauceDemoAutomation\\SauceDemoAutomation\\TestData\\CheckOutStepOne.xml");

            XmlTextReader xtr = new XmlTextReader("C:\\Users\\shivani\\source\\repos\\SauceDemoAutomation\\SauceDemoAutomation\\TestData\\CheckOutStepOne.xml");

            while (xtr.Read())
            {
                if(xtr.NodeType == XmlNodeType.Element && xtr.Name == "FirstName")
                {
                    firstName = xtr.ReadElementString();
                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "LastName")
                {
                    lastName = xtr.ReadElementString();
                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "PostalCode")
                {
                    postalCode = xtr.ReadElementString();
                }
            }
            new checkOutStepOne().checkOutYourInformation(firstName, lastName, postalCode);
        }
    }
}
