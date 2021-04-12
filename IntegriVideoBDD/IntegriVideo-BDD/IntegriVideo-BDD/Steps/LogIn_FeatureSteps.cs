using IntegriVideoProject.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
/*using NUnit.Allure.Attributes;
using NUnit.Allure.Core;*/
using NUnit.Framework;
using TechTalk.SpecFlow;
using WebCore;

namespace IntegriVideo_BDD.Steps
{
    [Binding]
    [AllureNUnit]
    [AllureDisplayIgnored]
    public class LogIn_FeatureSteps : BaseStep
    {
        //Successful Login with Valid Credentials
        [Given(@"User is at the LogIn Page")]
        public void GivenUserIsAtTheLogInPage()
        {
            Browser.Current.GoTo(Configurator.BaseUrl);
        }

        [Given(@"User (.*) email and (.*)")]
        public void GivenUserEmailAnd(string email, string password)
        {
            Page.Login.InputEmail.SendKeys(email);
            Page.Login.InputPassword.SendKeys(password);
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

        //Successful LogOut
        [Given(@"User is in LogIn")]
        public void GivenUserIsInLogIn()
        {
            Page.Login.LogIn("LogIn");
        }

        [When(@"Click on the LogOut button")]
        public void WhenClickOnTheLogOutButton()
        {
            Page.Login.LogOutIcon.Click();
        }

        [Then(@"LogIn button should display")]
        public void ThenLogInButtonShouldDisplay()
        {
            Assert.True(Page.MainPage.LogInButton().Displayed);
            true.Equals(Page.MainPage.LogInButton().Displayed);
        }
    }
}
