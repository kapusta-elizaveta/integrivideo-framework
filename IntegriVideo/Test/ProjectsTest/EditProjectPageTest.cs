using NUnit.Framework;

namespace IntegriVideoProject.Test.ProjectsTest
{
    [TestFixture]
    class EditProjectPageTest : BasePageTest
    {
        private const string DESCRIPTION = "Edit description";

        /*[Test, Description("Add Discription Test")]
        public void AddDiscriptionTest()
        {
            Page.Login.LogIn("LogInTest");
            Page.EditProject.EditDescription(DESCRIPTION);
            Page.Projects.OpenProject();
            Assert.AreEqual(DESCRIPTION, Page.Project.ProjectDescription.Text, "Description didn't edit");
        }*/
    }
}
