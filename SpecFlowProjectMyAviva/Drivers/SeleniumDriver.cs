using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace SpecFlowProjectMyAviva.Drivers
{
    public class SeleniumDriver
    {
        private readonly Lazy<IWebDriver> driverLazy;
        public SeleniumDriver()
        {
            driverLazy = new Lazy<IWebDriver>(CreateWebDriver);
        }

        public IWebDriver Current => driverLazy.Value;

       public IWebDriver CreateWebDriver()
        {
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            //options.AddArgument("--headless");
            //options.AddArgument("--disable-gpu");

            var driver = new ChromeDriver(chromeDriverService, options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            return driver;
        }
    }
}
