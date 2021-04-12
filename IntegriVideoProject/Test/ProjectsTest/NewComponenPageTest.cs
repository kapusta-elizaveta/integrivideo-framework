using Allure.Commons;
using IntegriVideoProject.PageObjects;
using log4net;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using WebCore;

namespace IntegriVideoProject.Test.ProjectsTest
{
    [TestFixture]
    class NewComponenPageTest : BasePageTest
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(NewComponenPageTest));
        
        private const string COMPONENT_NAME = "Component name";
        private const string BUTTON_UPDATE = "Update";

        [Test, Description("Component should be created")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureTag("Regression")]
        public void CreateComponentTest()
        {
            Page.Login.LogIn("LogInTest");
            Page.Projects.ProjectLink.Click();
            log.Info("Go to project");
            Page.Project.IconComponentAdd.Click();
            log.Info("Click to add component");
            Page.NewComponent.CreateComponent(COMPONENT_NAME);
            log.Info("Create component with name " + COMPONENT_NAME);
            Browser.Current.Refresh();
            Assert.AreEqual(BUTTON_UPDATE, Page.NewComponent.ComponentCode.Text, "Component isn't created");
        }
    }
}
