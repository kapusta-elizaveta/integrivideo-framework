using IntegriVideoProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using WebCore;

namespace IntegriVideoProject.Test.ProjectsTest
{
    [TestFixture]
    class CreateProjectPageTest : BasePageTest
    {
        private const string PROJECT_NAME = "Project name";
        private const string PROJECT_DISCRIPTION = "Project discription";
        private const string DOMAIN = "test.com";
        private const string XPATH_COUNT_PROJECTS = "//div[@class='col-xl-4 col-sm-6']";

        [Test, Description("Create Project Test")]
        public void CreateProjectTest()
        {
            Page.Login.LogIn("LogInTest");
            int oldCountProject = Browser.Current.CountElements(By.XPath(XPATH_COUNT_PROJECTS));
            Page.Projects.AddProjectButton.Click();
            Page.CreateProject.AddProject(PROJECT_NAME, PROJECT_DISCRIPTION, DOMAIN);
            string parentWindowHandle = Browser.Current.GetCurrentWindowName();
            int newCountProjects = Page.CreateProject.OpenProjectsPage(XPATH_COUNT_PROJECTS);
            Browser.Current.CloseWindow();
            Browser.Current.SwitchWindowByName(parentWindowHandle);
            Assert.AreEqual(newCountProjects, ++oldCountProject, "Project isn't created");      
        }
    }
}
