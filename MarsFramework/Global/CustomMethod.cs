using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Global
{
    public static class CustomMethod
    {
        [Obsolete]
        public static void EnterText(this IWebElement element, string value)
        {
            GlobalDefinitions.Wait(10);
            element.SendKeys(value);
        }

        public static void Clicks(this IWebElement element)
        {
            GlobalDefinitions.Wait(10);
            element.Click();
        }

        public static void SelectFromDDL(this IWebElement element, string value)
        {
            GlobalDefinitions.Wait(10);
            new SelectElement(element).SelectByText(value);
        }

    }
}
