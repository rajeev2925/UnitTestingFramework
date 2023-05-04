using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIPCsharp.Geniric
{
    public class Webdriverutilities
    {
        public void maximizewindow(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }
        public void wait_for_page_load(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
        }
    }
}
