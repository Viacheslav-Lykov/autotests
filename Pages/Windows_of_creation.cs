using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages

{
    public class Windows_of_creation : BasePage
    {
        public Windows_of_creation(IWebDriver driver) : base(driver) { }

        #region Locators
        By refillAccountBtnLocator = By.CssSelector(".purchase.option button.open-purchase.button.popup-trigger");
        #endregion

        #region Methods

        public bool refillAccountBtnDisplyed()
        {
            return new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(refillAccountBtnLocator).Displayed);

        }
        #endregion
    }
}
