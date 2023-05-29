using AutomatedTestingCohort.Page_object;
using System;
using TechTalk.SpecFlow;

namespace AutomatedTestingCohort.StepDefinitions
{
    [Binding]
    public class ValidRegistrationStepDefinitions
        
    {
        Registrationpage registrationPage;
        public ValidRegistrationStepDefinitions()
        {
            registrationPage = new Registrationpage();
        
        }

        [Given(@"I nagivate to the website")]
        public void GivenINagivateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }

        [Given(@"I click on Sign up")]
        public void GivenIClickOnSignUp()
            
        {
            registrationPage.ClickonSignUp();
            
        }

        [Given(@"I Enter my Username")]
        public void GivenIEnterMyUsername()
        {
            registrationPage.EnterUsername();
        }

        [Given(@"I Enter my email")]
        public void GivenIEnterMyEmail()
        {
            registrationPage.EnterEmail();
        }


        [Given(@"I enter my password")]
          void GivenIEnterMyPassword()
        {
            registrationPage.EnterPassword();
        }

        [When(@"I click on sign up button")]
         void WhenIClickOnSignUpButton()
        {
            registrationPage.ClickOnSignUpButton();
        }

        [Then(@"I should be able to register succesfully")]
         void ThenIShouldBeAbleToRegisterSuccesfully()
        {
           
        }
    }
}
