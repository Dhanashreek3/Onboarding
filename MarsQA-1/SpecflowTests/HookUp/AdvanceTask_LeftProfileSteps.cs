using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    
    [Binding]
    public class AdvanceTaskSteps
    {
        [Given(@"I login in to the Mars Portal successfully")]
        public void GivenILoginInToTheMarsPortalSuccessfully()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
        }
        
        [When(@"I select Availability")]
        public void WhenISelectAvailability()
        {
            Driver.TurnOnWait();
            var leftProfilePage = new LeftProfile();
            leftProfilePage.SelectAvailability();
        }
        
        [When(@"I select Hours")]
        public void WhenISelectHours()
        {
            Driver.TurnOnWait();
            var leftProfilePage = new LeftProfile();
            leftProfilePage.SelectHours();
        }
        
        [When(@"I select Earn target")]
        public void WhenISelectEarnTarget()
        {
            Driver.TurnOnWait();
            var leftProfilePage = new LeftProfile();
            leftProfilePage.EarnTarget();
            leftProfilePage.ValidateAvailability();
        }
        
        [Then(@"Availability that was selected should be updated to the profile successfully")]
        public void ThenAvailabilityThatWasSelectedShouldBeUpdatedToTheProfileSuccessfully()
        {
            var leftProfilePage = new LeftProfile();
            leftProfilePage.ValidateAvailability();
        }
        
        [Then(@"Hours that was selected should be updated to the profile successfully")]
        public void ThenHoursThatWasSelectedShouldBeUpdatedToTheProfileSuccessfully()
        {
            var leftProfilePage = new LeftProfile();
            leftProfilePage.ValidateAvailability();
        }
        
        [Then(@"Earn target that was selected should be updated to the profile successfully")]
        public void ThenEarnTargetThatWasSelectedShouldBeUpdatedToTheProfileSuccessfully()
        {
            var leftProfilePage = new LeftProfile();
            leftProfilePage.ValidateAvailability();
        }
    }
}
