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
   public  class SupplierLogInVeryfying:BasePage 
    {
        public override string pageUrl { get; set; } = "https://www.phptravels.net/supplier";

        public UpWebElement SubmitButton => Driver.FindElement(By.CssSelector(".btn.btn-primary"));

        public void VerifyNavigationToSupplierAccount()
        {
            Assert.IsTrue(SubmitButton.Displayed);

        }
    }
}
