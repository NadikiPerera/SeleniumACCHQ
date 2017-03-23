using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ObjectRepository;
using UnitTestProject1.EnviromentConfigurations;
using System.Threading;
using OpenQA.Selenium;
using NUnit.Framework;


namespace UnitTestProject1.Actions
{
    public class GatewayActions:WebdriverInitializer
    {
        public GatewayActions(string browser) : base(browser)
        {
        }

        public static void Login(string userName, string password)
        {

            driver.FindElement(GatewayPageObjects.loginUserName).SendKeys(userName); 
            driver.FindElement(GatewayPageObjects.password).SendKeys(password); 
            driver.FindElement(GatewayPageObjects.acceptTermsConditionsCheckBox).Click();
            driver.FindElement(GatewayPageObjects.loginBtn).Click();
        }

        public static void NavigateToActivityManagement()
        {
            driver.FindElement(GatewayPageObjects.activityRoutineManagementLink).Click();
            Thread.Sleep(3000);
            driver.FindElement(GatewayPageObjects.activityManagement).Click();

        }

        public static void CreateActivity(string activityTitle, string activityShortName)
        {
            driver.FindElement(GatewayPageObjects.CreateActivityBtn).Click();
            driver.FindElement(GatewayPageObjects.createProgramID).Click();
            driver.FindElement(GatewayPageObjects.activityTitle).SendKeys(activityTitle);
            driver.FindElement(GatewayPageObjects.activityShortName).SendKeys(activityShortName);
           // driver.FindElement(GatewayPageObjects.department).Click();
            //Thread.Sleep(3000);
           // driver.FindElement(GatewayPageObjects.contractComplianceListItem).Click();


        }

        public static void selectdepartment(string departmentName)
        {
            Thread.Sleep(2000);
            driver.FindElement(GatewayPageObjects.departmentdropdownArrow).Click(); 
            Thread.Sleep(2000);
            bool result = driver.FindElement(By.XPath("//li[text()='" + departmentName + "']")).Displayed;
           Assert.AreEqual(true,result, "Department is displayed");
            driver.FindElement(By.XPath("//li[text()='"+ departmentName+"']")).Click();
            
        }

        public static void selectActivityType(string activityType)
        {
            Thread.Sleep(2000);
            driver.FindElement(GatewayPageObjects.activityTypedropdownArrow).Click(); 
            Thread.Sleep(2000);
            bool result = driver.FindElement(By.XPath("//li[text()='" + activityType + "']")).Displayed;
            Assert.AreEqual(true, result, "Activity Type is displayed");
            driver.FindElement(By.XPath("//li[text()='" + activityType + "']")).Click();

        }

        public static void selectActivityCategory(string activityCategory)
        {
            Thread.Sleep(2000);
            driver.FindElement(GatewayPageObjects.activityCategorydropdownArrow).Click(); 
            Thread.Sleep(2000);
            bool result = driver.FindElement(By.XPath("//li[text()='" + activityCategory + "']")).Displayed;
            Assert.AreEqual(true, result, "Activity Category is displayed");
            driver.FindElement(By.XPath("//li[text()='" + activityCategory + "']")).Click();

        }

        public static void EnterServiceProvider(string serviceProvider)
        {
            Thread.Sleep(2000);
            driver.FindElement(GatewayPageObjects.serviceProvidersTextField).SendKeys(serviceProvider); 
            
        }


        public static void selectWaitListYes()
        {
            Thread.Sleep(2000);
            driver.FindElement(GatewayPageObjects.waitlistRadioBtnYes).Click(); 

        }

        public static void selectWaitListNo()
        {
            Thread.Sleep(2000);
            driver.FindElement(GatewayPageObjects.waitlistRadioBtnNo).Click(); 

        }

        public static void attendanceRequiredYes()
        {
            Thread.Sleep(2000);
            driver.FindElement(GatewayPageObjects.attendanceRequiredYesBtn).Click(); 

        }

        public static void attendanceRequiredNo()
        {
            Thread.Sleep(2000);
            driver.FindElement(GatewayPageObjects.attendanceRequiredNoBtn).Click(); 

        }

        public static void MaximumParticipantsIncreaseBtn()
        {
            Thread.Sleep(2000);
            driver.FindElement(GatewayPageObjects.maximumParticipantsIncreaseBtn).Click(); 

        }

        public static void MaximumParticipantsDecreaseBtn()
        {
            Thread.Sleep(2000);
            driver.FindElement(GatewayPageObjects.maximumParticipantsDecreaseBtn).Click(); 

        }

        public static void VerifyMaximumRequired()
        {
            Thread.Sleep(2000);
            string result=driver.FindElement(GatewayPageObjects.maximumParticipantsRequired).Text; 
            Assert.AreEqual("Required", result);
        }

        public static void VerifyMaximumParticipantErrorMsg()
        {
            Thread.Sleep(2000);
            string result = driver.FindElement(GatewayPageObjects.maximumParticipantErrorMsg).Text;
            Console.WriteLine(result);
            Assert.AreEqual("Maximum Participants must be specified.", result, "Maximum Participants must be specified.");
            Console.WriteLine("Maximum Participants must be specified.");

        }

        public static void VerifyMaximumParticipantMsg()
        {
            driver.FindElement(GatewayPageObjects.maximumParticipantTextField).Click();
            string results = driver.FindElement(GatewayPageObjects.maximumParticipantMsg).Text;
            Assert.AreEqual("Maximum Participants of 0 means unlimited participants.", results);
        }

        public static void ActivateDateFrom()
        {
            driver.FindElement(GatewayPageObjects.activeFromDate).Click();
            driver.FindElement(GatewayPageObjects.activeFromDate).Clear();
            driver.FindElement(GatewayPageObjects.activeFromDate).SendKeys("02/01/2017");
        }

        public static void ActivateDateTo()
        {
            driver.FindElement(GatewayPageObjects.activeTodate).Click();
            driver.FindElement(GatewayPageObjects.activeTodate).Clear();
            driver.FindElement(GatewayPageObjects.activeTodate).SendKeys("02/11/2017");
            string results = driver.FindElement(GatewayPageObjects.activeActivitiesMsg).Text;
            Assert.AreEqual("Leave blank for always active Activities.", results,  "Leave blank for always active Activities.");
            Console.WriteLine("Leave blank for always active Activities.");
        }

        public static void ClickVisibleByPrisionersNoBtn()
        {
            driver.FindElement(GatewayPageObjects.visibleByPrisionersFlagNoBtn).Click();
        }

        public enum radioButtons
        {
            waitlistRadioBtnYes,
            waitListRequiredNo,
            attendancerequiredYes,
            attendanceRequiredNo,
            
        }

        public static void radioButtonsClick(string buttonName)
        {
          switch(buttonName)
            {
                case "waitListRequiredYes":
                    driver.FindElement(GatewayPageObjects.waitlistRadioBtnYes).Click();
                    break;

                case "waitListRequiredNo":
                     driver.FindElement(GatewayPageObjects.waitlistRadioBtnNo).Click();
                    break;

                case "attendancerequiredYes":
                    driver.FindElement(GatewayPageObjects.attendanceRequiredYesBtn).Click();
                    break;

                case "attendanceRequiredNo":
                    driver.FindElement(GatewayPageObjects.attendanceRequiredNoBtn).Click();
                    break;

            }
        }

        public static void purposefulFromDate()
        {
            driver.FindElement(GatewayPageObjects.purposefulFromDate).Clear();
            driver.FindElement(GatewayPageObjects.purposefulFromDate).SendKeys("06/05/2017");

        }

        public static void purposefulToDate()
        {
            driver.FindElement(GatewayPageObjects.purposefulToDate).Clear();
            driver.FindElement(GatewayPageObjects.purposefulToDate).SendKeys("06/09/2017");

        }

        public static void VerifyPurposefulActivitiesMsg()
        {
            string results=driver.FindElement(GatewayPageObjects.purposefulActivitiesMsg).Text;
            Assert.AreEqual("Leave blank for always purposeful Activities.", results, "Purposeful activitiesMsg verified");
        }

        public static void ClickSelfReferableNoBtn()
        {
            driver.FindElement(GatewayPageObjects.selfReferableNoBtn).Click();
        }

        public static void ClickSaveActivityBtn()
        {
            driver.FindElement(GatewayPageObjects.saveBtn).Click();
        }

        public static void ClickCancelActivityBtn()
        {
            driver.FindElement(GatewayPageObjects.cancelBtn).Click();
        }

        public static void captureErrors()
        {
            string[] errorMsgs = new string[] { "Activity Title must be specified.",
                                                "Activity Short Name must be specified.",
                                                "Department must be specified.",
                                                 "At least one Service Provider must be specified.",
                                                "Waitlist Required? must be specified.",
                                                "Attendance Required? must be specified.",
                                                "Maximum Participants must be specified."};


            //String[] results = new String[] { driver.FindElements(GatewayPageObjects.errors).Any(span => span.Text.Contains(errorMsgs[i])).ToString() };
            //Console.WriteLine("string array results" + results.ToString());
            IList<IWebElement> list = driver.FindElements(GatewayPageObjects.errors);
            list.ToArray();

            for (int i = 0; i < +errorMsgs.Length; i++)
            {

                if (list.ToArray().Any(span => span.Text.Contains(errorMsgs[i])))
                {
                    Console.WriteLine("This Error displayed--->" + errorMsgs[i]);
                }

                //else
                //{
                //    Console.WriteLine("This Error is not displayed-->" + errorMsgs[i]);
                //}

            }


        }
    }
}
