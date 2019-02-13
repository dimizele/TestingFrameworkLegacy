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
  public   class ResetPasswordVeryfying :BasePage
     
    {
        public override string pageUrl { get; set; } = "https://www.phptravels.net/login";

        public UpWebElement SuccessFullSentEmail => Driver.FindElement(By.CssSelector(".resultreset"));

        public void VerifyNavigationToResettingPassword()
        {
            Assert.IsTrue(SuccessFullSentEmail.Displayed);

        }
    }
}
