using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages.Billing
{
    public class BillingPage 
    {
        public static UIElement AddNewCardButton() => new UIElement(FindBy.Xpath, "//a[contains(text(),'Add new')]");

        /*public NewCardPage OpenCardPage()
        {
            Page.Projects.OpenBilling();
            AddNewCardButton.ClickOnIt("Add new card button");
            return new NewCardPage();
        }*/
    }
}
