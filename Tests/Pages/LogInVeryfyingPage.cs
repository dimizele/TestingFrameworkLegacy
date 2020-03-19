using BaseSetup.Page;
using BaseSetup.UpgradedSelenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Pages
{
    public class LogInVeryfyingPage :BasePage
    {
        public override string pageUrl { get; set; }
        public UpWebElement Bookings => Driver.FindElement(By.CssSelector("[href='#bookings']"));

        public void VerifyNavigationToAccount()
        {
            Assert.IsTrue(Bookings.Displayed);

        }
    }
}
