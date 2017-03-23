//using NUnit.Framework;
//using System;
//using System.Web;
//using System.Text;
//using System.Net;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Remote;
//using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.IE;
//using OpenQA.Selenium.Firefox;
//using System.Collections.Generic;

//namespace UnitTestProject1
//{
//    [TestFixture("ie")]
//    [TestFixture("chrome")]
//    [TestFixture("firefox")]//,"Windows")]
//    [Parallelizable(ParallelScope.Fixtures)]
//    public class UnitTest1
//    {
//        private IWebDriver driver;
//        private String browser;
//        DesiredCapabilities capabilities;
//        // private String version;
//        //// private String os;
//        // private String deviceName;
//        // private String deviceOrientation;

//        public UnitTest1(String browser) //,  String os) //, String version, String deviceName, String deviceOrientation)
//        {
//            this.browser = browser;
//             //this.os = os;
//            //this.version = version;

//            //this.deviceName = deviceName;
//            //this.deviceOrientation = deviceOrientation;
//        }

//        public void BrowserFileBookATrip(String browser)
//        {
//            if (browser.Equals("Chrome"))
//            {
//                driver = new ChromeDriver();
//                //baseState.Execute();
//            }

//            else
//            {
//                if (browser.Equals("Firefox"))
//                {
//                    driver = new FirefoxDriver();
//                    // baseState.Execute();
//                }

//                else
//                {
//                    if (browser.Equals("ie"))
//                    {
//                        driver = new InternetExplorerDriver();
//                    }

//                }
//            }


//        }

//        public static IEnumerable<String> BrowsersType()
//        {

//            String[] browsers = UnitTestProject1.BrowserSettings.browserType.Split(',');

//            foreach (String b in browsers)
//            {
//                yield return b;

//            }

//        }


//        [SetUp]
//        public void Init()
//        {

            
//            if (browser.Contains("chrome"))
//            {
//                capabilities = DesiredCapabilities.Chrome();
//                capabilities.SetCapability("chrome.binary", "C:\\Users\\2712\\Documents\\Visual Studio 2015\\Projects\\UnitTestProject1\\UnitTestProject1\\bin\\Debug\\chromedriver.exe");
               
//            }

//            if (browser.Contains("firefox"))
//            {
//                capabilities = DesiredCapabilities.Firefox();
//                capabilities.SetCapability("firefox.binary", "C:\\Users\\2712\\Documents\\Visual Studio 2015\\Projects\\UnitTestProject1\\UnitTestProject1\\bin\\Debug\\firefoxdriver.exe");
                
//            }

//            if (browser.Contains("ie"))
//            {
//                capabilities = DesiredCapabilities.InternetExplorer();
//                capabilities.SetCapability("ie.binary", "C:\\Users\\2712\\Documents\\Visual Studio 2015\\Projects\\UnitTestProject1\\UnitTestProject1\\bin\\Debug\\IEdriver.exe");
                
//            }
//            capabilities.SetCapability("name", String.Format("{0}:{1}: [{2}]", TestContext.CurrentContext.Test.ClassName, TestContext.CurrentContext.Test.MethodName, TestContext.CurrentContext.Test.Properties.Get("Description")));
//            driver = new RemoteWebDriver(new Uri("http://localhost:5555/wd/hub"), capabilities, TimeSpan.FromSeconds(600));
//            driver.Manage().Window.Maximize();

           
//            //  DesiredCapabilities capabilities = new DesiredCapabilities();
//            //  capabilities.SetCapability(CapabilityType.BrowserName, browser);
//            //caps.SetCapability(CapabilityType.Version, version);
//            //   caps.SetCapability(CapabilityType.Platform, os);
//            //  caps.SetCapability("deviceName", deviceName);
//            //  caps.SetCapability("deviceOrientation", deviceOrientation);
//            //  caps.SetCapability("username", Constants.SAUCE_LABS_ACCOUNT_NAME);
//            //  caps.SetCapability("accessKey", Constants.SAUCE_LABS_ACCOUNT_KEY);
//            //  caps.SetCapability("name", TestContext.CurrentContext.Test.Name);
//            //  driver = new RemoteWebDriver(new Uri("http://localhost:5555/wd/hub"), capabilities, TimeSpan.FromSeconds(600));

//        }

//        [Test]   
//        public void googleTest()
//        {
//           // BrowserFileBookATrip(browsername);
//            driver.Navigate().GoToUrl("https://www.qantas.com/au/en.html");
////            StringAssert.Contains("Google", driver.Title);
//            IWebElement query = driver.FindElement(By.Name("param[homevalue]"));
//            query.Clear();
//            query.SendKeys("600000");
//           // driver.FindElement(By.Name("param[homevalue]"))
//        }

//        [TearDown]
//        public void CleanUp() {

//            bool passed = TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Passed;
//            try
//            {
//                if (passed == true)
//                {
//                    Console.WriteLine("Test results" + passed);
//                }
//                else
//                {
//                    Console.WriteLine("Test results " + TestContext.CurrentContext.Test.Name);
//                }
//            }
//            finally
//            {
              
//                driver.Quit();
//            }
//        }
//    }
//}