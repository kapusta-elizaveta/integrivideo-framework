using IntegriVideoProject.PageObjects;
using OpenQA.Selenium;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages.Projects
{
    public class CreateProjectPage 
    {

        public UIElement InputProjectName => new UIElement(FindBy.Xpath, "//input[@placeholder='New project']");

        public UIElement InputProjectDiscription => new UIElement(FindBy.Xpath, "//textarea[@placeholder='Type here...']");

        public UIElement InputDomain => new UIElement(FindBy.Xpath, "//input[@placeholder='example.com']");

        public UIElement CreateButton => new UIElement(FindBy.Xpath, "//button[@class='btn']");

        public UIElement ProjectsLink => new UIElement(FindBy.Xpath, "//a[@class='nav-link'][contains(text(),'Projects')]");

        public UIElement LibraryLink => new UIElement(FindBy.Xpath,"//a[@class='nav-link'][contains(text(),'Projects')]");

        public void AddProject(string projectName, string projectDiscription, string domain)
        {
            Page.Projects.OpenAddProject();
            InputProjectName.SendKeys(projectName);
            InputProjectDiscription.SendKeys(projectDiscription);
            InputDomain.SendKeys(domain);
            CreateButton.Click();
        }

        public int OpenProjectsPage(string xpathCountProject)
        {
            Browser.Current.OpenNewTab();
            Browser.Current.SwitchToLastWindow();
            Browser.Current.GoTo(Configurator.BaseUrl);
            return Browser.Current.CountElements(By.XPath(xpathCountProject));
        }
    }
}
