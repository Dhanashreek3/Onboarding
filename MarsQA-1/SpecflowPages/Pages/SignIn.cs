using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace MarsQA_1.Pages
{
    public class SignIn
    {
        public static IWebDriver driver { get; set; }
        private static IWebElement SignInBtn =>  Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("//INPUT[@type='password']"));
        private static IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
        public void SigninStep()
        {
           
            Driver.NavigateUrl();
            Thread.Sleep(3000);
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//A[@class='item'][text()='Sign In']")));
            SignInBtn.Click();
            ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");
            Email.SendKeys(ExcelLibHelper.ReadData(2,"username"));
            Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            LoginBtn.Click();
        }
        public static void Login()
        {
            Driver.NavigateUrl();

            //Enter Url
            Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();

            //Enter Username
            Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("");

            //Enter password
            Driver.driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("");

            //Click on Login Button
            Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();

        }
    }
}