using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;


namespace MarsQA_1.SpecflowPages.Pages
{
    internal class ManageListing
    {
        
        private static IWebElement ManageListingtab => Driver.driver.FindElement(By.XPath("//a[@href = '/Home/ListingManagement']"));

        internal void DeleteManageListing()
        {
            
            ManageListingtab.Click();
            Driver.TurnOnWait();
            for (int i = 1; i <= 10; i++)
            {
                var titletext = Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[ " + i + "]/td[3]"));
                //Console.WriteLine(all.Text);
                ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\\Mars.xlsx", "ManageListing");
                if (titletext.Text == (ExcelLibHelper.ReadData(2, "Title")))
                //(GlobalDefinitions.ExcelLib.ReadData(2, "Title")))
                {
                    IWebElement deleteSkill = Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[8]/div/button[3]"));
                    deleteSkill.Click();

                    //Select no from the two options
                    //IWebElement noOption = GlobalDefinitions.driver.FindElement(By.CssSelector("button.ui.negative.button"));
                    //noOption.Click();

                    //Select yes from the two options
                    IWebElement yesOption = Driver.driver.FindElement(By.CssSelector("button.ui.icon.positive.right.labeled.button"));
                    yesOption.Click();
                    Console.WriteLine("Record deleted");
                    return;
                }
            }

        }

        internal void ValidateDeleteManageListing()
        {
            Driver.TurnOnWait();
            var deletemsg = Driver.driver.FindElement(By.CssSelector("div.ns-box-inner")).Text;
            Console.WriteLine(deletemsg);
            Assert.AreEqual(deletemsg, "Selenium has been deleted");
           
        }

        internal void ViewManageListing()
        {
            Driver.waitClickableElement(Driver.driver, "XPath", "//section[@class = 'nav-secondary']/div/a[3]");
            ManageListingtab.Click();
            Driver.TurnOnWait();
            IWebElement ViewSkill = Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[1]"));
            ViewSkill.Click();

        }

        internal void ValidateViewManageListing()
        {
            Driver.TurnOnWait();
            var title = Driver.driver.Title;
            Console.WriteLine(title);
            Assert.AreEqual(title, "Service Detail");
        }

        internal void EditManageListing()
        {
            Driver.waitClickableElement(Driver.driver, "XPath", "//section[@class = 'nav-secondary']/div/a[3]");
            ManageListingtab.Click();
            Driver.TurnOnWait();
            IWebElement EditSkill = Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[2]"));
            EditSkill.Click();

        }

        internal void ValidateEditSkill()
        {
            Driver.TurnOnWait();
            var title = Driver.driver.Title;
            Console.WriteLine(title);
            Assert.AreEqual(title, "ServiceListing");
        }
    }
}