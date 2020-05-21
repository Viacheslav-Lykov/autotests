using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages

{
    public class Notifications : BasePage
    {
        public Notifications(IWebDriver driver) : base(driver) { }

        #region Locators
        By youHavePurchased20CreditsSystemMessageInfoLocator = By.CssSelector("[class='for-devaluation-disabled']");

        #endregion

        #region Methods

        public bool YouHavePurchased20CreditsSystemMessageInfoDisplyed()
        {
            return new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(youHavePurchased20CreditsSystemMessageInfoLocator).Displayed);

        }
       
        #endregion
    }
}