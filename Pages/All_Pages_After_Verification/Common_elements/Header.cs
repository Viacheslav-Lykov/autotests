using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages

{
    public class Header : BasePage 
    {
        public Header(IWebDriver driver) : base(driver) { }

        #region Locators
        By refillAccountBtnLocator = By.CssSelector(".purchase.option button.open-purchase.button.popup-trigger");
        By upgradeAccountBtnLocator = By.CssSelector(".subscribe.option button.open-purchase.button.popup-trigger");
        #endregion

        #region Methods

        public bool RefillAccountBtnDisplyed()
        {
            return new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(refillAccountBtnLocator).Displayed);
            
        }

        public bool UpgradeAccountBtnDisplyed()
        {
            return new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(upgradeAccountBtnLocator).Displayed);

        }
        #endregion
    }
}