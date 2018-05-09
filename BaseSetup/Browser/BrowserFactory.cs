using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BaseSetup.Browser
{
    public class BrowserFactory
    {
        public IWebDriver Driver { get; set; }

        public IWebDriver CreateDriver()
        {
            this.Driver = new ChromeDriver();

            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(3);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return Driver;
        }

        public void Dispose()
        {
            this.Driver.Dispose();
        }
    }
}
