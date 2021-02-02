using IntegriVideoProject.PageObjects;
using IntegriVideoProject.WrapperFactory;
using OpenQA.Selenium;
using System.Configuration;
using System.Linq;
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


        /* public void AddProject(string projectName, string projectDiscription, string domain)
         {
             Page.Projects.OpenAddProject();
             InputProjectName.EnterText(projectName, "Project name");
             InputProjectDiscription.EnterText(projectDiscription, "Project discription");
             InputDomain.EnterText(domain, "Domain");
             CreateButton.ClickOnIt("Add project button");
         }*/

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
            ((IJavaScriptExecutor)BrowserFactory.Driver).ExecuteScript("window.open()");
            BrowserFactory.Driver.SwitchTo().Window(BrowserFactory.Driver.WindowHandles.Last());
            BrowserFactory.Driver.Url = ConfigurationManager.AppSettings["URL"];
            return BrowserFactory.Driver.FindElements(By.XPath(xpathCountProject)).Count;
        }
    }
}
