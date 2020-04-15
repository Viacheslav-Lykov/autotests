using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver) { }

        #region Locators
        By signInWithEmailBtnLocator = By.CssSelector(".action.default.medium.default.action");
        #endregion

        #region Methods
        public SignInWithEmailForm ClickSignInWithEmailBtn()
        {
            new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(signInWithEmailBtnLocator)).Click();

            return new SignInWithEmailForm(driver);
        }
        #endregion
    }

    public class SignInWithEmailForm : BasePage
    {
        public SignInWithEmailForm(IWebDriver driver) : base(driver) { }

        #region Locators
        By signInBtnLocator = By.CssSelector("#popup-auth-form-container button.action.call-to-action.medium");
        By invalidEmailTextOnSignInFormLocator = By.CssSelector(".data.invalid[name='email'] + .error-notification");
        By invalidPasswordTextOnSignInFormLocator = By.CssSelector(".data.has-link.invalid[name='password'] + .error-notification");
        By createYourAccountBtnLocator = By.CssSelector(".authorization.react-form.sign-in .pseudo-link.sign-up");

        //my added locators

        By yourEmailFieldLocator = By.CssSelector("[name='authorization'] [name='email']");
        By passwordFieldLocator = By.CssSelector("[name='authorization'] [name='password']");
        #endregion

        #region Methods
        public SignInWithEmailForm ClickSignInBtn()
        {
            new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(signInBtnLocator)).Click();

            return this;
        }

        public bool IsInvalidEmailTextOnSignInFormDisplayed()
        {
            return new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(invalidEmailTextOnSignInFormLocator)).Displayed;
        }

        public string GetInvalidEmailTextOnSignInForm()
        {
            return new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(invalidEmailTextOnSignInFormLocator)).Text;
        }

        public bool IsInvalidPasswordTextOnSignInFormDisplayed()
        {
            return new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(invalidPasswordTextOnSignInFormLocator)).Displayed;
        }

        public string GetInvalidPasswordTextOnSignInForm()
        {
            return new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(invalidPasswordTextOnSignInFormLocator)).Text;
        }

        public SignUpWithEmailForm ClickCreateYourAccountBtn()
        {
            new WebDriverWait(driver, timeToWait)
              .Until(d => d.FindElement(createYourAccountBtnLocator)).Click();

            return new SignUpWithEmailForm(driver);
        }

        //my added methods

        public SignInWithEmailForm ClickYourEmailField()
        {
            new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(yourEmailFieldLocator)).Click();

            return this;
        }

        public SignInWithEmailForm ClickPasswordField()
        {
            new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(passwordFieldLocator)).Click();

            return this;
        }

        public SignInWithEmailForm SendKeysYourEmailField()
        {
            new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(yourEmailFieldLocator)).SendKeys("dcUMT_1585125431853_test@dating.com");

            return this;
        }

        public SignInWithEmailForm SendKeysPasswordField()
        {
            new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(passwordFieldLocator)).SendKeys("sdvtest123");

            return this;
        }
        #endregion
    }

    public class SignUpWithEmailForm : BasePage
    {
        public SignUpWithEmailForm(IWebDriver driver) : base(driver) { }

        #region Locators
        By createAccountBtnLocator = By.CssSelector("[value='sign-up']");
        By invalidNameTextOnSignUpFormLocator = By.CssSelector("[name='registration'] .invalid[name='name'] + .error-notification");
        By invalidEmailTextOnSignUpFormLocator = By.CssSelector("[name='registration'] .invalid[name='email'] + div + .error-notification");
        By invalidPasswordTextOnSignUpFormLocator = By.CssSelector("[name='registration'] .invalid[name='password']  + .error-notification");

        //my added locators
        By nameOrNicknameFieldLocator = By.CssSelector("[name='registration'] [name='name']");
        By realEmailFieldLocator = By.CssSelector("[name='registration'] [name='email']");
        By passwordFieldinCreateYourAccounLocator = By.CssSelector("[name='registration'] [name='password']");

        #endregion

        #region Methods
        public SignUpWithEmailForm ClickCreateAccountBtn()
        {
            new WebDriverWait(driver, timeToWait)
              .Until(d => d.FindElement(createAccountBtnLocator)).Click();

            return this;
        }

        public bool IsInvalidNameTextOnSignUpFormDisplayed()
        {
            return new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(invalidNameTextOnSignUpFormLocator)).Displayed;
        }

        public string GetInvalidNameTextOnSignUpForm()
        {
            return new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(invalidNameTextOnSignUpFormLocator)).Text;
        }

        public bool IsInvalidEmailTextOnSignUpFormDisplayed()
        {
            return new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(invalidEmailTextOnSignUpFormLocator)).Displayed;
        }

        public string GetInvalidEmailTextOnSignUpForm()
        {
            return new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(invalidEmailTextOnSignUpFormLocator)).Text;
        }

        public bool IsInvalidPasswordTextOnSignUpFormDisplayed()
        {
            return new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(invalidPasswordTextOnSignUpFormLocator)).Displayed;
        }

        public string GetInvalidPasswordTextOnSignUpForm()
        {
            return new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(invalidPasswordTextOnSignUpFormLocator)).Text;
        }

        //my added methods
        public SignUpWithEmailForm SendKeysNameOrNicknameField()
        {
            Random rnd = new Random();

            int fignya = rnd.Next(999, 9999);

            new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(nameOrNicknameFieldLocator)).SendKeys("test user from slavik " + fignya);

            return this;
        }

        public SignUpWithEmailForm SendKeysRealEmailField()
        {

            Random rnd = new Random();

            int fignya = rnd.Next(999, 9999);

            new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(realEmailFieldLocator)).SendKeys("32sss" + fignya + "sss21421_test@test.test");

            return this;
        }

        public SignUpWithEmailForm SendKeysPasswordFieldinCreateYourAccoun()
        {

            Random rnd = new Random();

            int fignya = rnd.Next(999, 9999);

            new WebDriverWait(driver, timeToWait)
                .Until(d => d.FindElement(passwordFieldinCreateYourAccounLocator)).SendKeys("1234" + fignya);

            return this;
        }
        #endregion
    }
}