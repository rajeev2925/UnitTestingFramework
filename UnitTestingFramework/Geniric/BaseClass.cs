using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
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
    public class BaseClass : Extentreportsclass
    {
     public IWebDriver driver;

        public Excellutility exUtil;
        public Webdriverutilities wUtil;
/*
        [AssemblyInitialize]
       public void AssemblyInitialize(TestContext testContext)
        {
        

           
        
        }*/


       [TestInitialize] 
        public void Init() 
        {
            //html report start before every method
            extentReports.AttachReporter(htmlReporter);
            htmlReporter.Start();
            exUtil = new Excellutility();
            wUtil = new Webdriverutilities();
            driver  = new ChromeDriver();
            wUtil.maximizewindow(driver);
            driver.Url = exUtil.Get_value_by_pasing_key("Wbook", "url");
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
            driver.Dispose();
            extentReports.Flush();
            htmlReporter.Stop();
        }

     /*   [AssemblyCleanup]
         
        public void assemplycleanip()
        {
           
        }
     */
    }
}
