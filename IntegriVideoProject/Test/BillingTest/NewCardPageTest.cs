using IntegriVideoProject.PageObjects;
using NUnit.Framework;

namespace IntegriVideoProject.Test.BillingTest
{
    [TestFixture]
    class NewCardPageTest : BasePageTest
    {
        private const string NUMBER_CARD = "2343566545342222";
        private const string MONTH = "12";
        private const string YEAR = "2021";
        private const string NAME = "integri";

        [Test, Description("Add Wrong Card Test")]
        public void AddWrongCardTest()
        {
            Page.Login.LogIn("LogInTest");
            Page.Projects. LinkBilling.Click();
            Page.Billing.AddNewCardButton.Click();
            Page.NewCard.AddWrongCard(NUMBER_CARD, MONTH, YEAR, NAME);
            Assert.True(Page.NewCard.IsWrongCard(), "Card is added");
        }
    }
}
