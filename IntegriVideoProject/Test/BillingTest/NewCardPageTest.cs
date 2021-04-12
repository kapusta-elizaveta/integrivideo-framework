using Allure.Commons;
using IntegriVideoProject.PageObjects;
using IntegriVideoProject.Test.ProjectsTest;
using log4net;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace IntegriVideoProject.Test.BillingTest
{
    [TestFixture]
    class NewCardPageTest : BasePageTest
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(NewCardPageTest));
        
        private const string NUMBER_CARD = "2343566545342222";
        private const string MONTH = "12";
        private const string YEAR = "2021";
        private const string NAME = "integri";

        [Test, Description("Add Wrong Card")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureTag("Regression")]
        public void AddWrongCardTest()
        {
            Page.Login.LogIn("LogInTest");
            Page.Projects. LinkBilling.Click();
            log.Info("Open billing");
            Page.Billing.AddNewCardButton.Click();
            log.Info("click to add new card");
            Page.NewCard.AddWrongCard(NUMBER_CARD, MONTH, YEAR, NAME);
            log.Info("add wrong card with data " + NUMBER_CARD+ " " + MONTH + " " + YEAR + " " + NAME);
            Assert.True(Page.NewCard.IsWrongCard(), "Card is added");
        }
    }
}
