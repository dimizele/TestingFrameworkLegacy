using BaseSetup.Page;
using BaseSetup.UpgradedSelenium;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Pages
{
    public class SearchForCarsPage : BasePage
    {

        public override string pageUrl { get; set; } = "https://www.phptravels.net/cars/";

        public UpWebElement SellCarsTable => Driver.FindElement(By.CssSelector(".bgwhite"));
      


        public void VerifyNavigationToCarSalePage()
        {
            Assert.IsTrue(SellCarsTable.Displayed);

        }
    }
}
