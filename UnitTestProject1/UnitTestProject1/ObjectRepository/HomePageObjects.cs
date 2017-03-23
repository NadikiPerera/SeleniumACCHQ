using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace UnitTestProject1.ObjectRepository
{
    public static class HomePageObjects
    {
        public static By bookATrip = By.Id("panel-book-a-trip"); 
        public static By fromCity = By.Id("typeahead-input-from");
        public static By fromCityListItem = By.Id("typeahead-list-item-from-1");
        public static By toCityListItem = By.Id("typeahead-list-item-to-0");
        public static By toCity = By.Id("typeahead-input-to");
        public static By departDate = By.Id("datepicker-input-departureDate");
        public static By selectDepartureDate = By.ClassName("date-picker__calendar-weekdays-items-text");
        public static By returnDate = By.Id("datepicker-input-returnDate");
        public static By selectReturnDate = By.ClassName("date-picker__calendar-weekdays-items-text");
        public static By passengersDropdownArrowIcon = By.ClassName("qfa1-arrow-icon__dropdown qfa1-arrow-icon");
        public static By adultsPlusIcon = By.ClassName("qfa1-numberpicker__plus-icon");



    }

}
