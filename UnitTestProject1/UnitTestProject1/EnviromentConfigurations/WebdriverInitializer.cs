using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using System.Threading;

namespace UnitTestProject1.EnviromentConfigurations
{
    [TestFixture("ie")]
    [TestFixture("chrome")]
    [TestFixture("firefox")]//,"Windows")]
    [Parallelizable(ParallelScope.Fixtures)]
    public class WebdriverInitializer
    {
        public static IWebDriver driver;
        public String browser;
        public static DesiredCapabilities capabilities;
       
        // private String version;
        //// private String os;
        // private String deviceName;
        // private String deviceOrientation;

        public WebdriverInitializer(String browser) //,  String os) //, String version, String deviceName, String deviceOrientation)
        {
            this.browser = browser;
            //this.os = os;
            //this.version = version;

            //this.deviceName = deviceName;
            //this.deviceOrientation = deviceOrientation;
        }

        
        [SetUp]
        public void Init()
        {


            if (browser.Contains("chrome"))
            {
                capabilities = DesiredCapabilities.Chrome();
             // capabilities.SetCapability("chrome.binary", "C:\\chrome\\chromedriver.exe");
                capabilities.SetCapability("chrome.binary", "C:\\Users\\2712\\Documents\\Visual Studio 2015\\Projects\\UnitTestProject1\\UnitTestProject1\\bin\\Debug\\chromedriver.exe");

            }

            if (browser.Contains("firefox"))
            {
                capabilities = DesiredCapabilities.Firefox();
                capabilities.SetCapability("firefox.binary", "C:\\Users\\2712\\Documents\\Visual Studio 2015\\Projects\\UnitTestProject1\\UnitTestProject1\\bin\\Debug\\firefoxdriver.exe");

            }

            if (browser.Contains("ie"))
            {
                capabilities = DesiredCapabilities.InternetExplorer();
                capabilities.SetCapability("ie.binary", "C:\\Users\\2712\\Documents\\Visual Studio 2015\\Projects\\UnitTestProject1\\UnitTestProject1\\bin\\Debug\\IEdriver.exe");

            }
            capabilities.SetCapability("name", String.Format("{0}:{1}: [{2}]", TestContext.CurrentContext.Test.ClassName, TestContext.CurrentContext.Test.MethodName, TestContext.CurrentContext.Test.Properties.Get("Description")));
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities, TimeSpan.FromSeconds(600)); 
            driver.Navigate().GoToUrl("https://sys3-gw.geo.test.dialog.com.au/Gateway/");
            driver.Manage().Window.Maximize();
            
            //  DesiredCapabilities capabilities = new DesiredCapabilities();
            //  capabilities.SetCapability(CapabilityType.BrowserName, browser);
            //caps.SetCapability(CapabilityType.Version, version);
            //   caps.SetCapability(CapabilityType.Platform, os);
            //  caps.SetCapability("deviceName", deviceName);
            //  caps.SetCapability("deviceOrientation", deviceOrientation);
            //  caps.SetCapability("username", Constants.SAUCE_LABS_ACCOUNT_NAME);
            //  caps.SetCapability("accessKey", Constants.SAUCE_LABS_ACCOUNT_KEY);
            //  caps.SetCapability("name", TestContext.CurrentContext.Test.Name);
            //  driver = new RemoteWebDriver(new Uri("http://localhost:5555/wd/hub"), capabilities, TimeSpan.FromSeconds(600));

        }


        [TearDown]
        public void CleanUp()
        {

            bool passed = TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Passed;
            try
            {
                if (passed == true)
                {
                    Console.WriteLine("Test results" + passed);
                }
                else
                {
                    Console.WriteLine("Test results " + TestContext.CurrentContext.Test.FullName);
                }
            }
            finally
            {
                Thread.Sleep(5000);
                driver.Quit();
            }
        }
    }
}
