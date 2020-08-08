using MarsQA_1.Helpers;
using NUnit.Framework;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System;
using static MarsQA_1.Helpers.CommonMethods;
using AventStack.ExtentReports;
using TechTalk.SpecFlow;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {
       
       
        [BeforeScenario]
        public void Setup()
        {

            //launch the browser
            Initialize();
            //ExcelLibHelper.PopulateInCollection(@"C:\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");
            //call the SignIn class
            //SignIn.SigninStep();
        }




        [AfterScenario]
        public void TearDown()
        {
            //Screenshot 
            SaveScreenShotClass save = new SaveScreenShotClass();
            
            string img = save.SaveScreenshot(driver, "this");

            // Screenshot
            //string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            //test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            //Close the browser
            //Close();

            // end test. (Reports)
            //CommonMethods.Extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            //CommonMethods.Extent.Flush();
        }
    }
}
