using IntegriVideoProject.PageObjects;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages.Projects
{
    public class NewComponentPage 
    {
        public UIElement InputComponentName => new UIElement(FindBy.Xpath, "//input[@placeholder='New component']");
        public UIElement CreateButton => new UIElement(FindBy.Xpath, "//button[@class='btn']");

        public UIElement ComponentCode => new UIElement(FindBy.Xpath, "//button[@class='btn']");

        public void CreateComponent(string componentName)
        {
            InputComponentName.SendKeys(componentName);
            CreateButton.Click();
        }
    }
}
