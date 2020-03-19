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
{
    [TextFixture]
    class MyProfilePageTests :UiTestBase
    {

        public readonly string username = "user@phptravels.com";
        public readonly string password = "demouser";

        public override void BeforeEach()
        {
            Driver.Manage().Window.Maximize();
        }

      
        [Test]
        public void UpdateProfile()
        {

            Driver.GoToPage<LogInPage>().LogIn(username, password);
          
            Driver.GoToPage<MyProfilePage>().UpdateProfile().VerifyMyProfilePage();
        }

    }
}
