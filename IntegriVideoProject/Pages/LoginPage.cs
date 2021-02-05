using IntegriVideoProject.Pages.Projects;
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

        public ProjectsPage LogIn(string testName)
        {
            Browser.Current.GoTo(Configurator.BaseUrl);
            InputEmail.SendKeys(Configurator.Email);
            InputPassword.SendKeys(Configurator.Password);
            LogInButton.Click();
            return new ProjectsPage();
        }
    }
}
