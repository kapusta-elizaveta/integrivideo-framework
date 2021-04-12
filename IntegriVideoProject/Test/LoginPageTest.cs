using System;
using Allure.Commons;
using IntegriVideoProject.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace IntegriVideoProject.Test
{
    [TestFixture]
    [AllureNUnit]
    [AllureDisplayIgnored]
    class LoginPageTest : BasePageTest
    {
        private const string LOG_OUT = "Logout";

        [Test, Description("Log in with correct data")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureTag("Regression")]
        public void LogInTest()
        {
            Page.Login.LogIn("LogInTest");
            Assert.AreEqual(LOG_OUT, Page.Login.LogOutIcon.Text, "User didn't log in");
        }
    }
}
