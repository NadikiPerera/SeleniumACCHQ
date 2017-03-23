using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UnitTestProject1.ObjectRepository;
using UnitTestProject1.EnviromentConfigurations;

namespace UnitTestProject1.Actions
{
    public class ActivityListActions : WebdriverInitializer
    {
        public ActivityListActions(string browser) : base(browser)
        {
        }


        public static void SearchActivity(string activityName)
        {
            driver.FindElement(ActivityListPageObjects.activitySearchTextField).Clear();
            driver.FindElement(ActivityListPageObjects.activitySearchTextField).SendKeys(activityName);
        }

        public static void SelectDepartment()
        {
            driver.FindElement(ActivityListPageObjects.departmentDropdownArrow).Click();
            string department = driver.FindElement(ActivityListPageObjects.departmentItem).GetAttribute("text");
            Console.WriteLine(department);
            driver.FindElement(ActivityListPageObjects.departmentItem).Click();
           
        }

        public static void SearchActivity()
        {
            driver.FindElement(ActivityListPageObjects.searchBtn).Click();
        }

    }
}
