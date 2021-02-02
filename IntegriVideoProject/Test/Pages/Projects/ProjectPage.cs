using IntegriVideoProject.Extensions;
using IntegriVideoProject.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages.Projects
{
    public class ProjectPage 
    {
        public UIElement IconComponentAdd => new UIElement(FindBy.Xpath, "//span[@class='iv-icon iv-icon-file-add']");

        public UIElement EditComponentLink => new UIElement(FindBy.Xpath, "//a[contains(text(),'Edit')]");

        public UIElement ProjectDescription => new UIElement(FindBy.Xpath, "//div[@class='col-12 description']");

        /*public void AddComponent()
        {           
            Page.Projects.OpenProject();
            IconComponentAdd.Click("Add component");
        }

        public EditProjectPage OpenEditProject()
        {
            Page.Projects.OpenProject();
            EditComponentLink.Click("Edit component");
            return new EditProjectPage();
        }*/

        public void AddComponent()
        {
            Page.Projects.OpenProject();
            IconComponentAdd.Click();
        }

        public EditProjectPage OpenEditProject()
        {
            Page.Projects.OpenProject();
            EditComponentLink.Click();
            return new EditProjectPage();
        }
    }
}
