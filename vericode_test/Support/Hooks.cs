using Allure.Net.Commons;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace vericode_test.Support
{
    [Binding]
    public sealed class Hooks
    {
        public static IWebDriver driver;
        public static CookieCollection cookie;
        public static Helpers help = new Helpers();
        public static Random random = new Random();
        public static AllureLifecycle allure = AllureLifecycle.Instance;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            allure.CleanupResultDirectory();
        }

        [BeforeScenario]
        public static void BeforeScenario(FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            bool headless = false;
            if (driver == null)
            {
                ChromeOptions options = new ChromeOptions();
                if (headless == true)
                {
                    options.AddArguments("--headless");
                    options.AddArguments("--no-sandbox");
                    options.AddArguments("--disable-dev-shm-usage");
                    options.AddArguments("--window-size=1400,1400");
                    options.AddArguments("--incognito");
                }
                else
                {
                    options.AddArguments("--incognito");
                    options.AddArguments("--ignore-certificate-errors");
                    options.AddArguments("--ignore-certificate-errors-spki-list");
                    options.AddArguments("--ignore-ssl-errors");
                    options.AddArguments("log-level=3");
                }
                driver = new ChromeDriver(options);//(Directory.GetCurrentDirectory()+ "/ChromeDiver");
            }
            else
            {
                throw new Exception("Couldn't initialize the driver");
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
        }
        
        [AfterScenario]
        public static void AfterScenario(FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            if (scenarioContext.TestError != null)
            {
                help.take_screenshot();
            }
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            driver.Quit();
        }
    }
}
