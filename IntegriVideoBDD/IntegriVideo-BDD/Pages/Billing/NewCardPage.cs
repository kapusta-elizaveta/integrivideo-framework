using IntegriVideoProject.PageObjects;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages.Billing
{
    public class NewCardPage
    {
        private const string XPATH_APPEAR_WRONG_MESSAGE = "//div[@class='col-xs-11 col-sm-4 alert alert-danger animated fadeInDown']";
        private const string XPATH_ADD_CARD_BUTTON = "//button[@class='btn']";

        public static UIElement InputNumberCard => new UIElement(FindBy.Xpath,
             "//input[@placeholder='0000 0000 0000 0000']");
        
        public static UIElement AppearWrongMessage => new UIElement(FindBy.Xpath, "//input[@placeholder='MM']");

        public static UIElement InputMonth => new UIElement(FindBy.Xpath, "//input[@placeholder='MM']");

        public static UIElement InputYear => new UIElement(FindBy.Xpath, "//input[@placeholder='YYYY']");

        public static UIElement InputCardholderName => new UIElement(FindBy.Xpath,
            "//input[@placeholder='Cardholder name']");
        public static UIElement AddButton => new UIElement(FindBy.Xpath, XPATH_ADD_CARD_BUTTON);

        public void AddWrongCard(string numberCard, string month, string year, string cardholderName)
        {
            Page.Billing.OpenCardPage();
            InputNumberCard.SendKeys(numberCard);
            InputMonth.SendKeys(month);
            InputYear.SendKeys(year);
            InputCardholderName.SendKeys(cardholderName);
            AddButton.Click();
        }

        public bool IsWrongCard()
        {
            new Browser().WaitForElementVisible(AppearWrongMessage);
            return true;
        }
    }
}
