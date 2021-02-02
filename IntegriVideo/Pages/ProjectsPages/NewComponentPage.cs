using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages.Projects
{
    public class NewComponentPage 
    {
        public static UIElement InputComponentName() => new UIElement(FindBy.Xpath, "//input[@placeholder='New component']");


        public static UIElement CreateButton() => new UIElement(FindBy.Xpath, "//button[@class='btn']");
        
        public static UIElement ComponentCode() => new UIElement(FindBy.Xpath, "//button[@class='btn']");

        /*public void CreateComponent(string componentName)
        {
            Page.Project.AddComponent();
            InputComponentName.EnterText(componentName, "Component name");
            CreateButton.ClickOnIt("Create component button");
        }*/
    }
}
