using IntegriVideoProject.Pages;
using NUnit.Framework;

namespace IntegriVideoProject.Test
{
    [TestFixture]
    class LoginPageTest : BasePageTest
    {
        private const string LOG_OUT = "Laogout";

        /*[Test, Description("LogIn Test")]
        public void LogInTest()
        {
            Page.Login.LogIn("LogInTest");
            Assert.AreEqual(LOG_OUT, Page.Login.LogOutIcon.Text, "User didn't log in");
        }*/
        
        [Test, Description("LogIn Test")]
       public void LogInTest()
       {
           LoginPage.LogIn();
           //Assert.AreEqual(LOG_OUT, Page.Login.LogOutIcon.Text, "User didn't log in");
       }
    }
}
