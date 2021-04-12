using Allure.Commons;
using IntegriVideoProject.PageObjects;
using log4net;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace IntegriVideoProject.Test.ProjectsTest
{
    [TestFixture]
    class EditProjectPageTest : BasePageTest
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(EditProjectPageTest));
        private const string DESCRIPTION = "Edit description";

        [Test, Description("Add Discription in the project")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureTag("Regression")]
        public void AddDiscriptionTest()
        {
            Page.Login.LogIn("LogInTest");
            Page.Projects.ProjectLink.Click();
            log.Info("Open project");
            Page.Project.EditComponentLink.Click();
            log.Info("Open edit component");
            Page.EditProject.EditDescription(DESCRIPTION);
            log.Info("Add description");
            Page.Projects.ProjectLink.Click();
            Assert.AreEqual(DESCRIPTION, Page.Project.ProjectDescription.Text, "Description didn't edit");
        }
    }
}
