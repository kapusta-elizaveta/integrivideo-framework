using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages
{
    public class MainPage 
    {
        public UIElement LogInButton() => new UIElement(FindBy.Xpath, "//a[@class='btn']");
    }
}
