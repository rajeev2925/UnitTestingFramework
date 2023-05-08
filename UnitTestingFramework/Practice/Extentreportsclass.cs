using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public static ExtentTest extentTest = extentReports.CreateTest(MethodBase.GetCurrentMethod().Name);
        public ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(path);
        public void extentreportmethod(string url)
        {  
            if(extentTest.Status==Status.Fail)
            {
                extentTest.Log(Status.Fail,"this data is failed");
                extentTest.Info("URL Is : " +url);    
              
            }
            else if (extentTest.Status==Status.Pass)
            {
                extentTest.Log(Status.Pass, " data is passed");
                extentTest.Info("URL Is : " + url);
            }
            else if (extentTest.Status == Status.Skip)
            {
                extentTest.Log(Status.Info, "skipped");
            }
        }
            
    }
}
