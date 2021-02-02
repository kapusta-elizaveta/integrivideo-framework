using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages.Projects
{
    public class EditProjectPage
    {
        public static UIElement Description() => new UIElement(FindBy.Xpath, "//textarea[@placeholder='Type here...']");
        
        public static UIElement UpdateButton() => new UIElement(FindBy.Xpath, "//button[@class='btn']");

        /*public ProjectsPage EditDescription(string description)
        {
            Page.Project.OpenEditProject();
            Description.EnterText(description, "Description");
            UpdateButton.ClickOnIt("Update project button");
            return new ProjectsPage();
        }*/
    }
}
