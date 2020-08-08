using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AdvanceTask_ShareSkillSteps
    {
        [Given(@"I log in to the Mars Portal successfully")]
        public void GivenILogInToTheMarsPortalSuccessfully()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
        }
        
        [When(@"I add all the details in the Share Skill page")]
        public void WhenIAddAllTheDetailsInTheShareSkillPage()
        {
            Driver.TurnOnWait();
            var shareSkill = new ShareSkill();
            shareSkill.AddSkill();
        }
        
        [Then(@"ShareSkill details that were entered should be added to the profile successfully")]
        public void ThenShareSkillDetailsThatWereEnteredShouldBeAddedToTheProfileSuccessfully()
        {
            var shareSkill = new ShareSkill();
            shareSkill.ValidateAddSkill();
        }
    }
}
