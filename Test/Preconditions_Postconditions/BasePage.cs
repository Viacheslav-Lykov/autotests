using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System;

namespace Pages
{
    public abstract class BasePage
    {
        protected IWebDriver driver;
        public bool bear;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        protected TimeSpan timeToWait = TimeSpan.FromSeconds(16);
    }

    //public abstract class Header
    //{
    //    protected IWebDriver driver;

    //    public Header(IWebDriver driver)
    //    {
    //        this.driver = driver;
    //    }

    //    protected TimeSpan timeToWait = TimeSpan.FromSeconds(10);
    //}
}
