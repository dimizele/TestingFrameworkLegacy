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
  public  class SignUpVerifyingPage :BasePage
    {
        public override string pageUrl { get; set; } = "https://www.phptravels.net/account/";

        public UpWebElement NewsLetter => Driver.FindElement(By.CssSelector("[href='#newsletter']"));


        public void VerifyNavigationToAccountAfterSignUp()
        {
            Assert.IsTrue(NewsLetter.Displayed);

        }
    }
}
