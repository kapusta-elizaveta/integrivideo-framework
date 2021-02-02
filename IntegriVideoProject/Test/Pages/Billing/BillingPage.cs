using IntegriVideoProject.Extensions;
using IntegriVideoProject.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages.Billing
{
    public class BillingPage 
    {
        public static UIElement AddNewCardButton => new UIElement(FindBy.Xpath, "//a[contains(text(),'Add new')]");

        /*public NewCardPage OpenCardPage()
        {
            Page.Projects.OpenBilling();
            AddNewCardButton.Click("Add new card button");
            return new NewCardPage();
        }*/

        public NewCardPage OpenCardPage()
        {
            Page.Projects.OpenBilling();
            AddNewCardButton.Click();
            return new NewCardPage();
        }
    }
}
