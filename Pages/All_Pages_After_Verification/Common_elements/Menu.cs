using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages

{
    public class Menu : BasePage
    {
        public Menu(IWebDriver driver) : base(driver) { }

        #region Locators
        
        By menuSandwithBtnLocator = By.CssSelector("[class='popup-container'] [class='popup-trigger popup-control links']");
        By myProfileInMenuBtnLocator = By.CssSelector("[class='popup top'] [url='/texts/header/menu#profile']");

        #endregion

        #region Methods

        public Menu ClickMenuSandwithBtn()
        {
            new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(menuSandwithBtnLocator)).Click();

            return this;
        }

        public Menu ClickMyProfileInMenuBtn()
        {
            new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(myProfileInMenuBtnLocator)).Click();

            return this;
        }
        #endregion
    }
}