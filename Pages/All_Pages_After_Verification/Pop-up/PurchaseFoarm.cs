using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages
{
    public class PurchaseFoarm : BasePage
    {
        public PurchaseFoarm(IWebDriver driver) : base(driver) { }

        #region Locators

        By cardNumberFieldLocator = By.CssSelector("[class='field-wrapper indicator-payment-system'] [name='number']");
        By mountOfCardLocator = By.CssSelector("[class='react-customized-select data month'] [name='month'] [value='4']");
        By yearOfCardLocator = By.CssSelector("[class='react-customized-select data year'] [name='year'] [value='2022']");
        By cvvCardFieldLocator = By.CssSelector("[class='card-cvv'] [name='verification']");
        By nameOnCardLocator = By.CssSelector("[class='card-holder row'] [name='cardholder']");
        By purchaseCreditsOnPurchaseFoarmBtnLocator = By.CssSelector("[class='action purchase medium big']");


        #endregion

        #region Methods

        public PurchaseFoarm TypeRandowStringToCardNumberField(string CardNumber = null)
        {
            Random rnd = new Random();

            int random_index = rnd.Next(1000, 9999);

            if (CardNumber == null)
                CardNumber = "458563212525" + random_index;


            new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(cardNumberFieldLocator)).SendKeys(CardNumber);

            return this;
        }

        public PurchaseFoarm SelectMounthOfCard()
        {
            new WebDriverWait(driver, timeToWait)
              .Until(d => d.FindElement(mountOfCardLocator)).Click();

            return this;
        }

        public PurchaseFoarm SelectYearOfCard()
        {
            new WebDriverWait(driver, timeToWait)
              .Until(d => d.FindElement(yearOfCardLocator)).Click();

            return this;
        }

        public PurchaseFoarm TypeRandowStringToCvvCardField(string CvvNumber = null)
        {
            Random rnd = new Random();

            int random_index = rnd.Next(11, 99);

            if (CvvNumber == null)
                CvvNumber = "5" + random_index;


            new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(cvvCardFieldLocator)).SendKeys(CvvNumber);

            return this;
        }

        public PurchaseFoarm TypeRandowStringToNameOnCardField(string NameOnCard = null)
        {
            Random rnd = new Random();

            int random_index = rnd.Next(11, 99);

            if (NameOnCard == null)
                NameOnCard = "Test Anon" + random_index;


            new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(nameOnCardLocator)).SendKeys(NameOnCard);

            return this;
        }
        public PurchaseFoarm ClickPurchaseCreditsOnPurchaseFoarmBtn()
        {
            new WebDriverWait(driver, timeToWait)
              .Until(d => d.FindElement(purchaseCreditsOnPurchaseFoarmBtnLocator)).Click();

            return this;
        }

        #endregion
    }
}