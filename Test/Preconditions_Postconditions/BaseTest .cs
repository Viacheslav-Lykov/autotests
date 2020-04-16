using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    [TestFixture]
    public abstract class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void DoBeforeAnyTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.dating.030.npdev.lan/");
        }

        [TearDown]
        public void DoAfterAnyTest()
        {
            driver.Quit();
        }
    }
}