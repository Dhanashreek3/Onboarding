using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AventStack.ExtentReports;

namespace MarsQA_1.SpecflowPages.Utils
{
    public class Program : Driver
    {
        [OneTimeSetUp]
        public void BeforeTestFixture()
        {
            ExtentReport.getInstance();

        }

        [OneTimeTearDown]
        public void AfterTestFixture()
        {
            //Flush the extent report
            ExtentReport.EndReport();
            //Close the browser
            driver.Close();


        }
        [SetUp]
        public void BeforeEachTest()
        {
            Initialize();

        }
        [Test]
        public void earnTargetProfile()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var leftProfilePage = new LeftProfile();
            leftProfilePage.EarnTarget();
            leftProfilePage.ValidateAvailability();
        }
        [Test]
        public void AvailabilityProfile()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var leftProfilePage = new LeftProfile();
            leftProfilePage.SelectAvailability();
            leftProfilePage.ValidateAvailability();
        }
        [Test]
        public void HoursProfile()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var leftProfilePage = new LeftProfile();
            leftProfilePage.SelectHours();
            leftProfilePage.ValidateAvailability();
        }

        [Test]
        public void joinPage()
        {
            Driver.NavigateUrl();
            Driver.TurnOnWait();
            var joinPage = new JoinPage();
            joinPage.join();
            joinPage.ValidateJoin();
        }

        [Test]
        public void changepassword()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.ChangePassword();
            Thread.Sleep(3000);
            profilePage.changePasswordValidation();
        }
        [Test]
        public void description()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.Description();
            Driver.TurnWaitOn();
            profilePage.descriptionValidation();
        }
        [Test]
        public void ShareSkill()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var shareSkill = new ShareSkill();
            shareSkill.AddSkill();
            shareSkill.ValidateAddSkill();
        }
        [Test]
        public void Addlanguage()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.AddNewLanguage();
            profilePage.Validatenewlanguage();
        }
        [Test]
        public void EditLanguage()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.UpdateLanguage();
            profilePage.ValidateUpdatedLanguage();
        }
        [Test]
        public void DeleteLanguage()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.DeleteLanguage();
            profilePage.ValidateDeletedLanguage();
        }
        [Test]
        public void AddSkill()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.AddNewSkill();
            profilePage.ValidatenewSkill();
        }
        [Test]
        public void EditSkill()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.updateSkill();
            profilePage.ValidateUpdatedSkill();
        }
        [Test]
        public void DeleteSkill()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.DeleteSkill();
            profilePage.ValidateDeletedSkill();
        }
        [Test]
        public void AddEducation()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.AddNewEducation();
            profilePage.ValidatenewEducation();
        }
        [Test]
        public void EditEducation()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.UpdateEducation();
            profilePage.ValidateUpdatedEducation();
        }
        [Test]
        public void DeleteEducation()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.DeleteEducation();
            profilePage.ValidateDeletedEducation();
        }
        [Test]
        public void AddCertification()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.AddCertification();
            profilePage.Validatenewcertification();
        }
        [Test]
        public void EditCertification()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.UpdateCertification();
            profilePage.ValidateUpdatedCertification();
        }
        [Test]
        public void DeleteCertification()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.DeleteCertification();
            profilePage.ValidateDeletedCertification();
        }

        [Test]
        public void SearchSkills()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.SearchSkill();
            profilePage.ValidateSearchSkill();
        }

        [Test]
        public void DeleteManageListing()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var manageListing = new ManageListing();
            manageListing.DeleteManageListing();
            manageListing.ValidateDeleteManageListing();
        }

        [Test]
        public void ViewManageListing()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait(); ;
            var manageListing = new ManageListing();
            manageListing.ViewManageListing();
            manageListing.ValidateViewManageListing();
        }
        [Test]
        public void EditManageListing()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
            Driver.TurnOnWait();
            var manageListing = new ManageListing();
            manageListing.EditManageListing();
            manageListing.ValidateEditSkill();
        }
    }
}
