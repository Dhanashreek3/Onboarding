using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AdvanceTask_JoinSteps
    {
        [Given(@"I navigate to the Mars Site")]
        public void GivenINavigateToTheMarsSite()
        {
            Driver.NavigateUrl();
            Driver.TurnOnWait();
        }
        
        [When(@"I Click on Join and enter all the details")]
        public void WhenIClickOnJoinAndEnterAllTheDetails()
        {
            var joinPage = new JoinPage();
            joinPage.join();
            
        }
        
        [Then(@"Seller should be able to create a new account in the Mars successfully")]
        public void ThenSellerShouldBeAbleToCreateANewAccountInTheMarsSuccessfully()
        {
            var joinPage = new JoinPage(); 
            joinPage.ValidateJoin();
        }
    }
}
