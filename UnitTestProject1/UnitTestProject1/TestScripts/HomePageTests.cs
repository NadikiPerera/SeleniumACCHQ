using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestProject1.Actions;
using UnitTestProject1.EnviromentConfigurations;

namespace UnitTestProject1.TestScripts
{
    
    public class HomePageTests : WebdriverInitializer
    {
        public HomePageTests(string browser) : base(browser)
        {

        }

        [Test]
        public void BookATrip()
        {
            HomePageActions.SelectFromCity();
            HomePageActions.SelectToCity("Colombo");
            HomePageActions.SelectDepartDate();
            HomePageActions.SelectReturnDate();


        }


    }
}
