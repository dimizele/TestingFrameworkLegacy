using BaseSetup.Browser;
using BaseSetup.Test;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Pages;

namespace Tests.Tests
{   [TextFixture]
    class SupplierSignUpPageHotelsTests :UiTestBase
    {


        
        public override void BeforeEach()
        {
            Driver.Manage().Window.Maximize();
        }

        [Test]
        public void SignUpSupplierHotel()
        {
            Driver.GoToPage<SupplierSignUpPageHotels>().SupplierSignUp().VerifyNavigationSuccessfulTourRegistration();
        }

    }
}
