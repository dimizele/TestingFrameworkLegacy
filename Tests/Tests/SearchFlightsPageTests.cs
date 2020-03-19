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
    class SearchFlightsPageTests:UiTestBase
    {
    
       private readonly string airportFrom = "Chicago O'Hare";
       private readonly string airportTo = "JFK New York City";
        private readonly string departure = "13/07/2019";

        
        public override void BeforeEach()
        {
            Driver.Manage().Window.Maximize();


        }

        [Test]
        public void SearchFlights()
        {

            Driver.GoToPage<HomePage>().SearchFlights(airportFrom, airportTo, departure).VerifyNavigationToSearchFlightsPage();
        }
    }
}
