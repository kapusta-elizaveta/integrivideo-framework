using IntegriVideoProject.PageObjects;
using IntegriVideoProject.Pages;
using log4net;
using NUnit.Framework;

namespace IntegriVideoProject.Test
{
    [TestFixture]
    class MainPageTest : BasePageTest
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(MainPageTest));
        private const string TEXT_LOG_IN_BUTTON = "Log in";

        [Test, Description("LogOut Test")]
        public void LogOutTest()
        {
            Page.Login.LogIn("LogInTest");
            Page.Login.LogOutIcon.Click();
            log.Info("log out of profile");
            Assert.AreEqual(TEXT_LOG_IN_BUTTON, Page.MainPage.LogInButton().Text, "Clicking “Logout” doesn’t logout the user");
        }
    }
}
