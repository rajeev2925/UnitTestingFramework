using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using UnitTestingFramework.Practice;

namespace SAIPCsharp.Geniric
{
    [TestClass]
    [TestCategory("BaseClass")]
    public class BaseClass 
    {
       public static Extentreportsclass ec=new Extentreportsclass();
     public static IWebDriver driver;
        public string screenShotPath;
        public Excellutility exUtil;
        public Webdriverutilities wUtil;

        [AssemblyInitialize]
       public static void AssemblyInitialize(TestContext testContext)
        {
            Extentreportsclass.extentReports.AttachReporter(ec.htmlReporter);
            ec.htmlReporter.Start();
            Extentreportsclass.extentTest.Log(Status.Info, "assemply intialized");
        }
       
       [TestInitialize] 
        public void Init()
        {
            
            exUtil = new Excellutility();
            wUtil = new Webdriverutilities();
            driver  = new ChromeDriver();
            wUtil.maximizewindow(driver);
            driver.Url = exUtil.Get_value_by_pasing_key("Wbook", "url");
         
        }
        [TestCleanup]
        public void Cleanup()
        {
          //  ec.extentreportmethod();
            Extentreportsclass.extentTest.AddScreenCaptureFromPath(screenShotPath);
            ec.extentreportmethod(null);
            driver.Quit();
            driver.Dispose(); 
        }

       [AssemblyCleanup]   
        public static void assemplycleanip()
        {

            Extentreportsclass.extentReports.Flush();
            ec.htmlReporter.Stop();
        }
    
    }
}
