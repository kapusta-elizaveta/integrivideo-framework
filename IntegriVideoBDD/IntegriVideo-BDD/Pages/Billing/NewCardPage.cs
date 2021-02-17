using IntegriVideoProject.PageObjects;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages.Billing
{
    public class NewCardPage
    {
        private const string XPATH_ADD_CARD_BUTTON = "//button[@class='btn']";

        public UIElement InputNumberCard => new UIElement(FindBy.Xpath, "//input[@placeholder='0000 0000 0000 0000']");
        
        public UIElement AppearWrongMessage => new UIElement(FindBy.Xpath, "//input[@placeholder='MM']");

        public UIElement InputMonth => new UIElement(FindBy.Xpath, "//input[@placeholder='MM']");

        public UIElement InputYear => new UIElement(FindBy.Xpath, "//input[@placeholder='YYYY']");

        public UIElement InputCardholderName => new UIElement(FindBy.Xpath,
            "//input[@placeholder='Cardholder name']");
        public UIElement AddButton => new UIElement(FindBy.Xpath, XPATH_ADD_CARD_BUTTON);

        public bool IsWrongCard()
        {
            new Browser().WaitForElementVisible(AppearWrongMessage);
            return true;
        }
    }
}
