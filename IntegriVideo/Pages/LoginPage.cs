using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using Pages.ProjectsPages;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages
{
    public partial class LoginPage : FullPage
    {
        private string url = ConfigurationManager.AppSettings["URL"];
        
        private const string XPATH_EMAIL = "//input[@placeholder='Email']";
        
        public LoginPage(ApplicationUrls applicationUrls) : base(applicationUrls)
        {
        }
        
        public override void Open(string url)
        {
            Browser.Current.GoTo(url);
            Browser.Current.WaitForPageLoad();
        }
        
        public static UIElement InputEmail => new UIElement(
            FindBy.Xpath, XPATH_EMAIL);
        
        public static UIElement InputPassword => new UIElement(
            FindBy.Xpath, "//input[@placeholder='Password']");
        
        public static UIElement LogInButton => new UIElement(FindBy.Xpath, 
            "//button[@class='btn btn-primary']");
        
        public static UIElement LogOutIcon => new UIElement(FindBy.Xpath, 
            "//a[contains(text(),'Logout')]");

        /*public ProjectsPage LogIn(string testName)
        {
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            var userData = ExcelDataAcces.GetTestData(testName);
            new WebDriverWait(BrowserFactory.Driver, TimeSpan.FromSeconds(10))
                .Until(ExpectedConditions.ElementExists(By.XPath(XPATH_EMAIL)));
            InputEmail.EnterText(userData.Email, "Email");
            InputPassword.EnterText(userData.Password, "password");
            LogInButton.ClickOnIt("Login Button");
            return new ProjectsPage();
        }*/

        public static void LogIn()
        {
            InputEmail.SendKeys("awsxdas");
            InputPassword.SendKeys("scas");
            LogInButton.Click();
        }
        
    }
}
