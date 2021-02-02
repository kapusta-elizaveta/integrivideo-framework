using IntegriVideoProject.Pages;
using IntegriVideoProject.Pages.Billing;
using IntegriVideoProject.Pages.Projects;
using IntegriVideoProject.WrapperFactory;
using OpenQA.Selenium.Support.PageObjects;

namespace IntegriVideoProject.PageObjects
{
    public class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
           // PageFactory.InitElements(BrowserFactory.Driver, page);
            return page;
        }

        public static MainPage MainPage
        {
            get { return GetPage<MainPage>(); }
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static ProjectsPage Projects
        {
            get { return GetPage<ProjectsPage>(); }
        }

        public static ProjectPage Project
        {
            get { return GetPage<ProjectPage>(); }
        }

        public static CreateProjectPage CreateProject
        {
            get { return GetPage<CreateProjectPage>(); }
        }

        public static NewComponentPage NewComponent
        {
            get { return GetPage<NewComponentPage>(); }
        }

        public static BillingPage Billing
        {
            get { return GetPage<BillingPage>(); }
        }

        public static NewCardPage NewCard
        {
            get { return GetPage<NewCardPage>(); }
        }

        public static EditProjectPage EditProject
        {
            get { return GetPage<EditProjectPage>(); }
        }
    }
}
