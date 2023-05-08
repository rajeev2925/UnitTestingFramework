using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SAIPCsharp.Geniric;
using Microsoft.CodeAnalysis.Text;
using OpenQA.Selenium;

namespace UnitTestingFramework.Practice
{
    public class reportsextent
    {
       /* public static TestContext testContext;

        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }
*/

      public static String rpath = "C:\\Users\\admin\\source\\repos\\UnitTestingFramework\\UnitTestingFramework\\reports\\";

        public static ExtentReports extentReports = new ExtentReports();
        public ExtentTest extentTest = extentReports.CreateTest("CCare");
        public static ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(rpath);
        
        public void reportstart()
        {
           
            extentReports.AttachReporter(htmlReporter);
            htmlReporter.Start();
        }
        public void extentreportmethod(IWebDriver driver)
        {
            if (extentTest.Status == Status.Fail)
            {

               // ITakesScreenshot takesScreenshot = (ITakesScreenshot) driver;
               // var screenShot = takesScreenshot.GetScreenshot();
               // string screenShotPath = "C:\\Users\\admin\\source\\repos\\UnitTestingFramework\\UnitTestingFramework\\Snapshots\\defect.png";
               // screenShot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);
                extentTest.Log(Status.Fail, "Taken screenshot");
                extentTest.Log(Status.Fail, "failed");
            }
            else if (extentTest.Status == Status.Pass)
            {
                extentTest.Log(Status.Pass, "method is passed");
            }
            else if (extentTest.Status == Status.Skip)
            {
                extentTest.Log(Status.Info, "method isskipped");
            }
        }
        public void reportend()
        {
            extentReports.Flush();
            htmlReporter.Stop();
        }

    }
}
