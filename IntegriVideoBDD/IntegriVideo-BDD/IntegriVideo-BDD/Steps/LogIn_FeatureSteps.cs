using IntegriVideoProject.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebCore;

namespace IntegriVideo_BDD.Steps
{
    [Binding]
    public class LogIn_FeatureSteps : BaseStep
    {

        [Given(@"User is at the LogIn Page")]
        public void GivenUserIsAtTheLogInPage()
        {
            Browser.Current.GoTo(Configurator.BaseUrl);
        }
        
        [Given(@"User enter '(.*)' username and '(.*)' password")]
        public void GivenUserEnterUsernameAndPassword(string username, string password)
        {
            Page.Login.InputEmail.SendKeys(Configurator.Email);
            Page.Login.InputPassword.SendKeys(Configurator.Password);
        }
        
        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            Page.Login.LogInButton.Click();
        }
        
        [Then(@"LogOut button should display")]
        public void ThenLogOutButtonShouldDisplay()
        {
            true.Equals(Page.Login.LogOutIcon.Displayed);
        }

        [Given(@"User is in LogIn")]
        public void GivenUserIsInLogIn()
        {
            GivenUserIsAtTheLogInPage();
            GivenUserEnterUsernameAndPassword(Configurator.Email, Configurator.Password);
            WhenClickOnTheLogInButton();
        }

        [When(@"Click on the LogOut button")]
        public void WhenClickOnTheLogOutButton()
        {
            Page.Login.LogOutIcon.Click();
        }

        [Then(@"LogIn button should display")]
        public void ThenLogInButtonShouldDisplay()
        {
            true.Equals(Page.MainPage.LogInButton().Displayed);
        }
    }
}
