using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class Profile_onboarding
    {
        public static IWebDriver driver { get; set; }
        private static IWebElement languagetab = Driver.driver.FindElement(By.XPath("//a[@data-tab = 'first']"));

        
        private static IWebElement Addnew => Driver.driver.FindElement(By.XPath("//div[@class = 'form-wrapper']/table/thead/tr/th[3]/div"));

        private static IWebElement Addlanguage => Driver.driver.FindElement(By.XPath("//input[@placeholder = 'Add Language']"));
        private static IWebElement languageDropdown => Driver.driver.FindElement(By.XPath("//select[@class = 'ui dropdown']"));
        private static IWebElement Addbtn => Driver.driver.FindElement(By.XPath("//div[@class = 'six wide field']/input"));
        private static IWebElement Availability => Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[2]/div/span/i"));
        private static IWebElement cancelAvailability => Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[2]/div/span/i"));
       
        private static IWebElement cancelLanguagebtn => Driver.driver.FindElement(By.XPath("//div[@class = 'six wide field']/input[2]"));
        private static IWebElement skillstab => Driver.driver.FindElement(By.XPath("//a[@data-tab = 'second']"));
        private static IWebElement AddNewskillsbtn => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'second']/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement Addskills => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'second']/div/div[2]/div/div/div/input"));
        private static IWebElement Addskillbtn => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'second']/div/div[2]/div/div/span/input[1]"));
        private static IWebElement cancelSkillbtn => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'second']/div/div[2]/div/div/span/input[2]"));

        private static IWebElement Educationtab => Driver.driver.FindElement(By.XPath("//a[@data-tab = 'third']"));
        private static IWebElement AddNewEducationbtn => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'third']/div/div[2]/div/table/thead/tr/th[6]/div"));
        private static IWebElement CollegeName => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'third']/div/div[2]/div/div/div/div/input[1]"));
        private static IWebElement degree => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'third']/div/div[2]/div/div/div[2]/div[2]/input"));
        private static IWebElement AddEducationbtn => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'third']/div/div[2]/div/div/div[3]/div/input[1]"));
        private static IWebElement cancelEducationbtn => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'third']/div/div[2]/div/div/div[3]/div/input[2]"));
        private static IWebElement Certificationstab => Driver.driver.FindElement(By.XPath("//a[@data-tab = 'fourth']"));
        private static IWebElement AddNewCertificationbtn => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'fourth']/div/div[2]/div/table/thead/tr/th[4]/div"));
        private static IWebElement Certificate => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'fourth']/div/div[2]/div/div/div/div/input[1]"));

        private static IWebElement Institute => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'fourth']/div/div[2]/div/div/div[2]/div/input[1]"));

        private static IWebElement AddCertificationbtn => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'fourth']/div/div[2]/div/div/div[3]/input[1]"));

        private static IWebElement cancelCertificationbtn => Driver.driver.FindElement(By.XPath("//div[@data-tab = 'fourth']/div/div[2]/div/div/div[3]/input[2]"));

       

        public static void AddNewLanguage()

        {
            Driver.TurnOnWait();
            //Click on Add new button
            Addnew.Click();
            //Ientify and enter language
            ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "language");
            Addlanguage.SendKeys(ExcelLibHelper.ReadData(2, "language"));
            //Identify and select from the dropdown
            SelectElement s = new SelectElement(languageDropdown);
            s.SelectByIndex(2);
            //Click on Add button
            Addbtn.Click();


        }
        public static void Cancellanguage()
        {

            Addnew.Click();
            Addlanguage.SendKeys("Marathi");
            SelectElement s = new SelectElement(languageDropdown);
            s.SelectByText("Fluent");
            //Click on Cancel button
            cancelLanguagebtn.Click();
        }

        public static void AddNewSkills()
        {

            Driver.TurnOnWait();
            skillstab.Click();
            //Click on Add new button
            AddNewskillsbtn.Click();
            ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "language");
            // Enter skill in the add skill field
            Addskills.SendKeys(ExcelLibHelper.ReadData(2, "skill"));
            //Select level from the dropdown
            SelectElement skill = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@class = 'ui fluid dropdown']")));
            skill.SelectByText("Beginner");
            Addskillbtn.Click();

        }

        public static void CancelSkill()
        {
            skillstab.Click();
            //Click on Add new button
            AddNewskillsbtn.Click();
            // Enter skill in the add skill field
            Addskills.SendKeys("msg2");
            //Select level from the dropdown
            SelectElement skill = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@class = 'ui fluid dropdown']")));
            skill.SelectByText("Beginner");
            //Click on cancel button under skills tab
            cancelSkillbtn.Click();
        }

        public static void AddEducation()
        {
            //Click on Education Tab
            Educationtab.Click();
            //Click on Add new button            
            AddNewEducationbtn.Click();
            ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "language");
            //Enter College/university name            
            CollegeName.SendKeys(ExcelLibHelper.ReadData(2, "education"));
            //Select Country from the dropdown
            SelectElement education = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@data-tab = 'third']/div/div[2]/div/div/div/div[2]/select")));
            education.SelectByText("Australia");
            //Select title from the dropdown
            SelectElement title = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@data-tab = 'third']/div/div[2]/div/div/div[2]/div/select")));
            title.SelectByIndex(2);
            //Enter degree
            degree.SendKeys("Engg3");
            //Select year of Graduation from the dropdown
            SelectElement yearofGraduation = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@data-tab = 'third']/div/div[2]/div/div/div[2]/div[3]/select")));
            yearofGraduation.SelectByText("2017");
            //Click on Add button
            AddEducationbtn.Click();

        }

        public static void CancelEducation()
        {
            Educationtab.Click();
            //Click on Add new button            
            AddNewEducationbtn.Click();
            //Enter College/university name            
            CollegeName.SendKeys("college3");
            //Select Country from the dropdown
            SelectElement education = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@data-tab = 'third']/div/div[2]/div/div/div/div[2]/select")));
            education.SelectByText("Australia");
            //Select title from the dropdown
            SelectElement title = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@data-tab = 'third']/div/div[2]/div/div/div[2]/div/select")));
            title.SelectByIndex(2);
            //Enter degree
            degree.SendKeys("Engg3");
            //Select year of Graduation from the dropdown
            SelectElement yearofGraduation = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@data-tab = 'third']/div/div[2]/div/div/div[2]/div[3]/select")));
            yearofGraduation.SelectByText("2017");
            //Click on Cancel button
            cancelEducationbtn.Click();
        }

        public static void AddCertification()
        {
            Certificationstab.Click();
            //Click on Add new button            
            AddNewCertificationbtn.Click();
            ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "language");
            //Enter the Certicate name           
            Certificate.SendKeys(ExcelLibHelper.ReadData(2, "certification"));
            //Enter the Institution            
            Institute.SendKeys("Adobe");
            //Select year of certification from the dropdown
            SelectElement yearOfCertification = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@data-tab = 'fourth']/div/div[2]/div/div/div[2]/div[2]/select")));
            yearOfCertification.SelectByText("2015");
            //Click on Add button
            AddCertificationbtn.Click();

        }

        public static void cancelCertification()
        {
            Certificationstab.Click();
            //Click on Add new button            
            AddNewCertificationbtn.Click();
            //Enter the Certicate name           
            Certificate.SendKeys("Certificate");
            //Enter the Institution            
            Institute.SendKeys("Adobe");
            //Select year of certification from the dropdown
            SelectElement yearOfCertification = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@data-tab = 'fourth']/div/div[2]/div/div/div[2]/div[2]/select")));
            yearOfCertification.SelectByText("2015");
            //Click on Cancel button         
            cancelCertificationbtn.Click();

        }
        public static void AddAvailability()
        {
            Thread.Sleep(3000);
            Availability.Click();

            //Identify and select availability from the dropdown
            SelectElement availabilitydd = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[2]/div/span/select")));
            availabilitydd.SelectByText("Part Time");
        }

        public static void CancelAvailabilitysection()
        {
            Availability.Click();
            SelectElement availabilitydd = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[2]/div/span/select")));
            //Click on cancel button
            cancelAvailability.Click();
        }
        /*
        public static void AddHours()
        {
            Hours.Click();
            //Identify and select from the Hours dropdown
            SelectElement Hoursdd = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[3]/div/span/select")));
            Hoursdd.SelectByText("As needed");
        }

        public static void CancelHours()
        {
            Hours.Click();
            //Identify and select from the Hours dropdown
            SelectElement Hoursdd = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[3]/div/span/select")));
            //Click on cancel button
            cancelHours.Click();

        }

        public static void AddEarnTarget()
        {
            earnTarget.Click();
            SelectElement earnTargetdd = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[4]/div/span/select")));
            earnTargetdd.SelectByText("More than $1000 per month");
        }

        public static void CancelEarnTarget()
        {
            earnTarget.Click();
            SelectElement earnTargetdd = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[4]/div/span/select")));
            //Click on cancel button
            cancelearntarget.Click();
        }
        */
        public static void Message()
        {

            var msg = Driver.driver.FindElement(By.CssSelector("div.ns-box-inner")).Text;
            Console.WriteLine(msg);
            //Assert.AreEqual(msg, "Certificate has been added to your certification");

        }
        public static void AvailabilityMessage()
        {
            Driver.TurnOnWait();
            var msg1 = Driver.driver.FindElement(By.CssSelector("div.ns-box-inner")).Text;
            Console.WriteLine(msg1);
            Assert.AreEqual(msg1, "Availability updated");

        }
        public static void Validatenewlanguage()
        {
            Driver.TurnOnWait();
            languagetab.Click();
            Driver.TurnOnWait();
            ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "language");
            String Vlanguage = Driver.driver.FindElement(By.XPath("(//div[@data-tab='first']//table//tbody//tr[1]//td[1])[1]")).Text;
            Assert.AreEqual((ExcelLibHelper.ReadData(2, "language")), Vlanguage);
        }
        public static void Validatenewskill()
        {
            Driver.TurnOnWait();
            skillstab.Click();
            Driver.TurnOnWait();
            ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "language");
            String Vskill = Driver.driver.FindElement(By.XPath("(//div[@data-tab='second']//table//tbody//tr[1]//td[1])[1]")).Text;
            Assert.AreEqual((ExcelLibHelper.ReadData(2, "skill")), Vskill);
        }
        public static void Validateneweducation()
        {
            Driver.TurnOnWait();
            Educationtab.Click();
            Driver.TurnOnWait();
            ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "language");
            String Veducation = Driver.driver.FindElement(By.XPath("(//div[@data-tab='third']//table//tbody//tr[1]//td[2])[1]")).Text;
            Assert.AreEqual((ExcelLibHelper.ReadData(2, "education")), Veducation);
        }
        public static void Validatenewcertification()
        {
            Driver.TurnOnWait();
            Certificationstab.Click();
            Driver.TurnOnWait();
            String VCertificate = Driver.driver.FindElement(By.XPath("(//div[@data-tab='fourth']//table//tbody//tr[1]//td[1])[1]")).Text;
            ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "language");
            Assert.AreEqual((ExcelLibHelper.ReadData(2, "certification")), VCertificate);
        }
        public static void DeleteLanguage()
        {
            for (int j = 1; j <= 5; j++)
            {
                var all = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'first']/div/div[2]/div/table/tbody[" + j + "]/tr/td[1]"));
                Console.WriteLine(all.Text);
                ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\\Mars.xlsx", "language");
                if (all.Text == (ExcelLibHelper.ReadData(2, "langdelete")))
                {
                    IWebElement deleteLanguage = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'first']/div/div[2]/div/table/tbody[" + j + "]/tr/td[3]/span[2]"));
                    deleteLanguage.Click();
                    Console.WriteLine("Record deleted");
                    return;
                }
            }
        }
        public static void DeleteLanguagemessage()
        {
            Driver.TurnOnWait();
            var deletemsg = Driver.driver.FindElement(By.CssSelector("div.ns-box-inner")).Text;
            Console.WriteLine(deletemsg);
            Assert.AreEqual(deletemsg, "English has been deleted from your languages");
        }

        public static void UpdateLanguagemessage()
        {
            Driver.TurnOnWait();
            var updatemsg = Driver.driver.FindElement(By.CssSelector("div.ns-box-inner")).Text;
            Console.WriteLine(updatemsg);
            Assert.AreEqual(updatemsg, "English has been updated to your languages");
        }
        public static void UpdateLanguage()
        {
            {
                for (int j = 1; j <= 5; j++)
                {
                    var all = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'first']/div/div[2]/div/table/tbody[" + j + "]/tr/td[1]"));
                    Console.WriteLine(all.Text);
                    ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "language");
                    if (all.Text == (ExcelLibHelper.ReadData(2, "language")))
                    {
                        IWebElement editLanguage = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'first']/div/div[2]/div/table/tbody[" + j + "]/tr/td[3]/span[1]"));
                        editLanguage.Click();
                        Console.WriteLine("Record ready to update");

                        IWebElement languageedit = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'first']/div/div[2]/div/table/tbody[" + j + "]/tr/td/div/div/input[1]"));
                        languageedit.Clear();

                        languageedit.SendKeys(ExcelLibHelper.ReadData(2, "langupdate"));
                        SelectElement s = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@data-tab = 'first']/div/div[2]/div/table/tbody[" + j + "]/tr/td/div/div[2]/select")));
                        s.SelectByText("Basic");
                        Driver.driver.FindElement(By.XPath("//div[@data-tab = 'first']/div/div[2]/div/table/tbody[" + j + "]/tr/td/div/span/input[1]")).Click();
                        return;
                    }

                }
            }


        }
    }
}
