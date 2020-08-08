using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class ProfilePageSteps
    {
        [Given(@"I login into Mars Portal successfully")]
        public void GivenILoginIntoMarsPortalSuccessfully()
        {
            var SignIn = new SignIn();
            SignIn.SigninStep();
        }
        
        [When(@"I add language in the profile")]
        public void WhenIAddLanguageInTheProfile()
        {
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.AddNewLanguage();
        }
        
        [When(@"I Update language in the profile")]
        public void WhenIUpdateLanguageInTheProfile()
        {
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.UpdateLanguage();
        }
        
        [When(@"I delete language in the profile")]
        public void WhenIDeleteLanguageInTheProfile()
        {
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.DeleteLanguage();
        }
        
        [When(@"I add skill in the profile")]
        public void WhenIAddSkillInTheProfile()
        {
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.AddNewSkill();
        }
        
        [When(@"I Update skill in the profile")]
        public void WhenIUpdateSkillInTheProfile()
        {
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.updateSkill();
        }
        
        [When(@"I delete skill in the profile")]
        public void WhenIDeleteSkillInTheProfile()
        {
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.DeleteSkill();
        }
        
        [When(@"I add Education in the profile")]
        public void WhenIAddEducationInTheProfile()
        {
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.AddNewEducation();
        }
        
        [When(@"I Update Education in the profile")]
        public void WhenIUpdateEducationInTheProfile()
        {
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.UpdateEducation();
        }
        
        [When(@"I delete Education in the profile")]
        public void WhenIDeleteEducationInTheProfile()
        {
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.DeleteEducation();
        }
        
        [When(@"I add Certification in the profile")]
        public void WhenIAddCertificationInTheProfile()
        {
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.AddCertification();
        }
        
        [When(@"I Update Certification in the profile")]
        public void WhenIUpdateCertificationInTheProfile()
        {
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.UpdateCertification();
        }
        
        [When(@"I delete Certification in the profile")]
        public void WhenIDeleteCertificationInTheProfile()
        {
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.DeleteCertification();
        }
        
        [When(@"I add description in the description field")]
        public void WhenIAddDescriptionInTheDescriptionField()
        {
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.Description();
        }
        
        [When(@"I search in the search field")]
        public void WhenISearchInTheSearchField()
        {
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.SearchSkill();
        }

        [When(@"I click on change password and enter all valid details")]
        public void WhenIClickOnChangePasswordAndEnterAllValidDetails()
        {
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            profilePage.ChangePassword();
        }

        [Then(@"language that was entered should be added into the profile successfully")]
        public void ThenLanguageThatWasEnteredShouldBeAddedIntoTheProfileSuccessfully()
        {
            var profilePage = new ProfilePage();
            profilePage.Validatenewlanguage();
        }
        
        [Then(@"All the details in the language that was edited should be Updated into the profile")]
        public void ThenAllTheDetailsInTheLanguageThatWasEditedShouldBeUpdatedIntoTheProfile()
        {
            var profilePage = new ProfilePage();
            profilePage.ValidateUpdatedLanguage();
        }
        
        [Then(@"All the details that was previously entered into the language should be deleted from the profile")]
        public void ThenAllTheDetailsThatWasPreviouslyEnteredIntoTheLanguageShouldBeDeletedFromTheProfile()
        {
            var profilePage = new ProfilePage();
            profilePage.ValidateDeletedLanguage();
        }
        
        [Then(@"skill that was entered should be added to the profile successfully")]
        public void ThenSkillThatWasEnteredShouldBeAddedToTheProfileSuccessfully()
        {
            var profilePage = new ProfilePage();
            profilePage.ValidatenewSkill();
        }
        
        [Then(@"All the details in the skill that was edited should be Updated to the profile")]
        public void ThenAllTheDetailsInTheSkillThatWasEditedShouldBeUpdatedToTheProfile()
        {
            var profilePage = new ProfilePage();
            profilePage.ValidateUpdatedSkill();
        }
        
        [Then(@"All the details that was previously entered in the skill should be deleted from the profile")]
        public void ThenAllTheDetailsThatWasPreviouslyEnteredInTheSkillShouldBeDeletedFromTheProfile()
        {
            var profilePage = new ProfilePage();
            profilePage.ValidateDeletedSkill();
        }
        
        [Then(@"Education that was entered should be added to the profile successfully")]
        public void ThenEducationThatWasEnteredShouldBeAddedToTheProfileSuccessfully()
        {
            var profilePage = new ProfilePage();
            profilePage.ValidatenewEducation();
        }
        
        [Then(@"All the details in the Education that was edited should be Updated to the profile")]
        public void ThenAllTheDetailsInTheEducationThatWasEditedShouldBeUpdatedToTheProfile()
        {
            var profilePage = new ProfilePage();
            profilePage.ValidateUpdatedEducation();
        }
        
        [Then(@"All the details that was previously entered in the Education should be deleted from the profile")]
        public void ThenAllTheDetailsThatWasPreviouslyEnteredInTheEducationShouldBeDeletedFromTheProfile()
        {
            var profilePage = new ProfilePage();
            profilePage.ValidateDeletedEducation();
        }
        
        [Then(@"Certification that was entered should be added to the profile successfully")]
        public void ThenCertificationThatWasEnteredShouldBeAddedToTheProfileSuccessfully()
        {
            var profilePage = new ProfilePage();
            profilePage.Validatenewcertification();
        }
        
        [Then(@"All the details in the Certification that was edited should be Updated to the profile")]
        public void ThenAllTheDetailsInTheCertificationThatWasEditedShouldBeUpdatedToTheProfile()
        {
            var profilePage = new ProfilePage();
            profilePage.ValidateUpdatedCertification();
        }
        
        [Then(@"All the details that was previously entered in the Certification should be deleted from the profile")]
        public void ThenAllTheDetailsThatWasPreviouslyEnteredInTheCertificationShouldBeDeletedFromTheProfile()
        {
            var profilePage = new ProfilePage();
            profilePage.ValidateDeletedCertification();
        }
        
        [Then(@"Description should be added to the profile")]
        public void ThenDescriptionShouldBeAddedToTheProfile()
        {
            Driver.TurnOnWait();
            var profilePage = new ProfilePage();
            Driver.TurnWaitOn();
            profilePage.descriptionValidation();
        }
        
        [Then(@"user should be navigated to the search page successfully")]
        public void ThenUserShouldBeNavigatedToTheSearchPageSuccessfully()
        {
            var profilePage = new ProfilePage();
            profilePage.ValidateSearchSkill();
        }

        [Then(@"password should be changed successfully")]
        public void ThenPasswordShouldBeChangedSuccessfully()
        {
            Driver.TurnWaitOn();
            var profilePage = new ProfilePage();
            profilePage.changePasswordValidation();
        }

    }
}
