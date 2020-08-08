using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;
using AventStack.ExtentReports;
using NUnit.Framework.Interfaces;
using static MarsQA_1.Helpers.CommonMethods;
using TechTalk.SpecFlow;

namespace MarsQA_1.Helpers
{
    public class Driver
    {
        //Initialize the browser
        public static IWebDriver driver { get; set; }

        public void Initialize()
        {
            //Defining the browser
            driver = new ChromeDriver();
            TurnOnWait();

            //Maximise the window
            driver.Manage().Window.Maximize();
            //TurnWaitOn();

            
           
            // wait.ForElements(By.XPath("//A[@class='item'][text()='Sign In']"), driver, TimeSpan.FromSeconds(20));
        }

        public static string BaseUrl
        {
            get { return ConstantHelpers.Url; }
        }


        //Implicit Wait
        public static void TurnOnWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        public static void TurnWaitOn()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

        }
        public static void waitClickableElement(IWebDriver driver, string locator, string locatorValue)
        {
            try
            {
                if (locator == "Id")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
                }
                if (locator == "XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
                }
                if (locator == "CSSSelector")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception at waitClickableElement", ex.Message);
            }

        }


        /*public static void WaitHelpers(By by, IWebDriver driver, TimeSpan timeSpan)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }*/

        public static void NavigateUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        //Close the browser

        public void Close()
        {
           // driver.Quit();
        }
        /*
        internal static void SigninStep()
        {
            throw new NotImplementedException();
        }
        */
        //paths for the reports

        #region To access Path from resource file

        
       
        public static string ScreenshotPath = ConstantHelpers.ScreenshotPath;
        public static string ReportsPath = ConstantHelpers.ReportsPath;
        #endregion

        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;

        #endregion


    }
}
