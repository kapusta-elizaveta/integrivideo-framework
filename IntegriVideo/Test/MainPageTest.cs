using NUnit.Framework;

namespace IntegriVideoProject.Test
{
    [TestFixture]
    class MainPageTest : BasePageTest
    {
        private const string TEXT_LOG_IN_BUTTON = "Log in";

        /*[Test, Description("LogOut Test")]
        public void LogOutTest()
        {
            Page.Login.LogIn("LogInTest");
            Page.Projects.LogOut();
            Assert.AreEqual(TEXT_LOG_IN_BUTTON, Page.MainPage.LogInButton.Text, "Clicking “Logout” doesn’t logout the user");
        }*/
    }
}
