using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.HookUp
{
    [Binding]
    public class ProfileSteps
    {
        [Given(@"I login in to the Mars Portal successfully")]
        public void GivenILoginInToTheMarsPortalSuccessfully()
        {
            SignIn.SigninStep();

        }

        [When(@"I add new language, skill,education,certification")]
        public void WhenIAddNewLanguageSkillEducationCertification()
        {
            Profile.AddNewLanguage();
            Profile.AddNewSkills();
            Profile.AddEducation();
            Profile.AddCertification();
        }

        [Then(@"All the details that was entered should be added to the profile")]
        public void ThenAllTheDetailsThatWasEnteredShouldBeAddedToTheProfile()
        {
            //Profile.Message();
            Console.WriteLine("Records added");
            Profile.Validatenewlanguage();
            Profile.Validatenewskill();
            Profile.Validateneweducation();
            Profile.Validatenewcertification();
        }

        [When(@"I Update language, \(skill,education,certification\)")]
        public void WhenIUpdateLanguageSkillEducationCertification()
        {
            Profile.UpdateLanguage();
        }

        [Then(@"All the details that was edited should be Updated to the profile")]
        public void ThenAllTheDetailsThatWasEditedShouldBeUpdatedToTheProfile()
        {
            Console.WriteLine("Record updated");
            Profile.UpdateLanguagemessage();
        }

        [When(@"I delete language, \(skill,education,certification\)")]
        public void WhenIDeleteLanguageSkillEducationCertification()
        {
            Profile.DeleteLanguage();
        }

        [Then(@"All the details that was previously entered should be deleted from the profile")]
        public void ThenAllTheDetailsThatWasPreviouslyEnteredShouldBeDeletedFromTheProfile()
        {
            Console.WriteLine("Record deleted");
            Profile.DeleteLanguagemessage();
        }

    }
}
