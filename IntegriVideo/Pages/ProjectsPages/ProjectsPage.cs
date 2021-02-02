using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages.ProjectsPages
{
    public class ProjectsPage 
    {
        private const string XPATH_PROJECT_LINK = "//div[@id='project-list']/div[@class='row']/div[4]";
        
        public static UIElement AddProjectButton() => new UIElement(FindBy.Xpath, "//div[@class='project new']//a");
        
        public static UIElement ProjectLink() => new UIElement(FindBy.Xpath, XPATH_PROJECT_LINK);
        
        public static UIElement InputComponentName() => new UIElement(FindBy.Xpath, "//input[@placeholder='New component']");
        
        public static UIElement CreateButton() => new UIElement(FindBy.Xpath, "//button[@class='btn']");
        
        public static UIElement LinkBilling() => new UIElement(FindBy.Xpath, "//span[@class='iv-icon iv-icon-credit-card']");


        /*public MainPage LogOut()
        {
            Page.Login.LogOutIcon.ClickOnIt("Exit button");
            return new MainPage();
        }

        public CreateProjectPage OpenAddProject()
        {
            AddProjectButton.ClickOnIt("Add project button");
            return new CreateProjectPage();
        }

        public ProjectPage OpenProject()
        {
            new WebDriverWait(BrowserFactory.Driver, TimeSpan.FromSeconds(30))
                .Until(ExpectedConditions.ElementExists(By.XPath(XPATH_PROJECT_LINK)));
            ProjectLink.ClickOnIt("Open project");
            return new ProjectPage();
        }

        public BillingPage OpenBilling()
        {
            LinkBilling.ClickOnIt("Open Billing");
            return new BillingPage();
        }*/
    }
}
