using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SAIPCsharp.Geniric
{
    [TestClass]
    [TestCategory("BaseClass")]
    public class BaseClass
    {
     public IWebDriver driver;

        public Excellutility exUtil;
        public Webdriverutilities wUtil;

       [TestInitialize] 
        public void Init() 
        {
          driver  = new ChromeDriver();
            exUtil = new Excellutility();
            wUtil = new Webdriverutilities();

            wUtil.maximizewindow(driver);
            
            driver.Url = exUtil.Get_value_by_pasing_key("Wbook", "url");
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
