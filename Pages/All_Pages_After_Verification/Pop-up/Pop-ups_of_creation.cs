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
        By sexIAmAonAboutYouFormMaleLocator = By.CssSelector(".gender .icon.mal");
        By sexSeekingAonAboutYouFormFemaleLocator = By.CssSelector(".preferred-gender .icon.fem");
        By nameOrNicknameFieldLocator = By.CssSelector("[class='field-wrapper name field invalid invalid-required'] [name='name']");
        
        By mounthonAboutYouFormLocator = By.CssSelector(".customized-select [name='month'] [value='4']");
        By dayonAboutYouFormlocator = By.CssSelector(".customized-select [name='day'] [value='19']");
        By yearonAboutYouFormLocator = By.CssSelector(".customized-select [name='year'] [value='1995']");

        By nextBtnonAboutYouLocator = By.CssSelector(".big.approve.button.normal");
        By nextBtnonSomeInterestingDetailsAboutYouuLocator = By.CssSelector(".complete-button-section .approve.big.button");
        By nextBtnonAboutYourIdealPartnerLocator = By.CssSelector(".complete-button-section .approve.big.button");
        By nextBtnonYourInterestsLocator = By.CssSelector(".complete-button-section .bit.approve.button");
        By completeBtnonAddPhotoGetNoticedLocator = By.CssSelector(".complete-button-section .big.approve.button"); 

        #endregion

        #region Methods

        public Windows_of_creation ClickSexIAmAonAboutYouFormMale()
        {
            new WebDriverWait(driver, timeToWait)

                .Until(d => d.FindElement(sexIAmAonAboutYouFormMaleLocator)).Click();

            return this;

        }

        public Windows_of_creation ClickSexSeekingAonAboutYouFormFemale()
        {
            new WebDriverWait(driver, timeToWait)
              .Until(d => d.FindElement(sexSeekingAonAboutYouFormFemaleLocator)).Click();

            return this;
        }

        public Windows_of_creation SelectMounthonAboutYouForm()
        {
            new WebDriverWait(driver, timeToWait)
              .Until(d => d.FindElement(mounthonAboutYouFormLocator)).Click();

            return this;
        }

        public Windows_of_creation SelectDayonAboutYouForm()
        {
            new WebDriverWait(driver, timeToWait)
              .Until(d => d.FindElement(dayonAboutYouFormlocator)).Click();

            return this;
        }

        public Windows_of_creation SelectYearonAboutYouForm()
        {
            new WebDriverWait(driver, timeToWait)
              .Until(d => d.FindElement(yearonAboutYouFormLocator)).Click();

            return this;
        }

        public Windows_of_creation ClickNextBtnonAboutYou()
        {
            new WebDriverWait(driver, timeToWait)
              .Until(d => d.FindElement(nextBtnonAboutYouLocator)).Click();

            return this;
        }

        public Windows_of_creation ClickNextBtnonSomeInterestingDetailsAboutYou()
        {
            new WebDriverWait(driver, timeToWait)
              .Until(d => d.FindElement(nextBtnonSomeInterestingDetailsAboutYouuLocator)).Click();

            return this;
        }

        public Windows_of_creation ClickNextBtnonAboutYourIdealPartner()
        {
            new WebDriverWait(driver, timeToWait)
              .Until(d => d.FindElement(nextBtnonAboutYourIdealPartnerLocator)).Click();

            return this;
        }

        public Windows_of_creation ClickNextBtnonYourInterests()
        {
            new WebDriverWait(driver, timeToWait)
              .Until(d => d.FindElement(nextBtnonYourInterestsLocator)).Click();

            return this;
        }

        public Windows_of_creation ClickCompleteBtnonAddPhotoGetNoticed()
        {
            new WebDriverWait(driver, timeToWait)
              .Until(d => d.FindElement(completeBtnonAddPhotoGetNoticedLocator)).Click();

            return this;
        }



        #endregion
    }
}
