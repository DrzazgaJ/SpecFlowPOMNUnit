using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProjectMyAviva.Drivers;
using SpecFlowProjectMyAviva.PageObjectModels;

namespace SpecFlowProjectMyAviva.StepDefinitions
{
    [Binding]
    public sealed class MyAvivaButtonDefinitions
    {

        private readonly AvivaMainPage avMP;
 
        public MyAvivaButtonDefinitions(SeleniumDriver seleniumDriver)
        {
            avMP = new AvivaMainPage(seleniumDriver.Current);
        }
        

        [Given(@"I am on Aviva page")]
        public void GivenIAmOnAvivaPage()
        {

            string nazwastr = avMP.GetPageName();
            Assert.AreEqual("Aviva corporate website - Aviva plc", nazwastr); 
            
        }

        [When(@"Accept Cookies popup appears it is accepted")]
        public void WhenAcceptCookiesPopupAppearsItIsAccepted()
        {
             avMP.cookiesAcceptAllButtonVisibleClick();
        }

        [When(@"I click MyAviva button")]
        public void WhenIClickMyAvivaButton()
        {
           avMP.clickButtonMA();
        }

        [Then(@"I should land on MyAviva page")]
        public void ThenIShouldLandOnMyAvivaPage()
        {
            Assert.AreEqual("MyAviva - Aviva plc", avMP.GetPageName());
        }

    }
}