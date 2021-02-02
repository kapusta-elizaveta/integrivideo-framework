using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;
using System.Linq;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages.Projects
{
    public class CreateProjectPage 
    {
        public static UIElement InputProjectName() => new UIElement(FindBy.Xpath, "//input[@placeholder='New project']");
        
        public static UIElement InputProjectDiscription() => new UIElement(FindBy.Xpath, 
            "//textarea[@placeholder='Type here...']");
        
        public static UIElement InputDomain() => new UIElement(FindBy.Xpath, "//input[@placeholder='example.com']");
        
        public static UIElement CreateButton() => new UIElement(FindBy.Xpath, "//button[@class='btn']");
        
        public static UIElement ProjectsLink() => new UIElement(FindBy.Xpath, 
            "//a[@class='nav-link'][contains(text(),'Projects')]");
        
        public static UIElement LibraryLink() => new UIElement(FindBy.Xpath, 
            "//a[@class='nav-link'][contains(text(),'Projects')]");


        /*public void AddProject(string projectName, string projectDiscription, string domain)
        {
            Page.Projects.OpenAddProject();
            InputProjectName.EnterText(projectName, "Project name");
            InputProjectDiscription.EnterText(projectDiscription, "Project discription");
            InputDomain.EnterText(domain, "Domain");
            CreateButton.ClickOnIt("Add project button");
        }*/

        /*public int OpenProjectsPage(string xpathCountProject)
        {
            ((IJavaScriptExecutor)BrowserFactory.Driver).ExecuteScript("window.open()");
            BrowserFactory.Driver.SwitchTo().Window(BrowserFactory.Driver.WindowHandles.Last());
            BrowserFactory.Driver.Url = ConfigurationManager.AppSettings["URL"];
            return BrowserFactory.Driver.FindElements(By.XPath(xpathCountProject)).Count;
        }*/
    }
}
