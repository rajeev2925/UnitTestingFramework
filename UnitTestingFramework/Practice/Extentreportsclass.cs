using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SAIPCsharp.Geniric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UnitTestingFramework.Practice
{
    public class Extentreportsclass 
    {
       
        public  static String path = "C:\\Users\\admin\\source\\repos\\UnitTestingFramework\\UnitTestingFramework\\reports\\";

        public static ExtentReports extentReports = new ExtentReports();
        public ExtentTest extentTest = extentReports.CreateTest("cname");
        // public ExtentTest extentTest = extentReports.CreateTest(MethodBase.GetCurrentMethod().Name);
        public ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(path);
        public void extentreportmethod(IWebDriver driver)
        {  
            if(extentTest.Status==Status.Fail)
            {
  
                ITakesScreenshot takesScreenshot = (ITakesScreenshot) driver;
                var screenShot = takesScreenshot.GetScreenshot();
                string screenShotPath = "C:\\Users\\admin\\source\\repos\\UnitTestingFramework\\UnitTestingFramework\\Snapshots\\defect.png";
                screenShot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);
                extentTest.Log(Status.Info, "Taken screenshot");
                bool condition = false;
                if (condition == true)
                {
                    Assert.IsTrue(true);
                    extentTest.Pass("Test Passed");
                }
                else
                {
                    try
                    {
                        Assert.IsTrue(false);

                    }
                    catch (Exception ex)
                    {
                        extentTest.Fail("Test failed");

                    }
                }
                extentTest.AddScreenCaptureFromPath(screenShotPath);
            }
            else if (extentTest.Status==Status.Pass)
            {
                extentTest.Pass("passed");
            }
            else if (extentTest.Status == Status.Skip)
            {
                extentTest.Log(Status.Info, "skipped");
            }
        }
            
    }
}
