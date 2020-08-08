using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    internal class ProfilePage
    {
        public static IWebDriver driver { get; set; }
        private static IWebElement HiUsername => Driver.driver.FindElement(By.CssSelector("span.item.ui.dropdown.link"));
        private static IWebElement changePassword => Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div[2]/div/span/div/a[2]"));
        private static IWebElement currentPassword => Driver.driver.FindElement(By.XPath("//input[@name = 'oldPassword']"));

        private static IWebElement newPassword => Driver.driver.FindElement(By.XPath("//input[@name = 'newPassword']"));
        private static IWebElement confirmPassword => Driver.driver.FindElement(By.XPath("//input[@name = 'confirmPassword']"));
        private static IWebElement saveBtn => Driver.driver.FindElement(By.XPath("//button[@class = 'ui button ui teal button']"));
        private static IWebElement description => Driver.driver.FindElement(By.XPath("//div[@class = 'content']/div/h3/span"));
        private static IWebElement destext => Driver.driver.FindElement(By.XPath("//textarea[@name = 'value']"));
        private static IWebElement dessavebtn => Driver.driver.FindElement(By.XPath("//div[@class = 'tooltip-target ui grid']/div/div[2]/button"));
        private static IWebElement earnTarget => Driver.driver.FindElement(By.XPath("//div[@class = 'right floated content']/span/select"));
        private static IWebElement cancelearntarget => Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[4]/div/span/i"));

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


        private static IWebElement SearchSkillfield => Driver.driver.FindElement(By.XPath("//input[@placeholder = 'Search skills']"));
        private static IWebElement CategorySelection => Driver.driver.FindElement(By.XPath("//div[@role = 'list']/a[7]"));
        private static IWebElement SubCategorySelection => Driver.driver.FindElement(By.XPath("//div[@role = 'list']/a[11]"));


        internal void ValidateSearchSkill()
        {
            Driver.TurnOnWait();
            var title = Driver.driver.Title;
            Console.WriteLine(title);
            Assert.AreEqual(title, "Search");
        }
        internal void SearchSkill()
        {
            SearchSkillfield.Click();
            SearchSkillfield.SendKeys("testing");
            SearchSkillfield.SendKeys(Keys.Enter);
            CategorySelection.Click();
            SubCategorySelection.Click();

        }

        internal void ValidateDeletedCertification()
        {
            Driver.TurnOnWait();
            var deletemsg = Driver.driver.FindElement(By.CssSelector("div.ns-box-inner")).Text;
            Console.WriteLine(deletemsg);
            Assert.AreEqual("Udemy has been deleted from your certification", deletemsg);
        }

        internal void DeleteCertification()
        {
            Driver.TurnOnWait();
            Certificationstab.Click();
            Driver.TurnOnWait();
            {
                for (int j = 1; j <= 5; j++)
                {
                    var all = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'fourth']/div/div[2]/div/table/tbody[" + j + "]/tr/td[1]"));
                    Console.WriteLine(all.Text);
                    ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\\Mars.xlsx", "language");
                    if (all.Text == (ExcelLibHelper.ReadData(2, "CerDelete")))
                    {
                        IWebElement deleteCertification = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'fourth']/div/div[2]/div/table/tbody[" + j + "]/tr/td[4]/span[2]"));
                        deleteCertification.Click();
                        Console.WriteLine("Record deleted");
                        return;
                    }
                }
            }
        }
        internal void ValidateUpdatedCertification()
        {
            Driver.TurnOnWait();
            var updatemsg = Driver.driver.FindElement(By.CssSelector("div.ns-box-inner")).Text;
            Console.WriteLine(updatemsg);
            Assert.AreEqual(updatemsg, "Udemy has been updated to your certification");
        }

        internal void UpdateCertification()
        {
            Driver.TurnOnWait();
            Certificationstab.Click();
            Driver.TurnOnWait();
            {
                for (int j = 1; j <= 5; j++)
                {
                    var all = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'fourth']/div/div[2]/div/table/tbody[" + j + "]/tr/td[1]"));
                    Console.WriteLine(all.Text);
                    ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "language");
                    if (all.Text == (ExcelLibHelper.ReadData(2, "certification")))
                    {
                        IWebElement editCertification = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'fourth']/div/div[2]/div/table/tbody[" + j + "]/tr/td[4]/span[1]"));
                        editCertification.Click();
                        Console.WriteLine("Record ready to update");

                        IWebElement Certificationedit = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'fourth']/div/div[2]/div/table/tbody[" + j + "]/tr/td/div/div/div/input[1]"));
                        Certificationedit.Clear();

                        Certificationedit.SendKeys(ExcelLibHelper.ReadData(2, "CerUpdate"));

                        Driver.driver.FindElement(By.XPath("//div[@data-tab = 'fourth']/div/div[2]/div/table/tbody[" + j + "]/tr/td/div/span/input[1]")).Click();
                        return;
                    }

                }
            }
        }
        internal void Validatenewcertification()
        {
            Driver.TurnOnWait();
            Certificationstab.Click();
            Driver.TurnOnWait();
            ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "language");
            String Vcertification = Driver.driver.FindElement(By.XPath("(//div[@data-tab='fourth']//table//tbody//tr[1]//td[1])[1]")).Text;
            Assert.AreEqual(ExcelLibHelper.ReadData(2, "certification"), Vcertification);
        }

        internal void AddCertification()
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

        internal void ValidateDeletedEducation()
        {
            Driver.TurnOnWait();
            var deletemsg = Driver.driver.FindElement(By.CssSelector("div.ns-box-inner")).Text;
            Console.WriteLine(deletemsg);
            Assert.AreEqual("Education entry successfully removed", deletemsg);
        }

        internal void DeleteEducation()
        {
            Driver.TurnOnWait();
            Educationtab.Click();
            Driver.TurnOnWait();
            {
                for (int j = 1; j <= 5; j++)
                {
                    var all = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'third']/div/div[2]/div/table/tbody[" + j + "]/tr/td[2]"));
                    Console.WriteLine(all.Text);
                    ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "language");
                    if (all.Text == (ExcelLibHelper.ReadData(2, "edDelete")))
                    {
                        IWebElement deleteEducation = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'third']/div/div[2]/div/table/tbody[" + j + "]/tr/td[6]/span[2]"));
                        deleteEducation.Click();
                        Console.WriteLine("Record deleted");
                        return;
                    }
                }
            }
        }

        internal void ValidateUpdatedEducation()
        {
            Driver.TurnOnWait();
            var updatemsg = Driver.driver.FindElement(By.CssSelector("div.ns-box-inner")).Text;
            Console.WriteLine(updatemsg);
            Assert.AreEqual("Education as been updated", updatemsg);
        }

        internal void UpdateEducation()
        {
            Driver.TurnOnWait();
            Educationtab.Click();
            Driver.TurnOnWait();
            {
                for (int j = 1; j <= 5; j++)
                {
                    var all = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'third']/div/div[2]/div/table/tbody[" + j + "]/tr/td[2]"));
                    Console.WriteLine(all.Text);
                    ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "language");
                    if (all.Text == (ExcelLibHelper.ReadData(2, "education")))
                    {
                        IWebElement editEducation = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'third']/div/div[2]/div/table/tbody[" + j + "]/tr/td[6]/span[1]"));
                        editEducation.Click();
                        Console.WriteLine("Record ready to update");

                        IWebElement UpdateEducation = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'third']/div/div[2]/div/table/tbody[" + j + "]/tr/td/div/div/input[1]"));
                        UpdateEducation.Clear();

                        UpdateEducation.SendKeys(ExcelLibHelper.ReadData(2, "edUpdate"));

                        Driver.driver.FindElement(By.XPath("//div[@data-tab = 'third']/div/div[2]/div/table/tbody[" + j + "]/tr/td/div[3]/input[1]")).Click();
                        return;
                    }

                }
            }
        }

        internal void AddNewEducation()
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

        internal void ValidatenewEducation()
        {
            Driver.TurnOnWait();
            Educationtab.Click();
            Driver.TurnOnWait();
            ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "language");
            String Veducation = Driver.driver.FindElement(By.XPath("(//div[@data-tab='third']//table//tbody//tr[1]//td[2])[1]")).Text;
            Assert.AreEqual(ExcelLibHelper.ReadData(2, "education"), Veducation);
        }

        internal void ValidateDeletedSkill()
        {
            Driver.TurnOnWait();
            var deletemsg = Driver.driver.FindElement(By.CssSelector("div.ns-box-inner")).Text;
            Console.WriteLine(deletemsg);
            Assert.AreEqual(deletemsg, "Leadership has been deleted");
        }

        internal void DeleteSkill()
        {
            Driver.TurnOnWait();
            skillstab.Click();
            Driver.TurnOnWait();
            IWebElement deleteSkill = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'second']/div/div[2]/div/table/tbody/tr/td[3]/span[2]"));
            deleteSkill.Click();
            Console.WriteLine("Record deleted");

        }
        internal void ValidateUpdatedSkill()
        {
            Driver.TurnOnWait();
            var updatemsg = Driver.driver.FindElement(By.CssSelector("div.ns-box-inner")).Text;
            Console.WriteLine(updatemsg);
            Assert.AreEqual(updatemsg, "Leadership has been updated to your skills");

        }

        internal void updateSkill()
        {
            Driver.TurnOnWait();
            skillstab.Click();
            Driver.TurnOnWait();
            {
                for (int j = 1; j <= 5; j++)
                {
                    var all = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'second']/div/div[2]/div/table/tbody[" + j + "]/tr/td[1]"));
                    Console.WriteLine(all.Text);
                    ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "language");
                    if (all.Text == (ExcelLibHelper.ReadData(2, "skill")))
                    {
                        IWebElement editSkill = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'second']/div/div[2]/div/table/tbody[" + j + "]/tr/td[3]/span[1]"));
                        editSkill.Click();
                        Console.WriteLine("Record ready to update");

                        IWebElement Skilledit = Driver.driver.FindElement(By.XPath("//div[@data-tab = 'second']/div/div[2]/div/table/tbody[" + j + "]/tr/td/div/div/input[1]"));
                        Skilledit.Clear();

                        Skilledit.SendKeys(ExcelLibHelper.ReadData(2, "SkillUpdate"));
                        SelectElement s = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@data-tab = 'second']/div/div[2]/div/table/tbody[" + j + "]/tr/td/div/div[2]/select")));
                        s.SelectByText("Intermediate");
                        Driver.driver.FindElement(By.XPath("//div[@data-tab = 'second']/div/div[2]/div/table/tbody[" + j + "]/tr/td/div/span/input[1]")).Click();
                        return;
                    }

                }
            }
        }

        internal void ValidatenewSkill()
        {
            Driver.TurnOnWait();
            skillstab.Click();
            Driver.TurnOnWait();
            ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "language");
            String Vskill = Driver.driver.FindElement(By.XPath("(//div[@data-tab='second']//table//tbody//tr[1]//td[1])[1]")).Text;
            Assert.AreEqual((ExcelLibHelper.ReadData(2, "skill")), Vskill);
        }

        internal void AddNewSkill()
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
        internal void ValidateDeletedLanguage()
        {
            Driver.TurnOnWait();
            var deletemsg = Driver.driver.FindElement(By.CssSelector("div.ns-box-inner")).Text;
            Console.WriteLine(deletemsg);
            Assert.AreEqual(deletemsg, "English has been deleted from your languages");
        }

        internal void DeleteLanguage()
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
        internal void ValidateUpdatedLanguage()
        {
            Driver.TurnOnWait();
            var updatemsg = Driver.driver.FindElement(By.CssSelector("div.ns-box-inner")).Text;
            Console.WriteLine(updatemsg);
            Assert.AreEqual(updatemsg, "English has been updated to your languages");
        }
        internal void UpdateLanguage()
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
        internal void EarnTarget()
        {
            earnTarget.Click();
            SelectElement s1 = new SelectElement(Driver.driver.FindElement(By.XPath("//div[@class = 'extra content']/div/div[4]/div/span/select")));
            s1.SelectByIndex(0);
            earnTarget.Click();
        }

        internal void Validatenewlanguage()
        {
            Driver.TurnOnWait();
            languagetab.Click();
            Driver.TurnOnWait();
            ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "language");
            String Vlanguage = Driver.driver.FindElement(By.XPath("(//div[@data-tab='first']//table//tbody//tr[1]//td[1])[1]")).Text;
            Assert.AreEqual((ExcelLibHelper.ReadData(2, "language")), Vlanguage);
        }

        internal void AddNewLanguage()
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

        internal void descriptionValidation()
        {
            var descriptionValidate = Driver.driver.FindElement(By.CssSelector("div.ns-type-success")).Text;
            Console.WriteLine(descriptionValidate);
            Assert.AreEqual(descriptionValidate, "Description has been saved successfully");
        }

        internal void changePasswordValidation()
        {
            Driver.TurnOnWait();
            var changePasswordValidate = Driver.driver.FindElement(By.CssSelector("div.ns-box-inner")).Text;
            Console.WriteLine(changePasswordValidate);
            Assert.AreEqual(changePasswordValidate, "Password Changed Successfully");

        }

        internal void Description()
        {
            Driver.TurnOnWait();
            description.Click();
            Driver.TurnOnWait();
            destext.Clear();
            destext.SendKeys("Tester1234");
            dessavebtn.Click();

        }

        internal void ChangePassword()
        {
            Driver.NavigateUrl();
            Driver.TurnOnWait();
            HiUsername.Click();
            Thread.Sleep(500);
            changePassword.Click();
            ExcelLibHelper.PopulateInCollection(@"C:\Advance task\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");
            currentPassword.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            newPassword.SendKeys(ExcelLibHelper.ReadData(2, "new"));
            confirmPassword.SendKeys(ExcelLibHelper.ReadData(2, "confirm"));
            saveBtn.Click();

        }


    }

}