using IntegriVideoProject.PageObjects;
using IntegriVideoProject.WrapperFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
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

        public static UIElement InputMonth => new UIElement(FindBy.Xpath, "//input[@placeholder='MM']");

        public static UIElement InputYear => new UIElement(FindBy.Xpath, "//input[@placeholder='YYYY']");

        public static UIElement InputCardholderName => new UIElement(FindBy.Xpath,
            "//input[@placeholder='Cardholder name']");
        public static UIElement AddButton => new UIElement(FindBy.Xpath, XPATH_ADD_CARD_BUTTON);
        /*public void AddWrongCard(string numberCard, string month, string year , string cardholderName)
        {
            Page.Billing.OpenCardPage();
            InputNumberCard.SendKeys(numberCard, "Number card");
            InputMonth.SendKeys(month, "Month");
            InputYear.SendKeys(year, "Year");
            InputCardholderName.SendKeys(cardholderName, "Cardholder name");
            new WebDriverWait(BrowserFactory.Driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions
                 .ElementToBeClickable(By.XPath(XPATH_ADD_CARD_BUTTON)));
            AddButton.Click("Add card button");
        }*/

        public void AddWrongCard(string numberCard, string month, string year, string cardholderName)
        {
            Page.Billing.OpenCardPage();
            InputNumberCard.SendKeys(numberCard);
            InputMonth.SendKeys(month);
            InputYear.SendKeys(year);
            InputCardholderName.SendKeys(cardholderName);
            new WebDriverWait(BrowserFactory.Driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions
                 .ElementToBeClickable(By.XPath(XPATH_ADD_CARD_BUTTON)));
            AddButton.Click();
        }

        public bool IsWrongCard()
        {
            new WebDriverWait(BrowserFactory.Driver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions
                .ElementIsVisible(By.XPath(XPATH_APPEAR_WRONG_MESSAGE)));
            return true;
        }
    }
}
