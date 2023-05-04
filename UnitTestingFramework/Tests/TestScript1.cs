using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SAIPCsharp.ObjectRepo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAIPCsharp.Tests
{
    [TestClass]
    [TestCategory("scripts")]
    public class TestScript1 : Geniric.BaseClass
    {
        
        [TestMethod]
        [TestCategory("Regression")]
        public void Script1()
        {
           String un=exUtil.Get_value_by_pasing_key("Wbook", "username");
            String psw = exUtil.Get_value_by_pasing_key("Wbook", "password");
            MessageBox.Show(un+" "+psw);
            LoginPage lp=new LoginPage(driver);
            lp.Login(un,psw);

        }
    }
}
