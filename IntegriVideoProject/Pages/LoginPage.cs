using IntegriVideoProject.Pages.Projects;
using IntegriVideoProject.WrapperFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using Test.TestDataAccess;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages
{
    public class LoginPage 
    {
        private const string XPATH_EMAIL = "//input[@placeholder='Email']";

        public UIElement InputEmail => new UIElement(FindBy.Xpath, XPATH_EMAIL);

        public UIElement InputPassword => new UIElement( FindBy.Xpath, "//input[@placeholder='Password']");

        public  UIElement LogInButton => new UIElement(FindBy.Xpath, "//button[@class='btn btn-primary']");

        public UIElement LogOutIcon => new UIElement(FindBy.Xpath, "//a[contains(text(),'Logout')]");


        /*public ProjectsPage LogIn(string testName)
        {
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            var userData = ExcelDataAcces.GetTestData(testName);
            new WebDriverWait(BrowserFactory.Driver, TimeSpan.FromSeconds(10))
                .Until(ExpectedConditions.ElementExists(By.XPath(XPATH_EMAIL)));
            InputEmail.EnterText(userData.Email, "Email");
            InputPassword.EnterText(userData.Password, "password");
            LogInButton.Click("Login Button");
            return new ProjectsPage();
        }*/

        public ProjectsPage LogIn(string testName)
        {
            string ff = ConfigurationManager.AppSettings["URL"];
            Browser.Current.GoTo(ConfigurationManager.AppSettings["URL"]);
           /// BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            // BrowserFactory.LoadApplication("https://dev.integrivideo.com/app/projects");
            var userData = ExcelDataAccess.GetTestData(testName);
            /*new WebDriverWait(BrowserFactory.Driver, TimeSpan.FromSeconds(10))
                .Until(ExpectedConditions.ElementExists(By.XPath(XPATH_EMAIL)));*/
            InputEmail.SendKeys(userData.Email);
            InputPassword.SendKeys(userData.Password);
            LogInButton.Click();
            return new ProjectsPage();
        }
    }
}
