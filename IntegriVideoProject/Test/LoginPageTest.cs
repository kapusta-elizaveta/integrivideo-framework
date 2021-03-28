using System;
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

        [Test, Description("LogIn Test")]
        public void LogInTest()
        {
            Page.Login.LogIn("LogInTest");
            Console.WriteLine("aaa");
            Assert.AreEqual(LOG_OUT, Page.Login.LogOutIcon.Text, "User didn't log in");
        }
    }
}
