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
{   [TextFixture]
    class SupplierLogInPageTests :UiTestBase
    {

        private readonly string username = "supplier@phptravels.com";
        private readonly string password = "demosupplier";
        private readonly string fullname = "Johny";
        private readonly string lastname = "John";

        private readonly string phone = "22222222";
        private readonly string email = "johny@yahoo.com";
       private readonly string password1 = "johnydemo";
        private readonly string address = "Brooklyn Ave 24/78-1";
        private readonly string city = "New York City";
        private readonly string state = "New York";
        private readonly string zip = "10043";

        public override void BeforeEach()
        {
            Driver.Manage().Window.Maximize();

        }

        [Test]

        public void LogInSupplier()
        {
            Driver.GoToPage<SupplierLogInPage>().LogInSupplier(username, password, fullname, lastname, address, phone, email, password1);

        }

    }
}
