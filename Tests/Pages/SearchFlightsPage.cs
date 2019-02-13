using BaseSetup.Page;
using BaseSetup.UpgradedSelenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Pages
{

   
   public     class SearchFlightsPage : BasePage
    {
        public override string pageUrl { get; set; } = "https://www.phptravels.net/";

        public UpWebElement DatesAvailabilityPanel => Driver.FindElement(By.CssSelector(".panel.body.flights"));



        public void VerifyNavigationToSearchFlightsPage()
        {
            Assert.IsTrue(DatesAvailabilityPanel.Displayed);

        }






    }
}
