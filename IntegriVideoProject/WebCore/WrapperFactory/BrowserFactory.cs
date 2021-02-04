using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Threading;
using WebCore;

namespace IntegriVideoProject.WrapperFactory
{
   public class BrowserFactory
    {
        private static IWebDriver driver;
        private const int s_waitElementTimeout = 10;
        private const int s_implicitTimeout = 10;
        private const int s_logoutTimeout = 3000;
        private const int s_pageLoadDefaultTimeoutSeconds = 120;

        /*private static readonly ThreadLocal<Browser> s_instance = new ThreadLocal<Browser>(
            () => { return new Browser(); },
            true
        );

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return driver;
            }
            private set
            {
                driver = value;
            }
        }*/

        /*public static void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                        driver = new FirefoxDriver();
                    break;

                case "IE":
                        driver = new InternetExplorerDriver();
                    break;

                case "Chrome":
                        driver = new ChromeDriver();
                    break;
            }
        }*/
        
        /*public BrowserFactory()
        {
            //IWebDriverEx driver;
            switch (Configurator.BrowserType)
            {
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;

                case "IE":
                    driver = new InternetExplorerDriver();
                    break;

                case "Chrome":
                    driver = new ChromeDriver();
                    break;
            }

            /*driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(s_pageLoadDefaultTimeoutSeconds);
            driver.Manage().Window.Maximize();#1#
            //WrappedDriver = driver;
            ///m_disposed = false;
        }

        public static void LoadApplication(string url)
        {
            Driver.Url = url;
        }

        public static void CloseDriver()
        {
                Driver.Close();
        }*/
    }
}
