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
    class SearchForCarsPageTests :UiTestBase
    {
        private readonly string pickupdate = "25/04/2019";
        private readonly string dropoffdate = "05/05/2019";
       
        
        public override void BeforeEach()
        {
            Driver.Manage().Window.Maximize();
        
        }


        [Test]
        public void SearchCars()
        {

            Driver.GoToPage<HomePage>()
                .SearchCars(pickupdate,dropoffdate)
                .VerifyNavigationToCarSalePage();

        }
    }
}
