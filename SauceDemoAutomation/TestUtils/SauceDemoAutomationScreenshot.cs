using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SauceDemoAutomation.Hooks;

namespace SauceDemoAutomation.TestUtils
{
    public class SauceDemoAutomationScreenshot: Hooks1
    {
        public string Capture(string ScreenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot();
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string uptobinPath = path.Substring(0, path.LastIndexOf("bin")) + "TestScreenshots\\" + ScreenShotName + ".png";
            string localPath = new Uri(uptobinPath).LocalPath;
            screenshot.SaveAsFile(localPath,ScreenshotImageFormat.Png);
            return localPath;
        }
    }
}
