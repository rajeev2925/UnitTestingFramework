using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SAIPCsharp.ObjectRepo
{
    
    public class LoginPage
    {
        IWebDriver driver;
        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement mailid;

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "//input[@value='Log in']")]
        private IWebElement Login_btn;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Login(String un, String psw)
        {
            mailid.SendKeys(un);
            password.SendKeys(psw);
            Login_btn.Click();
            String actprofile = driver.FindElement(By.XPath("//a[.='" + un + "']")).Text;
            try 
            { 
            Assert.IsTrue(actprofile.Contains(un)); 
            }
            catch (Exception ex) 
            {
                try
                {
                string log =driver.FindElement(By.XPath("//a[.='Log out']")).Text;
                    Assert.IsTrue(log.Contains("Log out"));
                    Console.WriteLine("login successfull but title mismatch");
                }
                catch
                {
                    System.Console.WriteLine("invalid page is displayed");
                }
            }

        }
    }
}
