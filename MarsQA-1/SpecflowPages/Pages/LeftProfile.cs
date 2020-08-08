using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    internal class LeftProfile
    {
        

        public static IWebDriver driver { get; set; }
        private static IWebElement Hours => Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[3]/div/span/i"));
        private static IWebElement cancelHours => Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[3]/div/span/i"));

        private static IWebElement earnTarget => Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[4]/div/span/i"));
        private static IWebElement earnTargetdd => Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[4]/div/span/select"));
        private static IWebElement cancelearntarget => Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[4]/div/span/i"));
        private static IWebElement Availability => Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[2]/div/span/i"));

        internal void ValidateAvailability()
        {
            Driver.TurnOnWait();
            var Availabilitymsg = Driver.driver.FindElement(By.CssSelector("div.ns-box-inner")).Text;
            Console.WriteLine(Availabilitymsg);
            Assert.AreEqual("Availability updated", Availabilitymsg);
        }

        internal void SelectHours()
        {
            Hours.Click();
            SelectElement hours = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[3]/div/span/select")));
            hours.SelectByText("As needed");
            Thread.Sleep(500);
        }

        internal void SelectAvailability()
        {
            Availability.Click();
            SelectElement availability = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[2]/div/span/select")));
            availability.SelectByText("Full Time");
            Thread.Sleep(500);
        }

        internal void EarnTarget()
        {
            earnTarget.Click();
            SelectElement et = new SelectElement(earnTargetdd);
            et.SelectByText("Between $500 and $1000 per month");
            Console.WriteLine("Earn Target Selected");
            Thread.Sleep(500);
        }

        
    

    }
}