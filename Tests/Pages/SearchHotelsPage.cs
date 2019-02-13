using BaseSetup.Page;
using BaseSetup.UpgradedSelenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Pages
{
    class SearchHotelsPage :BasePage

    {
        public override string pageUrl { get; set; } = "https://www.phptravels.net/";

        // public UpWebElement HotelName => Driver.FindElement(By.CssSelector(".select2-drop-active"));

        // public UpWebElement HotelName => Driver.FindElement(By.CssSelector(".select2-drop.select2-display-none.select2-with-searchbox.select2-drop-active"));

        public UpWebElement Hotels => Driver.FindElement(By.CssSelector("[href='#hotels']"));

        public UpWebElement checkIn => Driver.FindElement(By.Name("checkin"));

        public UpWebElement checkOut => Driver.FindElement(By.Name("checkout"));

        public UpWebElement Travellers => Driver.FindElement(By.Name("travellers"));

        public UpWebElement AdultTravellers => Driver.FindElement(By.Id("adultInput"));

        public UpWebElement ChildTravellers => Driver.FindElement(By.Id("childInput"));

        public UpWebElement Search => Driver.FindElement(By.CssSelector(".search-button"));


        //TODO: Odvoj gi name email subject i message vo posebni funkcii, posle povikaj gi vo ovaa
        public SearchHotelsPage FillInInfo(string adulttravellers,string childtravellers,string datein,string dateout)
        {
           /* HotelName.Click();
            HotelName.Clear();
            HotelName.SendKeys(hotelname);
            HotelName.SendKeys(Keys.Enter);
            */
            checkIn.Click();
            checkIn.Clear();
            checkIn.SendKeys(datein);
            /*checkIn.SendKeys(Keys.Down);
            checkIn.SendKeys(Keys.Left);
            checkIn.SendKeys(Keys.Enter);*/


            checkOut.Click();
            checkOut.Clear();
            checkOut.SendKeys(dateout);
            //checkOut.SendKeys(Keys.Down);
            //checkOut.SendKeys(Keys.Right);
            //checkOut.SendKeys(Keys.Enter);

            Travellers.Click();
            AdultTravellers.Click();
            AdultTravellers.Clear();
            AdultTravellers.SendKeys(adulttravellers);
            ChildTravellers.Click();
            ChildTravellers.Clear();
            ChildTravellers.SendKeys(childtravellers);

        

            return this;
        }


        public SearchHotelsPage SearchForHotel(string adults,string kids,string checkin,string checkout)
        {
            Hotels.Click();
            //Driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
            FillInInfo(adults,kids,checkin,checkout);
            Search.Click();
            return this;
        }
    }
}
