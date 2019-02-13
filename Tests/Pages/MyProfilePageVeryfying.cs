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
    class MyProfilePageVeryfying : BasePage
    {
        public override string pageUrl { get; set; } = "https://www.phptravels.net/account";

        public UpWebElement SubmitButton => Driver.FindElement(By.CssSelector(".updateprofile"));

        public void VerifyMyProfilePage()
        {
            Assert.IsTrue(SubmitButton.Displayed);

        }
    }
}
