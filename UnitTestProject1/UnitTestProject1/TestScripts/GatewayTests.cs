using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Actions;
using UnitTestProject1.EnviromentConfigurations;
using NUnit.Framework;
using System.Threading;
using UnitTestProject1.ObjectRepository;


namespace UnitTestProject1.TestScripts
{
    public class GatewayTests : WebdriverInitializer
    {
        public GatewayTests(string browser) : base(browser)
        {
        }

      

        [Test]
        public void CreateActivity()
        {
            GatewayActions.Login("GPOS_test1", "F7grw_$h1234_Fe");
            Thread.Sleep(3000);
            GatewayActions.NavigateToActivityManagement();
            Thread.Sleep(3000);
            string activityname = "Activity1" + System.DateTime.Now;
            GatewayActions.CreateActivity(activityname, "CreateActivityShortName1");
            // GatewayActions.selectdepartment("Offender Development");
            // GatewayActions.selectActivityType("Work");
            //GatewayActions.selectActivityCategory("Employment");
            //GatewayActions.EnterServiceProvider("ABC");
            GatewayActions.selectWaitListYes();
            // GatewayActions.selectWaitListNo();
            //GatewayActions.selectWaitListYes();
            // GatewayActions.attendanceRequiredYes();
            //GatewayActions.radioButtonsClick("attendanceRequiredNo");
            // GatewayActions.attendanceRequiredNo();
            // GatewayActions.VerifyMaximumRequired();
            //  GatewayActions.VerifyMaximumParticipantErrorMsg();
            //GatewayActions.MaximumParticipantsIncreaseBtn();
            //GatewayActions.MaximumParticipantsIncreaseBtn();
            //GatewayActions.MaximumParticipantsIncreaseBtn();
            //GatewayActions.MaximumParticipantsDecreaseBtn();

            GatewayActions.VerifyMaximumParticipantMsg();
            GatewayActions.ActivateDateFrom();
            GatewayActions.VerifyMaximumParticipantErrorMsg();
            GatewayActions.ActivateDateTo();
            CommonActions.ScrollDown();
            Console.WriteLine("scroll bar");
            Thread.Sleep(5000);
            GatewayActions.ClickVisibleByPrisionersNoBtn();
            Console.WriteLine("ClickVisibleByPrisionersNoBtn");
            string waitListRequired = Convert.ToString(GatewayPageObjects.FormTextRequired.WaitlistRequired);//.fieldValueDefault(GatewayPageObjects.FormTextRequired.WaitlistRequired);
            GatewayActions.purposefulFromDate();
            GatewayActions.purposefulToDate();
            GatewayActions.VerifyPurposefulActivitiesMsg();
            Console.WriteLine("Purposeful activitiesMsg verified");
            // GatewayActions.ClickSelfReferableNoBtn();
         //   GatewayActions.ClickSaveActivityBtn();
         //   CommonActions.ScrollUp();
            GatewayActions.captureErrors();

        }


        [Test]
        public void SearchActivity()
        {
            GatewayActions.Login("GPOS_test1", "F7grw_$h1234_Fe");
            Thread.Sleep(3000);
            GatewayActions.NavigateToActivityManagement();
            ActivityListActions.SearchActivity("-123456789");
            ActivityListActions.SelectDepartment();
            ActivityListActions.SearchActivity();
        }
    }
}
