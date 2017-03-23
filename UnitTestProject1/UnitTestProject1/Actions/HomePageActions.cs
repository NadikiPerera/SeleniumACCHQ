using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.EnviromentConfigurations;
using UnitTestProject1.ObjectRepository;
using System.Threading;
using OpenQA.Selenium;

namespace UnitTestProject1.Actions
{
    public class HomePageActions: WebdriverInitializer
    {
        public HomePageActions(string browser) : base(browser)
        {
        }

        public static void SelectFromCity()
        {
            driver.FindElement(HomePageObjects.bookATrip).Click();
            driver.FindElement(HomePageObjects.fromCity).Clear();
            driver.FindElement(HomePageObjects.fromCity).SendKeys("mel");
            Thread.Sleep(3000);
            driver.FindElement(HomePageObjects.fromCityListItem).Click();
        }

        public static void SelectToCity(string city)
        {
           
            driver.FindElement(HomePageObjects.toCity).Clear();
            driver.FindElement(HomePageObjects.toCity).SendKeys(city);
            Thread.Sleep(3000);
            driver.FindElement(HomePageObjects.toCityListItem).Click();

        }

        public static void SelectDepartDate()
        {
            driver.FindElement(HomePageObjects.departDate).Click();
            driver.FindElement(HomePageObjects.selectDepartureDate).Click();
        }

        public static void SelectReturnDate()
        {
            driver.FindElement(HomePageObjects.returnDate).Click();
            driver.FindElement(HomePageObjects.selectReturnDate).Click();
        }

        public static void selectPassengers()
        {
            driver.FindElement(HomePageObjects.passengersDropdownArrowIcon).Click();
            driver.FindElement(HomePageObjects.adultsPlusIcon).Click();

        }

    }
}
