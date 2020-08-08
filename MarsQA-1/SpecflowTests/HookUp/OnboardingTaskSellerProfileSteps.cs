using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class SellerProfileSteps
    {
        [Given(@"I login into the Mars Portal successfully")]
        public void GivenILoginIntoTheMarsPortalSuccessfully()
        {
            
            var SignIn = new SignIn();
            SignIn.SigninStep();
        }


        [When(@"I add language")]
        public void WhenIAddLanguage()
        {
            Profile_onboarding.AddNewLanguage();
        }

        [When(@"I Update language")]
        public void WhenIUpdateLanguage()
        {
            Profile_onboarding.UpdateLanguage();
        }

        [When(@"I delete language")]
        public void WhenIDeleteLanguage()
        {
            Profile_onboarding.DeleteLanguage();
        }

        [When(@"I add language and click on cancel button")]
        public void WhenIAddLanguageAndClickOnCancelButton()
        {
            Profile_onboarding.Cancellanguage();
        }

        [When(@"I add language that was previously added")]
        public void WhenIAddLanguageThatWasPreviouslyAdded()
        {
            Profile_onboarding.AddNewLanguage();
        }

        [When(@"I add null values in language that was previously added")]
        public void WhenIAddNullValuesInLanguageThatWasPreviouslyAdded()
        {
            //Profile.AddNewLanguage();
        }

        [When(@"I add invalid data in language")]
        public void WhenIAddInvalidDataInLanguage()
        {
            //Profile.AddNewLanguage();
        }

        [When(@"I add skill")]
        public void WhenIAddSkill()
        {
            Profile_onboarding.AddNewSkills();
        }

        

        [When(@"I add new Availability")]
        public void WhenIAddNewAvailability()
        {
            Profile_onboarding.AddAvailability();
        }

        [When(@"I add language, skill, education, certification")]
        public void WhenIAddLanguageSkillEducationCertification()
        {
            Profile_onboarding.AddNewLanguage();
            Profile_onboarding.AddNewSkills();
            Profile_onboarding.AddEducation();
            Profile_onboarding.AddCertification();
        }



        [Then(@"language that was entered should be added to the profile successfully")]
        public void ThenLanguageThatWasEnteredShouldBeAddedToTheProfileSuccessfully()
        {
            Profile_onboarding.Message();
            Profile_onboarding.Validatenewlanguage();
        }

        [Then(@"All the details in the language that was edited should be Updated to the profile")]
        public void ThenAllTheDetailsInTheLanguageThatWasEditedShouldBeUpdatedToTheProfile()
        {
            Profile_onboarding.UpdateLanguagemessage();
            Console.WriteLine("Message updated");
            //Profile.Validatenewlanguage();
        }

        [Then(@"All the details that was previously entered in the language should be deleted from the profile")]
        public void ThenAllTheDetailsThatWasPreviouslyEnteredInTheLanguageShouldBeDeletedFromTheProfile()
        {
            Profile_onboarding.DeleteLanguagemessage();
        }

        [Then(@"language, skill, education, certification that was entered should be added to the profile successfully")]
        public void ThenLanguageSkillEducationCertificationThatWasEnteredShouldBeAddedToTheProfileSuccessfully()
        {
            Profile_onboarding.Validatenewlanguage();
            Profile_onboarding.Validatenewskill();
            Profile_onboarding.Validateneweducation();
            Profile_onboarding.Validatenewcertification();
        }


    }
}
