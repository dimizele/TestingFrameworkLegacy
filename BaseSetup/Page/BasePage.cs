using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace BaseSetup.Page
{
    public abstract class BasePage
    {
        public IWebDriver Driver { get; set; }

        public abstract string pageUrl { get; set; }

        public string PageUrl
        {
            get => pageUrl;
            set => pageUrl = value;
        }

        public virtual string Url
        {
            get => PageUrl;
            set { }
        }

        protected BasePage()
        {

        }

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
