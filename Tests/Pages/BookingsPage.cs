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
    class BookingsPage : BasePage

    {
        public override string pageUrl { get; set; } = "https://www.phptravels.net/account/";

        public UpWebElement Bookings => Driver.FindElement(By.CssSelector("[href='#bookings']"));
        

        public BookingsVerifying LookBookings()
        {
            Bookings.Click();


            return new BookingsVerifying() { Driver = Driver };
        }
    }
}
