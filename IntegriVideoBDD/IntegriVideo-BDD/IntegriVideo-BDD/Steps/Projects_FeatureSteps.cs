using IntegriVideoProject.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using WebCore;

namespace IntegriVideo_BDD.Steps
{
    [Binding]
    public class Projects_FeatureSteps
    {
        private const string XPATH_COUNT_PROJECTS = "//div[@class='col-xl-4 col-sm-6']";
        private const string DESCRIPTION = "Edit description";
        private const string BUTTON_UPDATE = "Update";

        private int oldCountProject;
        private int newCountProjects;

        //Succesfull create project
        [Given(@"User is in LogIn and click add project")]
        public void GivenUserIsInLogInAndClickAddProject()
        {
            Page.Login.LogIn("LogIn");
            oldCountProject = Browser.Current.CountElements(By.XPath(XPATH_COUNT_PROJECTS));
            Page.Projects.AddProjectButton.Click();
        }
        
        [Given(@"User enter (.*), (.*) and (.*)")]
        public void GivenUserEnterAnd(string projectName, string projectDiscription, string domain)
        {
            Page.CreateProject.InputProjectName.SendKeys(projectName);
            Page.CreateProject.InputProjectDiscription.SendKeys(projectDiscription);
            Page.CreateProject.InputDomain.SendKeys(domain);
        }

        [When(@"click on creare button")]
        public void WhenClickOnCreareButton()
        {
            Page.CreateProject.CreateButton.Click();
        }

        [Then(@"the result should be project is created")]
        public void ThenTheResultShouldBeProjectIsCreated()
        {
            var parentWindowHandle = Browser.Current.GetCurrentWindowName();
            newCountProjects = Page.CreateProject.OpenProjectsPage(XPATH_COUNT_PROJECTS);
            Browser.Current.CloseWindow();
            Browser.Current.SwitchWindowByName(parentWindowHandle);
            Assert.AreEqual(newCountProjects, ++oldCountProject, "Project isn't created");
        }

        //Succesfull edit project page
        [Given(@"User is LogIn and open project")]
        public void GivenUserIsLogInAndOpenProject()
        {
            Page.Login.LogIn("LogIn");
            Page.Projects.ProjectLink.Click();
        }

        [Given(@"User open edit project, enter (.*)")]
        public void GivenUserOpenEditProjectEnter(string description)
        {
            Page.Project.EditComponentLink.Click();
            Page.EditProject.Description.SendKeys(description);
        }

        [When(@"click update button")]
        public void WhenClickUpdateButton()
        {
            Page.EditProject.UpdateButton.Click();
        }

        [Then(@"the result should be project has description")]
        public void ThenTheResultShouldBeProjectHasDescription()
        {
            Page.Projects.OpenProject();
            Assert.AreEqual(DESCRIPTION, Page.Project.ProjectDescription.Text, "Description didn't edit");
        }

        //Succesfull create component
        [Given(@"User click add icon component and enter (.*)")]
        public void GivenUserClickAddIconComponentAndEnter(string componentName)
        {
            Page.Project.IconComponentAdd.Click();
            Page.NewComponent.InputComponentName.SendKeys(componentName);
        }
        
        [When(@"click create button")]
        public void WhenClickCreateButton()
        {
            Page.NewComponent.CreateButton.Click();
        }
        
        [Then(@"the result should be component is created")]
        public void ThenTheResultShouldBeComponentIsCreated()
        {
            Browser.Current.Refresh();
            Assert.AreEqual(BUTTON_UPDATE, Page.NewComponent.ComponentCode.Text, "Component isn't created");
        }
    }
}
