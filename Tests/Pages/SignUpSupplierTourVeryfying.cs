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
  public  class SignUpSupplierTourVeryfying : BasePage

    {
        public override string pageUrl { get; set; } = "https://www.phptravels.net/supplier-register/";

        public UpWebElement SuccessFullRegistering => Driver.FindElement(By.CssSelector("[href='#top']"));

        public void VerifyNavigationSuccessfulTourRegistration()
        {
            Assert.IsTrue(SuccessFullRegistering.Displayed);

        }

    }
}
