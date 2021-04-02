﻿using IntegriVideoProject.PageObjects;
using NUnit.Framework;
using WebCore;

namespace IntegriVideoProject.Test.ProjectsTest
{
    [TestFixture]
    class NewComponenPageTest : BasePageTest
    {
        private const string COMPONENT_NAME = "Component name";
        private const string BUTTON_UPDATE = "Update";

        [Test, Description("Component should be created")]
        public void CreateComponentTest()
        {
            Page.Login.LogIn("LogInTest");
            Page.Projects.ProjectLink.Click();
            Page.Project.IconComponentAdd.Click();
            Page.NewComponent.CreateComponent(COMPONENT_NAME);
            Browser.Current.Refresh();
            Assert.AreEqual(BUTTON_UPDATE, Page.NewComponent.ComponentCode.Text, "Component isn't created");
        }
    }
}
