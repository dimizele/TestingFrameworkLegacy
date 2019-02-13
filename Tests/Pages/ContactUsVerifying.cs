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
    class ContactUsVerifying :BasePage 
    {
        public override string pageUrl { get; set; } = "https://www.phptravels.net/contact-us";

        public UpWebElement Submit => Driver.FindElement(By.Name("submit_contact"));


        public void VerifyNavigationToContactUs()
        {
            Assert.IsTrue(Submit.Displayed);

        }
    }
}
