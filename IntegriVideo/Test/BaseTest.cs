using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.Configuration;
using System.IO;
using System.Reflection;
using IntegriVideoProject.Pages;
using WebCore;

namespace IntegriVideoProject.Test
{
    //[TestFixture]
   // [AllureNUnit]
   // [AllureDisplayIgnored]
    public class BasePageTest
    {
        /*[OneTimeSetUp]
        public void SetupTest()
        {
            /*BrowserFactory.InitBrowser(ConfigurationManager.AppSettings["Browser"]);
            BrowserFactory.Driver.Manage().Window.Maximize();#1#
            var s_allurePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var s_allureFolder = Path.Combine(s_allurePath, "allure-results");
            Directory.CreateDirectory(s_allureFolder);
        }*/
        
        [SetUp]
        public void Init()
        {
            new LoginPage(ApplicationUrls.Automation).Open(ConfigurationManager.AppSettings["URL"]);
        }

        [TearDown]
        public void AfterMethod()
        {
            if (!TestContext.CurrentContext.Result.Outcome.Equals(ResultState.Success))
            {
                var fileName = TestContext.CurrentContext.Test.MethodName.Replace("\"", "") + ".png"; 
                var fullFilePath = Path.Combine(Configurator.DownloadFolder, fileName);
                
                var attachment = Browser.Current.MakeScreenshot(fullFilePath);

                AllureLifecycle.Instance.AddAttachment(
                    fileName,
                    "image/png",
                    attachment);
                
                TestContext.AddTestAttachment(fullFilePath, fileName);
            }
        }
         
        [OneTimeTearDown]
        public void CloseMethod()
        {
            Browser.KillCurrent();
        }
        
        /*private void TakeScreenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var fileName = TestContext.CurrentContext.Test.MethodName.Replace("\"", "") + ".png"; 
                var screenshot = ((ITakesScreenshot)BrowserFactory.Driver).GetScreenshot(); 
                AllureLifecycle.Instance.AddAttachment(fileName, "image/png", screenshot.AsByteArray);
            }
        }*/

        /*[TearDown]
        public void TearDown()
        {
            TakeScreenshot();
            BrowserFactory.CloseDriver();
        }*/
    }
}

