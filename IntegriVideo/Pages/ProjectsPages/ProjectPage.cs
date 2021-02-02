using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages.Projects
{
    public class ProjectPage 
    {

        public static UIElement IconComponentAdd() => new UIElement(FindBy.Xpath, "//span[@class='iv-icon iv-icon-file-add']");
        
        public static UIElement ditComponentLink() => new UIElement(FindBy.Xpath, "//a[contains(text(),'Edit')]");
        
        public static UIElement ProjectDescription() => new UIElement(FindBy.Xpath, "//div[@class='col-12 description']");

        /*public void AddComponent()
        {           
            Page.Projects.OpenProject();
            IconComponentAdd.ClickOnIt("Add component");
        }*/

        /*public EditProjectPage OpenEditProject()
        {
            Page.Projects.OpenProject();
            EditComponentLink.ClickOnIt("Edit component");
            return new EditProjectPage();
        }*/
    }
}
