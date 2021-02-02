using System.Globalization;
using OpenQA.Selenium;
using WebCore;

namespace Pages.ProjectsPages
{
    public abstract class FullPage
    {
        protected readonly ApplicationUrls ApplicationUrls;
        public static CultureInfo m_cultureInfo = new CultureInfo("us-US");

        protected FullPage(ApplicationUrls applicationUrls)
        {
            ApplicationUrls = applicationUrls;
        }

        public virtual void Open(string url)
        {
            Browser.Current.GoTo(url);
            Browser.Current.WaitForPageLoad();
        }

        public static string GetUrl()
        {
            return Browser.Current.WrappedDriver.Url.ToLower();
        }

        public void Close()
        {
            Browser.KillCurrent();
        }
    }
}