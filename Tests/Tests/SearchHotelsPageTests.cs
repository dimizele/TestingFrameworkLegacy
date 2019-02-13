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
    class SearchHotelsPageTests :UiTestBase
    {

        private readonly string hotelCity = "Santorini";
        private readonly string adults = "2";
        private readonly string kids = "1";
        private readonly string dateIN = "26/07/2019";
        private readonly string dateOut = "05/08/2019";

        public override void BeforeEach()
        {
            Driver.Manage().Window.Maximize();
          



        }
       /* [Test]
        public void SearchHotels()
        {

            Driver.GoToPage<SearchHotelsPage>().SearchForHotel(adults,kids,dateIN,dateOut);
        }
        */
    }
}
