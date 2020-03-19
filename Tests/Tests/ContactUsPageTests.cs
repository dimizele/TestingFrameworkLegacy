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
    class ContactUsPageTests :UiTestBase
    {
       


        public override void BeforeEach()
        {
            Driver.Manage().Window.Maximize();

        }

        [Test]
        public void ContactUs()
        {
            Driver.GoToPage<ContactUsPage>().ContactUs().VerifyNavigationToContactUs();

        }
    }
}
