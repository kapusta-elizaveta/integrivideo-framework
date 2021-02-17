using IntegriVideoProject.PageObjects;
using TechTalk.SpecFlow;

namespace IntegriVideo_BDD.Steps
{
    [Binding]
    public class Billing_FeatureSteps
    {
        [Given(@"User is LogIn on the page")]
        public void GivenUserIsLogInOnThePage()
        {
            Page.Login.LogIn("LogIn");
        }
 
        [Given(@"Open billing and click on add new card button")]
        public void GivenOpenBillingAndClickOnAddNewCardButton()
        {
            Page.Projects.OpenBilling();
            Page.Billing.AddNewCardButton.Click();
        }

        [When(@"user enter wrong: (.*), (.*), (.*) and (.*)")]
        public void WhenUserEnterWrongAnd(string numberCard, string month, string year, string name)
        {
            Page.NewCard.InputNumberCard.SendKeys(numberCard);
            Page.NewCard.InputMonth.SendKeys(month);
            Page.NewCard.InputYear.SendKeys(year);
            Page.NewCard.InputCardholderName.SendKeys(name);
            Page.NewCard.AddButton.Click();
        }


        [Then(@"apper message about wrong card")]
        public void ThenApperMessageAboutWrongCard()
        {
            true.Equals(Page.NewCard.AppearWrongMessage.Displayed);
        }
    }
}
