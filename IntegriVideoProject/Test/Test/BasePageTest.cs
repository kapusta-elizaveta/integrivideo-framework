using Allure.Commons;
using IntegriVideoProject.PageObjects;
using IntegriVideoProject.WrapperFactory;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.Configuration;

namespace IntegriVideoProject.Test
{
    [TestFixture]
    //[AllureNUnit]
    //[AllureDisplayIgnored]
    public class BasePageTest
    {
        /*[SetUp]
        public void SetupTest()
        {
            BrowserFactory.InitBrowser(ConfigurationManager.AppSettings["Browser"]);
            BrowserFactory.Driver.Manage().Window.Maximize();
        }*/
        
        [SetUp]
        public void SetupTest()
        {
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.Driver.Manage().Window.Maximize();
        }

        private void TakeScreenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var fileName = TestContext.CurrentContext.Test.MethodName.Replace("\"", "") + ".png"; 
                var screenshot = ((ITakesScreenshot)BrowserFactory.Driver).GetScreenshot(); 
                AllureLifecycle.Instance.AddAttachment(fileName, "image/png", screenshot.AsByteArray);
            }
        }

        [TearDown]
        public void TearDown()
        {
            TakeScreenshot();
            BrowserFactory.CloseDriver();
        }
    }
}

