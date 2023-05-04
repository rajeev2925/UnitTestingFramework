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
        
        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement mailid;

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "//input[@value='Log in']")]
        private IWebElement Login_btn;

        public LoginPage(IWebDriver driver)
        {
        
            PageFactory.InitElements(driver, this);
        }

        public void Login(String un,String psw)
        {
            mailid.SendKeys(un);
            password.SendKeys(psw); 
            Login_btn.Click();

        }
    }
}
