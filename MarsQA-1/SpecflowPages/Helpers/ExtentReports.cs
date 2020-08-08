using AventStack.ExtentReports;
using NUnit.Framework;
using AventStack.ExtentReports.Reporter;
using TechTalk.SpecFlow;


namespace MarsQA_1.Helpers
{

    [TestFixture]
    public class ExtentReport
    {
        public static ExtentTest test;
        public static ExtentReports extent;
        public static ExtentHtmlReporter htmlReporter;

        
        public static ExtentReports getInstance()
        {
            if (extent == null)
            {
                
                var htmlReporter = new ExtentHtmlReporter(ConstantHelpers.ReportsPath);
                htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
                //htmlReporter.Configuration.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("HostName", "SkillSwap");
                extent.AddSystemInfo("Environment", "QA");
                extent.AddSystemInfo("Username", "Dhanashree");
                
                
            }
            return extent;

        }
        public static void afterTest()
        {
            //ExtentReports Extent = ExtentReport.getInstance();
            // test.Log(Status.Info, "test passed");

        }
        public static void EndReport()
        {

            extent.Flush();
        }

    }
}


