using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProjectMyAviva.Drivers;
using SpecFlowProjectMyAviva.PageObjectModels;
using SpecFlowProjectMyAviva.StepDefinitions;
using TechTalk.SpecFlow;

namespace SpecFlowProjectMyAviva.Hooks
{
    [Binding]
    public class HookInitialization
    {
        [BeforeScenario]
        public void BeforeScenario(SeleniumDriver seleniumDriver)
        {
             var avivaMainPage = new AvivaMainPage(seleniumDriver.Current);
            avivaMainPage.OpenWPage();
        }

        [AfterScenario]
        public void AfterScenario(SeleniumDriver seleniumDriver)
        {
            seleniumDriver.Current.Quit();
        }
    }
}