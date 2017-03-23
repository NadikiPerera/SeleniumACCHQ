using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using UnitTestProject1.ObjectRepository;
using UnitTestProject1.Actions;
using UnitTestProject1.EnviromentConfigurations;
using NUnit.Framework;
using System.Threading;

namespace UnitTestProject1.Actions
{
    public class CommonActions:WebdriverInitializer
    {
        public CommonActions(string browser) : base(browser)
        {
        }

        public static void ScrollDown()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
        }

        public static void ScrollUp()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight + 150)");
        }
    }
}
