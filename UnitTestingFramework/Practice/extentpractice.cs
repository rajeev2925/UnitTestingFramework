using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace UnitTestingFramework.Practice
{
    [TestClass]
    
    internal class extentpractice
    {
        public IWebDriver driver;
        public static ExtentReports extentReports;
        public string screenShotPath;
        public ExtentTest extentTest;
        public static ExtentHtmlReporter htmlReporter;
        public static string testResultPath = "C:\\Users\\admin\\source\\repos\\UnitTestingFramework\\UnitTestingFramework\\reports\\";
        

        [TestInitialize]
        public void TestInitialize(TestContext testContext)
        {
            driver = new ChromeDriver();
            extentReports = new ExtentReports();
            htmlReporter = new ExtentHtmlReporter(testResultPath);
            htmlReporter.Start();
            extentReports.AttachReporter(htmlReporter);
          //  Console.WriteLine("Assembly Initialized");
            
        }
        
        [TestMethod]
        [TestCategory("extent")]  
        public void ActiTime()
        {
            extentTest = extentReports.CreateTest("ActiTime");

            driver.Url = "http://localhost:8888/";

            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            var screenShot = takesScreenshot.GetScreenshot();
            screenShotPath = "C:\\Users\\admin\\source\\repos\\UnitTestingFramework\\UnitTestingFramework\\Snapshots\\defect.png";
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

        }
        [TestCleanup]
        public void Cleanup()
        {
            driver.Close();
            driver.Dispose();
            extentReports.Flush();
            htmlReporter.Stop();
            extentTest.AddScreenCaptureFromPath(screenShotPath);
        }

    }
}

