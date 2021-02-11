using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace IntegriVideoBDD.Steps
{
    [Binding]
    public class LogIn_FeatureSteps
    {
        public IWebDriver driver;

        [Given(@"User is at the LogIn Page")]
        public void GivenUserIsAtTheLogInPage()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(120));
            driver.Url = "https://www.integrivideo.com/app/projects";
        }
        
        [When(@"User enter '(.*)' username and '(.*)' password")]
        public void WhenUserEnterUsernameAndPassword(string username, string password)
        {
            driver.FindElement(By.XPath("//input[@placeholder='Email']")).SendKeys(username);
            driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys(password);
        }
        
        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            driver.FindElement(By.XPath("//button[@class='btn btn-primary']")).Click();
        }
        
        [When(@"User LogOut")]
        public void WhenUserLogOut()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"LogOut button should display")]
        public void ThenLogOutButtonShouldDisplay()
        {
            true.Equals(driver.FindElement(By.XPath("//a[contains(text(),'Logout')]")).Displayed);
        }
        
        [Then(@"LogIn button should display")]
        public void ThenLogInButtonShouldDisplay()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
