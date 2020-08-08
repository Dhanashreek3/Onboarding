using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AdvanceTask_ManageListingSteps
    {
        [Given(@"I log into the Mars Portal successfully")]
        public void GivenILogIntoTheMarsPortalSuccessfully()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
        }

        [When(@"I navigate to Manage listing tab and delete the skill")]
        public void WhenINavigateToManageListingTabAndDeleteTheSkill()
        {
            Driver.TurnOnWait();
            var manageListing = new ManageListing();
            manageListing.DeleteManageListing();
        }

        [When(@"I navigate to Manage listing tab and click on view the skill")]
        public void WhenINavigateToManageListingTabAndClickOnViewTheSkill()
        {
            Driver.TurnOnWait(); ;
            var manageListing = new ManageListing();
            manageListing.ViewManageListing();
        }

        [When(@"I navigate to Manage listing tab and click on edit the skill")]
        public void WhenINavigateToManageListingTabAndClickOnEditTheSkill()
        {
            Driver.TurnOnWait();
            var manageListing = new ManageListing();
            manageListing.EditManageListing();
        }

        [Then(@"the skill should be deleted from manage listing successfully")]
        public void ThenTheSkillShouldBeDeletedFromManageListingSuccessfully()
        {
            var manageListing = new ManageListing();
            manageListing.ValidateDeleteManageListing();
        }

        [Then(@"the user should be navigated to the view page successfully")]
        public void ThenTheUserShouldBeNavigatedToTheViewPageSuccessfully()
        {
            var manageListing = new ManageListing();
            manageListing.ValidateViewManageListing();
        }

        [Then(@"the user should be navigated to the edit page successfully")]
        public void ThenTheUserShouldBeNavigatedToTheEditPageSuccessfully()
        {
            var manageListing = new ManageListing();
            manageListing.ValidateEditSkill();
        }
    }
}
