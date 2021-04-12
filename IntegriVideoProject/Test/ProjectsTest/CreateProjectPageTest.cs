using Allure.Commons;
using IntegriVideoProject.PageObjects;
using log4net;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using WebCore;

namespace IntegriVideoProject.Test.ProjectsTest
{
    [TestFixture]
    class CreateProjectPageTest : BasePageTest
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(CreateProjectPageTest));
        
        private const string PROJECT_NAME = "Project name";
        private const string PROJECT_DISCRIPTION = "Project discription";
        private const string DOMAIN = "test.com";
        private const string XPATH_COUNT_PROJECTS = "//div[@class='col-xl-4 col-sm-6']";

        [Test, Description("Create Project")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureTag("Regression")]
        public void CreateProjectTest()
        {
            Page.Login.LogIn("LogInTest");
            int oldCountProject = Browser.Current.CountElements(By.XPath(XPATH_COUNT_PROJECTS));
            Page.Projects.AddProjectButton.Click();
            log.Info("Click to add project button");
            Page.CreateProject.AddProject(PROJECT_NAME, PROJECT_DISCRIPTION, DOMAIN);
            log.Info("add project with data "+ PROJECT_NAME+ " " + PROJECT_DISCRIPTION + " "+ DOMAIN);
            string parentWindowHandle = Browser.Current.GetCurrentWindowName();
            int newCountProjects = Page.CreateProject.OpenProjectsPage(XPATH_COUNT_PROJECTS);
            Browser.Current.CloseWindow();
            Browser.Current.SwitchWindowByName(parentWindowHandle);
            Assert.AreEqual(newCountProjects, ++oldCountProject, "Project isn't created");      
        }
    }
}
