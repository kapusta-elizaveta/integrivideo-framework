using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages.Projects
{
    public class ProjectPage 
    {
        public UIElement IconComponentAdd => new UIElement(FindBy.Xpath, "//span[@class='iv-icon iv-icon-file-add']");

        public UIElement EditComponentLink => new UIElement(FindBy.Xpath, "//a[contains(text(),'Edit')]");

        public UIElement ProjectDescription => new UIElement(FindBy.Xpath, "//div[@class='col-12 description']");
    }
}
