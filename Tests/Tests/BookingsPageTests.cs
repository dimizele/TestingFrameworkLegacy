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
    [TestFixture]
    class BookingsPageTests :UiTestBase
    {
        private readonly string username = "user@phptravels.com";
        private readonly string password = "demouser";
        public override void BeforeEach()
        {
            Driver.Manage().Window.Maximize();
           
        }

       
        [Test]
        public void BookingsPage()
        {
            Driver.GoToPage<LogInPage>().LogIn(username, password);
           
            Driver.GoToPage<BookingsPage>().LookBookings().VerifyNavigationToAccount();
        }
    }
}
