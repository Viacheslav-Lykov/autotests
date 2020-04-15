using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using Pages;

namespace Tests
{
    public class SmokeTests : BaseTest
    {
        [Test]
        public void SingInFailedWithEmptyEmailAndPasswordTest()
        {
            new MainPage(driver)
                .ClickSignInWithEmailBtn()
                .ClickSignInBtn();

            var signInForm = new SignInWithEmailForm(driver);

            Assert.That(signInForm.IsInvalidEmailTextOnSignInFormDisplayed(),
                Is.True, "Не отображается подсказка для поля с Email");
            Assert.That(signInForm.GetInvalidEmailTextOnSignInForm(),
                Does.Contain("Enter valid email address"), "Неправильная подсказка для поля с Email");

            Assert.That(signInForm.IsInvalidPasswordTextOnSignInFormDisplayed(),
                Is.True, "Не отображается подсказка для поля с Password");
            Assert.That(signInForm.GetInvalidPasswordTextOnSignInForm(),
                Does.Contain("Enter password"), "Неправильная подсказка для поля с Password");
        }

        [Test]
        public void RegistrationFailedWithEmptyEmailAndPasswordTest()
        {
            new MainPage(driver)
                .ClickSignInWithEmailBtn()
                .ClickCreateYourAccountBtn()
                .ClickCreateAccountBtn();

            var signUpForm = new SignUpWithEmailForm(driver);

            Assert.That(signUpForm.IsInvalidNameTextOnSignUpFormDisplayed(),
                Is.True, "Не отображается подсказка для поля с Name");
            Assert.That(signUpForm.GetInvalidNameTextOnSignUpForm(),
                Does.Contain("Enter your name"), "Неправильная подсказка для поля с Name");

            Assert.That(signUpForm.IsInvalidEmailTextOnSignUpFormDisplayed(),
                Is.True, "Не отображается подсказка для поля с Email");
            Assert.That(signUpForm.GetInvalidEmailTextOnSignUpForm(),
                Does.Contain("Enter valid email"), "Неправильная подсказка для поля с Email");

            Assert.That(signUpForm.IsInvalidPasswordTextOnSignUpFormDisplayed(),
                Is.True, "Не отображается подсказка для поля с Password");
            Assert.That(signUpForm.GetInvalidPasswordTextOnSignUpForm(),
                Does.Contain("Enter password"), "Неправильная подсказка для поля с Password");
        }

        [Test]
        public void SingInWithRealEmailBySingInForm()
        {
            
            new MainPage(driver)
                .ClickSignInWithEmailBtn()
                .SendKeysYourEmailField()
                .SendKeysPasswordField()
                .ClickSignInBtn();

            System.Threading.Thread.Sleep(6000);

            var refilAccountBtn = new Header(driver);

            Assert.That(refilAccountBtn.refillAccountBtnDisplyed(),
                Is.True, "Нет кнопки Refill Account");
                        
        }

        [Test]
        public void CreationUserByCreateYourAccount()
        {
            //new MainPage(driver)
            //    .ClickSignInWithEmailBtn()
            //    .ClickCreateYourAccountBtn()
            //    .SendKeysNameOrNicknameField()
            //    .SendKeysRealEmailField()
            //    .SendKeysPasswordFieldinCreateYourAccoun()
            //    .ClickCreateAccountBtn();

            new MainPage(driver)
                .ClickSignInWithEmailBtn()
                .ClickCreateYourAccountBtn()
                .SendKeysNameOrNicknameField()
                .SendKeysRealEmailField()
                .SendKeysPasswordFieldinCreateYourAccoun()
                .ClickCreateAccountBtn()
                .SelectSexIAmAonAboutYouForm()
                .SelectSexSeekingAonAboutYouForm()
                .SelectMounthonAboutYouForm()
                .SelectDayonAboutYouForm()
                .SelectYearonAboutYouForm()
                .ClickNextBtnonAboutYou()
                .ClickNextBtnonSomeInterestingDetailsAboutYou()
                .ClickNextBtnonAboutYourIdealPartner()
                .ClickNextBtnonYourInterests()
                .ClickCompleteBtnonAddPhotoGetNoticed();


            System.Threading.Thread.Sleep(6000);

            var refilAccountBtn = new Header(driver);

            Assert.That(refilAccountBtn.refillAccountBtnDisplyed(),
                Is.True, "Нет кнопки Refill Account.");

        }
    }
}