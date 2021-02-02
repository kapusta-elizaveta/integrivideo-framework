using NUnit.Framework;


namespace IntegriVideoProject.Test.ProjectsTest
{
    [TestFixture]
    class CreateProjectPageTest : BasePageTest
    {
        private const string PROJECT_NAME = "Project name";
        private const string PROJECT_DISCRIPTION = "Project discription";
        private const string DOMAIN = "test.com";
        private const string XPATH_COUNT_PROJECTS = "//div[@class='col-xl-4 col-sm-6']";

        /*[Test, Description("Create Project Test")]
        public void CreateProjectTest()
        {
            Page.Login.LogIn("LogInTest");
            int oldCountProject = BrowserFactory.Driver.FindElements(By.XPath(XPATH_COUNT_PROJECTS)).Count;
            Page.CreateProject.AddProject(PROJECT_NAME, PROJECT_DISCRIPTION, DOMAIN);
            string parentWindowHandle = BrowserFactory.Driver.CurrentWindowHandle;
            int newCountProjects = Page.CreateProject.OpenProjectsPage(XPATH_COUNT_PROJECTS);
            BrowserFactory.Driver.Close();
            BrowserFactory.Driver.SwitchTo().Window(parentWindowHandle);
            Assert.AreEqual(newCountProjects, ++oldCountProject, "Project isn't created");      
        }*/
    }
}
