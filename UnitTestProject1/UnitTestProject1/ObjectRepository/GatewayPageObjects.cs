using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using UnitTestProject1.ObjectRepository;


namespace UnitTestProject1.ObjectRepository
{
    public static class GatewayPageObjects
    {
        public static string departmentName;
        public static By loginUserName = By.Id("Username");
        public static By password = By.Id("Password");
        public static By acceptTermsConditionsCheckBox = By.Name("AcceptsTermsOfUse");
        public static By loginBtn = By.Id("login-btn");

        public static By activityRoutineManagementLink = By.LinkText("Activity & Routine Management");
        public static By activityManagement = By.XPath(".//h3[text()='Activity Management']");

        public static By CreateActivityBtn = By.XPath("//a[text()='+ Create Activity']");
        public static By createProgramID = By.Id("CVProgramID");
        public static By activityTitle = By.Id("ActivityTitle");
        public static By activityShortName = By.Id("ShortName");
        public static By department = By.XPath("//span[text()='-- Choose Department --']");
        public static By departmentdropdownArrow = By.XPath(".//label[text()='Department']/ancestor::div[2]/following-sibling::div[1]//span[contains(@class,'k-icon k-i-arrow-s')]|span[text()='select']");
        public static By activityTypedropdownArrow = By.XPath(".//label[text()='Activity Type']/ancestor::div[2]/following-sibling::div[1]//span[contains(@class,'k-icon k-i-arrow-s')]|span[text()='select']");
        public static By activityCategorydropdownArrow = By.XPath(".//label[text()='Activity Category']/ancestor::div[2]//span[contains(@class,'k-icon k-i-arrow-s')]");

       
        public static By serviceProvidersTextField = By.XPath(".//label[text()='Service Provider/s']/ancestor::div[2]/following-sibling::div[1]//input");
        public static By waitlistRadioBtnYes = By.XPath(".//*[@id=\"IsWaitlistRequiredGroup\"]/span[1]/label");
        //public static By waitlistRadioBtnYes = By.CssSelector("#IsWaitlistRequiredGroup > span:nth-child(1) > label");
        public static By waitlistRadioBtnNo = By.CssSelector("#IsWaitlistRequiredGroup > span:nth-child(2) > label");
        public static By attendanceRequiredYesBtn = By.CssSelector("#IsAttendanceRequiredGroup>span:nth-child(1) > label");
        public static By attendanceRequiredNoBtn = By.CssSelector("#IsAttendanceRequiredGroup>span:nth-child(2) > label");
        public static By maximumParticipantsIncreaseBtn = By.XPath(".//label[text()='Maximum Participants']/ancestor::div[2]//span[contains(@class,'k-icon k-i-arrow-n')]");
        public static By maximumParticipantsDecreaseBtn = By.XPath(".//label[text()='Maximum Participants']/ancestor::div[2]//span[contains(@class,'k-icon k-i-arrow-s')]");
        public static By maximumParticipantsRequired = By.XPath(".//label[text()='Maximum Participants']/ancestor::div[2]/script|span[contains(@class,'required')]|span[text()='Required')]");
        public static By maximumParticipantMsg = By.XPath(".//i[contains(text(),'Maximum Participants of 0 means unlimited participants.')]");
        public static By maximumParticipantErrorMsg = By.XPath(".//span[contains(@class,'error k-invalid-msg field-validation-error')]|span[contains(@id,'MaximumParticipants_validationMessage')]");
        public static By maximumParticipantTextField = By.XPath(".//span[contains(@class,'k-numeric-wrap k-state-default')]");                                                                                                                                            
        public static By activeFromDate = By.Id("ActiveFromDate");
        public static By activeTodate = By.Id("ActiveToDate");
        public static By activeActivitiesMsg = By.XPath(".//i[contains(text(),'Leave blank for always active Activities.')]");
        public static By visibleByPrisionersFlagNoBtn = By.XPath(".//*[@id=\"VisibleByPrionserFlagGroup\"]/span[2]/label"); //CssSelector("#VisibleByPrionserFlagGroup>span:nth-child(2) > label");// //(".//div[contains(@id,'VisibleByPrionserFlagGroup')]/|input[@id='VisibleByPrisonerFlag_False']|label[contains(@class='k-radio-label'and text='No']");
        public static By purposefulFromDate = By.Id("PurposefulFromDate");
        public static By purposefulToDate = By.Id("PurposefulToDate");
        public static By purposefulActivitiesMsg = By.XPath(".//i[contains(text(),'Leave blank for always purposeful Activities.')]");
        // public static By selfReferableNoBtn = By.XPath(".//input[contains(@class='k-radio k-radio'| @id='SelfReferableFlag_False')]/label[contains(text(),'No')]");
        public static By selfReferableNoBtn = By.XPath(".//*[@id=\"IsWaitlistRequiredGroup\"]/span[2]/label");///span[2]/label");//(".//div[contains(@id,'VisibleByPrionserFlagGroup')]/span[contains(@id, 'SelfReferableFlag_False')]/label"); 
        public static By cancelBtn = By.Id("btnCancelActivity");
        public static By saveBtn = By.Id("btnSaveActivity");
        public static By errors = By.XPath(".//*[@id='errors']/ul/li");


        public enum FormTextRequired
        {
            ActivityTitle,
            ActivityShortName,
            Department,
            ActivityType,
            ActivityCategory,
            ServiceProvider,
            WaitlistRequired,
            AttendanceRequired,
            MaximumParticipants,
            ActiveFromDate
        }

        public static string fieldValueDefault(IWebDriver driver, string fieldName)
        {
            switch (fieldName)
            {
                case "ActiveFromDate":
                    return driver.FindElement(By.Id("ActiveFromDate")).GetAttribute("value");
                case "ActiveToDate":
                    return driver.FindElement(By.Id("ActiveToDate")).GetAttribute("value");
                case "PurposefullFromDate":
                    return driver.FindElement(By.Id("PurposefulFromDate")).GetAttribute("value");
                case "PurposeToDate":
                    return driver.FindElement(By.Id("PurposefulToDate")).GetAttribute("value");

                // Radio buttons
                // Waitlist required No radio button
                case "WaitListRequiredNo":
                    return driver.FindElement(By.Id("IsWaitlistRequired_False")).GetAttribute("value");

                // Waitlist required Yes radio button
                case "WaitListRequiredYes":
                    driver.FindElement(By.Id("IsWaitlistRequired_True")).Click();
                    return driver.FindElement(By.Id("IsWaitlistRequired_True")).GetAttribute("value");

                // Attendence required No radio button
                case "AttendanceRequiredNo":
                    return driver.FindElement(By.Id("IsAttendanceRequired_False")).GetAttribute("value");

                // Attendence required Yes radio button
                case "AttendanceRequiredYes":
                    return driver.FindElement(By.Id("IsAttendanceRequired_True")).GetAttribute("value");
                default:
                    return "";
            }
        }

    }
}
  