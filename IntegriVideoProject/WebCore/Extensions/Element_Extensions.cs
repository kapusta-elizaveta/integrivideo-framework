using OpenQA.Selenium;
using System;

namespace IntegriVideoProject.Extensions
{
    public static class Element_Extensions
    {
        public static void SendKeys(this IWebElement element, string text, string elementName)
        {
            element.Clear();
            element.SendKeys(text);
            Console.WriteLine(text + " entered in the " + elementName + " field.");
        }

        public static void Click(this IWebElement element, string elementName)
        {
            element.Click();
            Console.WriteLine("Clicked on " + elementName);
        }
    }
}
