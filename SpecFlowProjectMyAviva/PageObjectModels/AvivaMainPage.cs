using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SpecFlowProjectMyAviva.PageObjectModels
{
    public class AvivaMainPage
    {
        private const string webPageAddress = "https://www.aviva.com/";

        private readonly IWebDriver driver;

        public AvivaMainPage(IWebDriver webdriver)
        {
            driver = webdriver;
        }

        #region WebElement       
        private IWebElement cookiesAcceptAllButtonSelector => driver.FindElement(By.XPath("//*[@id='onetrust-accept-btn-handler']"));
        private IWebElement buttonMASelector => driver.FindElement(By.XPath("//li[@class='o-masthead__login-link']//*[text()='MyAviva']"));
        #endregion

        #region Actions
         public void clickButtonMA()
        {
            buttonMASelector.Click();
        }

        public void cookiesAcceptAllButtonVisibleClick()
        {
            bool isElementDisplayed = cookiesAcceptAllButtonSelector.Displayed;
            if (isElementDisplayed == true)
            {
                cookiesAcceptAllButtonSelector.Click();
            }
        }

        public void OpenWPage()
        {
            driver.Navigate().GoToUrl(webPageAddress);
        }

        public string GetPageName()
        {
            string PageTitle = driver.Title;
            return PageTitle;
        }
        #endregion
    }
}
