﻿using System;
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

            //var refilAccountBtn = new Header(driver);

            //Assert.That(refilAccountBtn.RefillAccountBtnDisplyed(),
            //    Is.True, "Нет кнопки Refill Account");

            Assert.That(new Header(driver).RefillAccountBtnDisplyed(),
                Is.True, "Нет кнопки Refill Account");

        }

        [Test]
        public void CreationUserByCreateYourAccount()
        {
            new MainPage(driver)
                .ClickSignInWithEmailBtn()
                .ClickCreateYourAccountBtn()
                .TypeRandowStringToNameOrNicknameField()
                .TypeRandowStringToRealEmailField()
                .TypeRandowStringToRPasswordFieldinCreateYourAccoun()
                .ClickCreateAccountBtn();

            System.Threading.Thread.Sleep(14000);


            new Windows_of_creation(driver)
                .ClickSexIAmAonAboutYouFormMale()
                .ClickSexSeekingAonAboutYouFormFemale();

            System.Threading.Thread.Sleep(2000);

            new Windows_of_creation(driver)
                .SelectMounthonAboutYouForm()
                .SelectDayonAboutYouForm()
                .SelectYearonAboutYouForm();

            System.Threading.Thread.Sleep(2000);

            new Windows_of_creation(driver)
                .ClickNextBtnonAboutYou();

            System.Threading.Thread.Sleep(2000);

            new Windows_of_creation(driver)
                .ClickNextBtnonSomeInterestingDetailsAboutYou();

            System.Threading.Thread.Sleep(2000);

            new Windows_of_creation(driver)
                .ClickNextBtnonAboutYourIdealPartner();

            System.Threading.Thread.Sleep(2000);

            new Windows_of_creation(driver)
                .ClickNextBtnonYourInterests();

            System.Threading.Thread.Sleep(2000);

            new Windows_of_creation(driver)
                .ClickCompleteBtnonAddPhotoGetNoticed();

            System.Threading.Thread.Sleep(6000);

            var upgradeAccountBtn = new Header(driver);

            Assert.That(upgradeAccountBtn.UpgradeAccountBtnDisplyed(),
                Is.True, "Создать профиль не удалось (нет кнопки Upgrade account)");

        }

        [Test]
        public void FirstPurchaseByCard()
        {
            CreationUserByCreateYourAccount();
            //для ускорения проверки (пропуска регистрации автотестом) можно закоментить прдыдущую строку и раскоментить следующую
            //driver.Navigate().GoToUrl("https://www.dating.com.20.stage/people/#afid=100500&token=c89939d3-0d8c-4ef5-ab26-596a96861348");

            System.Threading.Thread.Sleep(6000);

            new Header(driver)
                 .ClickUpgradeAccountBtn();

            System.Threading.Thread.Sleep(2500);

            new PurchaseFoarm(driver)
                .TypeRandowStringToCardNumberField()
                .SelectMounthOfCard()
                .SelectYearOfCard()
                .TypeRandowStringToCvvCardField()
                .TypeRandowStringToNameOnCardField()
                .ClickPurchaseCreditsOnPurchaseFoarmBtn();

            System.Threading.Thread.Sleep(3600);

            Assert.That(new Notifications(driver).YouHavePurchased20CreditsSystemMessageInfoDisplyed(),
                Is.True, "Нет уведомления о купленых кредитах");

            new Menu(driver)
                .ClickMenuSandwithBtn()
                .ClickMyProfileInMenuBtn();

            System.Threading.Thread.Sleep(3800);
                        
            Assert.That(new OwnProfile(driver).takeValueOfCredits(),
                Does.Contain("150"), "Нет начисленных кредитов");
                        
        }

    }
}