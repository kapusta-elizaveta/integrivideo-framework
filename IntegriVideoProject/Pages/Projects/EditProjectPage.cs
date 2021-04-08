using IntegriVideoProject.PageObjects;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages.Projects
{
    public class EditProjectPage
    {
        public UIElement Description => new UIElement(FindBy.Xpath, "//textarea[@placeholder='Type here...']");

        public UIElement UpdateButton => new UIElement(FindBy.Xpath, "//button[@class='btn']");

        public ProjectsPage EditDescription(string description)
        {
            Description.SendKeys(description);
            UpdateButton.Click();
            return new ProjectsPage();
        }
    }
}
