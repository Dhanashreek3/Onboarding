using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    internal class ShareSkill
    {
        public static IWebDriver driver { get; set; }
        private static IWebElement ShareSkillbtn => Driver.driver.FindElement(By.XPath("//a[@href = '/Home/ServiceListing']"));
        private static IWebElement title => Driver.driver.FindElement(By.XPath("//input[@name = 'title']"));
        private static IWebElement description => Driver.driver.FindElement(By.XPath("//textarea[@name = 'description']"));
        private static IWebElement Category => Driver.driver.FindElement(By.XPath("//select[@name = 'categoryId']"));
        private static IWebElement SubCategory => Driver.driver.FindElement(By.XPath("//select[@name = 'subcategoryId']"));
        private static IWebElement Tag => Driver.driver.FindElement(By.XPath("//input[@placeholder = 'Add new tag']"));
        private static IWebElement Hourly => Driver.driver.FindElement(By.XPath("//div[@class='field']/div/input[@value = '0']"));
        private static IWebElement oneOff => Driver.driver.FindElement(By.XPath("//div[@class='field']/div/input[@value = '1']"));
        private static IWebElement onsite => Driver.driver.FindElement(By.XPath("//div[@class='inline fields']/div/div/input[@value = '0']"));
        private static IWebElement online => Driver.driver.FindElement(By.XPath("//div[@class='inline fields']/div[2]/div/input[@value = '1']"));
        private static IWebElement Sunday => Driver.driver.FindElement(By.XPath("//div[@class='two wide field']/div/input[@index = '0']"));
        private static IWebElement Monday => Driver.driver.FindElement(By.XPath("//div[@class='two wide field']/div/input[@index = '1']"));

        private static IWebElement Tuesday => Driver.driver.FindElement(By.XPath("//div[@class='two wide field']/div/input[@index = '3']"));
        private static IWebElement Wednesday => Driver.driver.FindElement(By.XPath("//div[@class='two wide field']/div/input[@index = '4']"));
        private static IWebElement Thursday => Driver.driver.FindElement(By.XPath("//div[@class='two wide field']/div/input[@index = '5']"));
        private static IWebElement Friday => Driver.driver.FindElement(By.XPath("//div[@class='two wide field']/div/input[@index = '6']"));
        private static IWebElement Saturday => Driver.driver.FindElement(By.XPath("//div[@class='two wide field']/div/input[@index = '7']"));
        private static IWebElement StartDatedropdown => Driver.driver.FindElement(By.XPath("//input[@name = 'startDate']"));
        private static IWebElement EndDatedropdown => Driver.driver.FindElement(By.XPath("//div[@class = 'fields']/div[4]/input"));
        private static IWebElement Starttime => Driver.driver.FindElement(By.XPath("//div[3]/div[2]/input[1]"));
        private static IWebElement Endtime => Driver.driver.FindElement(By.XPath("//div[3]/div[3]/input[1]"));
        private static IWebElement SkillExchangerb => Driver.driver.FindElement(By.XPath("//form[@class='ui form']/div[8]/div[2]/div/div/div/input[@value = 'true']"));
        private static IWebElement creditrb => Driver.driver.FindElement(By.XPath("//form[@class='ui form']/div[8]/div[2]/div/div[2]/div/input[@value = 'false']"));
        private static IWebElement creditamt => Driver.driver.FindElement(By.XPath("//input[@placeholder = 'Amount']"));
        private static IWebElement skillexchangetag => Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        private static IWebElement active => Driver.driver.FindElement(By.XPath("//form[@class='ui form']/div[10]/div[2]/div/div/div/input[@value = 'true']"));
        private static IWebElement hidden => Driver.driver.FindElement(By.XPath("//form[@class='ui form']/div[10]/div[2]/div/div/div/input[@value = 'false']"));
        private static IWebElement save => Driver.driver.FindElement(By.XPath("//input[@value = 'Save']"));
        private static IWebElement cancel => Driver.driver.FindElement(By.XPath("//input[@value = 'Cancel']"));
        internal void ValidateAddSkill()
        {
            Driver.TurnOnWait();
           
            for (int i = 1; i <= 10; i++)
            {
                ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "ShareSkill");
                var titletext = Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[ " + i + "]/td[3]"));
                //Console.WriteLine(all.Text);
                
                if (titletext.Text == (ExcelLibHelper.ReadData(2, "Title")))

                {
                    Console.WriteLine("Assertion passed");
                    return;
                }
            }
             /*Thread.Sleep(2000);
            var addmsg = Driver.driver.FindElement(By.CssSelector("div.ns-box-inner")).Text;
            Console.WriteLine(addmsg);
            Assert.AreEqual(addmsg, "Service Listing Added Successfully");*/
        }
        internal void AddSkill()
        {
            ShareSkillbtn.Click();
            Thread.Sleep(5000);
            ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "ShareSkill");
            title.SendKeys(ExcelLibHelper.ReadData(2, "Title"));
            description.SendKeys(ExcelLibHelper.ReadData(2, "Description"));
            SelectElement category = new SelectElement(Category);
            category.SelectByIndex(1);
            SelectElement subcategory = new SelectElement(SubCategory);
            subcategory.SelectByIndex(1);
            Tag.SendKeys(ExcelLibHelper.ReadData(2, "Tags"));
            Tag.SendKeys(Keys.Enter);

            if (ExcelLibHelper.ReadData(2, "ServiceType") == "Hourly")
            {
                Hourly.Click();
            }

            else
            {
                oneOff.Click();
            }
            if (ExcelLibHelper.ReadData(2, "LocationType") == "online")
            {
                online.Click();
            }

            else
            {
                onsite.Click();
            }
            Sunday.Click();
            EndDatedropdown.SendKeys("09082020");
            Starttime.SendKeys("1024PM");
            Endtime.SendKeys("1126PM");
            {
                if (ExcelLibHelper.ReadData(2, "SkillTrade") == "SkillExchange")
                {
                    SkillExchangerb.Click();
                    Thread.Sleep(2000);
                    skillexchangetag.SendKeys(ExcelLibHelper.ReadData(2, "Skill-Exchange"));
                    skillexchangetag.SendKeys(Keys.Enter);

                }
                else
                {
                    creditrb.Click();
                    creditamt.SendKeys(ExcelLibHelper.ReadData(2, "Credit"));
                    creditamt.SendKeys(Keys.Enter);
                }
            }
            //Click on Worksample and upload the image
            IWebElement worksample = Driver.driver.FindElement(By.CssSelector("i.huge.plus.circle.icon.padding-25"));
            worksample.Click();
            Thread.Sleep(30000);
            {

                var procStartInfo = new System.Diagnostics.ProcessStartInfo(@"C:\marsframework\FileUpload1.exe");

                var proc = new System.Diagnostics.Process { StartInfo = procStartInfo };

                proc.Start();

                proc.WaitForExit(1000);
                //proc.Kill();

                if (proc.HasExited)
                {
                    {
                        if (ExcelLibHelper.ReadData(2, "Active") == "Hidden")
                        {
                            hidden.Click();

                        }
                        else
                        {
                            active.Click();

                        }
                    }
                }
                    save.Click();
                }
            
        }
        
    }
}