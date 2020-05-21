using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages

{
    public class OwnProfile : BasePage
    {
        public OwnProfile(IWebDriver driver) : base(driver) { }

        #region Locators
                
        By valueOfCreditsLocator = By.CssSelector("[class='button shady small credits-refill high'] [class='amount credits-amount']");
        #endregion

        #region Methods

        public string takeValueOfCredits()
        {
            return new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(valueOfCreditsLocator)).Text;
        }

        #endregion
    }
}