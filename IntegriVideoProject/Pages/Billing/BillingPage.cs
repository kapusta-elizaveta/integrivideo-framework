using IntegriVideoProject.PageObjects;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages.Billing
{
    public class BillingPage 
    {
        public UIElement AddNewCardButton => new UIElement(FindBy.Xpath, "//a[contains(text(),'Add new')]");

        /*public NewCardPage OpenCardPage()
        {
            Page.Projects.OpenBilling();
            AddNewCardButton.Click();
            return new NewCardPage();
        }*/
    }
}
