using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace IntegriVideo_BDD.Steps
{
    [Binding]
    public class LogIn_FeatureSteps
    {
        IWebDriver driver;

        [Given(@"User is at the LogIn Page")]
        public void GivenUserIsAtTheLogInPage()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(120));
            driver.Url = "https://www.integrivideo.com/app/projects";
        }
        
        [Given(@"User enter '(.*)' username and '(.*)' password")]
        public void GivenUserEnterUsernameAndPassword(string username, string password)
        {
            driver.FindElement(By.XPath("//input[@placeholder='Email']")).SendKeys(username);
            driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys(password);
        }
        
        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"LogOut button should display")]
        public void ThenLogOutButtonShouldDisplay()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
