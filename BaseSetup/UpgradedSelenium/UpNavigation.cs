using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseSetup.UpgradedSelenium
{
    public class UpNavigation : INavigation
    {
        private UpWebDriver upDriver;
        private INavigation navigation;

        public UpNavigation(UpWebDriver upDriver, INavigation navigation)
        {
            this.upDriver = upDriver;
            this.navigation = navigation;
        }

        public void Back()
        {
            navigation.Back();
            upDriver.WaitForDocumentState();
            upDriver.WaitForjQuery();
            upDriver.WaitForAngular();
        }

        public void Forward()
        {
            navigation.Forward();
            upDriver.WaitForDocumentState();
            upDriver.WaitForjQuery();
            upDriver.WaitForAngular();
        }

        public void GoToUrl(string url)
        {
            navigation.GoToUrl(url);
            upDriver.WaitForDocumentState();
            upDriver.WaitForjQuery();
            upDriver.WaitForAngular();
        }

        public void GoToUrl(Uri url)
        {
            navigation.GoToUrl(url);
            upDriver.WaitForDocumentState();
            upDriver.WaitForjQuery();
            upDriver.WaitForAngular();
        }

        public void Refresh()
        {
            navigation.Refresh();
            upDriver.WaitForDocumentState();
            upDriver.WaitForjQuery();
            upDriver.WaitForAngular();
        }
    }
}
