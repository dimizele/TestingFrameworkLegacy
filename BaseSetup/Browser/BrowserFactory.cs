using System;
using System.Collections.Generic;
using System.Text;
using BaseSetup.UpgradedSelenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BaseSetup.Browser
{
    public class BrowserFactory
    {
        public UpWebDriver Driver { get; set; }

        public UpWebDriver CreateDriver()
        {
            IWebDriver driver = new ChromeDriver();
            Driver = new UpWebDriver(driver);

            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(3);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.Manage().Window.Maximize();
            Driver.NotWaitForAngularCalls = false;

            return Driver;
        }

        public void Dispose()
        {
            this.Driver.Dispose();
        }
    }
}
