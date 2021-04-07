using System;
using System.Configuration;
using System.IO;
using IntegriVideoProject.Pages.Projects;
using log4net;
using log4net.Config;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages
{
    public class LoginPage 
    {
        //public static readonly ILog log = LogManager.GetLogger(typeof(LoginPage));
        public static readonly ILog log = LogManager.GetLogger(typeof(LoginPage));

        private const string XPATH_EMAIL = "//input[@placeholder='Email']";

        public UIElement InputEmail => new UIElement(FindBy.Xpath, XPATH_EMAIL);

        public UIElement InputPassword => new UIElement( FindBy.Xpath, "//input[@placeholder='Password']");

        public  UIElement LogInButton => new UIElement(FindBy.Xpath, "//button[@class='btn btn-primary']");

        public UIElement LogOutIcon => new UIElement(FindBy.Xpath, "//a[contains(text(),'Logout')]");

        public ProjectsPage LogIn(string testName)
        {
            Logger.InitLogger();
            Browser.Current.GoTo(Configurator.BaseUrl);
            log.Info("Go to website " + Configurator.BaseUrl);
            InputEmail.SendKeys(Configurator.Email);
            InputPassword.SendKeys(Configurator.Password);
            log.Info("Enter login data " + Configurator.Email +" and " + Configurator.Password);
            LogInButton.Click();
            log.Info("Press login button");
            return new ProjectsPage();
        }
        
    }
}
