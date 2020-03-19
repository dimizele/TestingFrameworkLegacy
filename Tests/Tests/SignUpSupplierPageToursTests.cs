using BaseSetup.Browser;
using BaseSetup.Test;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Pages;

namespace Tests.Tests
{ [TestFixture]
    class SignUpSupplierPageToursTests :UiTestBase
    {
        public override void BeforeEach()
        {
            Driver.Manage().Window.Maximize();
        }

      


        [Test]
        public void SignUpTour()
        {

            Driver.GoToPage<SupplierSignUpPageTours>().SignUpSupplierTour().VerifyNavigationSuccessfulTourRegistration();
        }
    }
}
