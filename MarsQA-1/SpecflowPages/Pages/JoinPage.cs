using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    internal class JoinPage
    {
        public static IWebDriver driver { get; set; }

        private static IWebElement Joinbtn => Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/button"));
        private static IWebElement firstName => Driver.driver.FindElement(By.XPath("//input[@name='firstName']"));
        private static IWebElement lastName => Driver.driver.FindElement(By.XPath("//input[@name='lastName']"));
        private static IWebElement email => Driver.driver.FindElement(By.XPath("//input[@name='email']"));
        private static IWebElement password => Driver.driver.FindElement(By.XPath("//input[@name='password']"));
        private static IWebElement confirmpassword => Driver.driver.FindElement(By.XPath("//input[@name='confirmPassword']"));
        private static IWebElement checkbox => Driver.driver.FindElement(By.XPath("//input[@name='terms']"));
        private static IWebElement Join => Driver.driver.FindElement(By.XPath("//div[@id='submit-btn']"));
        internal void join()
        {
            Driver.NavigateUrl();
            Driver.TurnOnWait();
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//A[@class='item'][text()='Sign In']")));
            Joinbtn.Click();
            ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Join");
            firstName.SendKeys(ExcelLibHelper.ReadData(2, "First"));
            lastName.SendKeys(ExcelLibHelper.ReadData(2, "Last"));
            email.SendKeys(ExcelLibHelper.ReadData(2, "email"));
            password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            confirmpassword.SendKeys(ExcelLibHelper.ReadData(2, "confirm"));
            checkbox.Click();
            Join.Click();
        }

        internal void ValidateJoin()
        {
            Driver.TurnOnWait();
            var Validationmsg = Driver.driver.FindElement(By.CssSelector("div.ns-box-inner")).Text;
            Console.WriteLine(Validationmsg);
            Assert.AreEqual(Validationmsg, "Registration successful");
        }
    }
}