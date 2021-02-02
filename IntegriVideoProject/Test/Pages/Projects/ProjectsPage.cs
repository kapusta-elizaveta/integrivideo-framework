﻿using IntegriVideoProject.Extensions;
using IntegriVideoProject.PageObjects;
using IntegriVideoProject.Pages.Billing;
using IntegriVideoProject.WrapperFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using WebCore;
using WebCore.Elements;

namespace IntegriVideoProject.Pages.Projects
{
    public class ProjectsPage 
    {
        private const string XPATH_PROJECT_LINK = "//div[@id='project-list']/div[@class='row']/div[4]";

        public UIElement AddProjectButton => new UIElement(FindBy.Xpath, "//div[@class='project new']//a");

        public UIElement ProjectLink => new UIElement(FindBy.Xpath, XPATH_PROJECT_LINK);

        public UIElement InputComponentName => new UIElement(FindBy.Xpath, "//input[@placeholder='New component']");

        public UIElement CreateButton => new UIElement(FindBy.Xpath, "//button[@class='btn']");

        public UIElement LinkBilling => new UIElement(FindBy.Xpath, "//span[@class='iv-icon iv-icon-credit-card']");

        /* public MainPage LogOut()
         {
             Page.Login.LogOutIcon.Click("Exit button");
             return new MainPage();
         }

         public CreateProjectPage OpenAddProject()
         {
             AddProjectButton.Click("Add project button");
             return new CreateProjectPage();
         }

         public ProjectPage OpenProject()
         {
             new WebDriverWait(BrowserFactory.Driver, TimeSpan.FromSeconds(30))
                 .Until(ExpectedConditions.ElementExists(By.XPath(XPATH_PROJECT_LINK)));
             ProjectLink.Click("Open project");
             return new ProjectPage();
         }

         public BillingPage OpenBilling()
         {
             LinkBilling.Click("Open Billing");
             return new BillingPage();
         }*/

        public MainPage LogOut()
        {
            
            Page.Login.LogOutIcon.Click();
            return new MainPage();
        }

        public CreateProjectPage OpenAddProject()
        {
            AddProjectButton.Click();
            return new CreateProjectPage();
        }

        public ProjectPage OpenProject()
        {
            new WebDriverWait(BrowserFactory.Driver, TimeSpan.FromSeconds(30))
                .Until(ExpectedConditions.ElementExists(By.XPath(XPATH_PROJECT_LINK)));
            ProjectLink.Click();
            return new ProjectPage();
        }

        public BillingPage OpenBilling()
        {
            LinkBilling.Click();
            return new BillingPage();
        }
    }
}
