using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using SAIPCsharp.Geniric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingFramework.Practice
{
    public class Extentreportsclass
    {
       public static String path = "C:\\Users\\admin\\source\\repos\\UnitTestingFramework\\UnitTestingFramework\\reports\\";
       public  ExtentTest extentTest;
       public  ExtentReports extentReports = new ExtentReports();
       public  ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(path);
        public void extentreportmethod()
        {
            extentTest = extentReports.CreateTest(MethodBase.GetCurrentMethod().Name);
            string mname=MethodBase.GetCurrentMethod().Name;

         if (extentTest.Status.Equals("Fail"))
            {
                extentTest.Info(mname+"is failed");
            }
         else if(extentTest.Status.Equals("Skip"))
            {
                extentTest.Info(mname + "is Skipped");
            }
         else if(extentTest.Status.Equals("Pass"))
            {
                extentTest.Info(mname + "is passed");
            }

        }
    }
}
