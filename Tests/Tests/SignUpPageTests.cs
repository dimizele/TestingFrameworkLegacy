using BaseSetup.Test;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Pages;
using BaseSetup.Browser;

namespace Tests.Tests
{
    [TestFixture]
    public class SignUpPageTests :  UiTestBase

    {
        private readonly string email = "admin@yahoo.com";
        private readonly string password = "12341234";
        public override void BeforeEach()
        {
            Driver.Manage().Window.Maximize();
        }

        [Test]
        public void SignUpPage()
        {
            Driver.GoToPage<SignUpPage>()
                .SignUp(email,password).VerifyNavigationToAccountAfterSignUp();
        }

    }
}
