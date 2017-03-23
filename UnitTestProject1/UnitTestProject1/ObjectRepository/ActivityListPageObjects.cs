using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UnitTestProject1.EnviromentConfigurations;

namespace UnitTestProject1.ObjectRepository
{
    public class ActivityListPageObjects : WebdriverInitializer
    {
        public ActivityListPageObjects(string browser) : base(browser)
        {
        }

        public static By activitySearchTextField = By.Id("ActivityTitle");
        public static By searchBtn = By.Id("Search");
        public static By departmentDropdownArrow = By.XPath(".//span[contains(@class, 'k-icon k-i-arrow-s')]");
        // public static By departmentItem = By.XPath(".//div[contains(@class, 'k-list-scroller')]/ancestor::div/ul/li"); 
        ///ul/li"); //*@id='BusinessUnitId_listbox'/li");
        public static By departmentItem = By.XPath(".//*[@id=\"BusinessUnitId_listbox\"]//li[text()='Health Services']");


    }
}
