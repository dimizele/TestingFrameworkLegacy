using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BaseSetup.Page;
using BaseSetup.UpgradedSelenium;
using OpenQA.Selenium;

namespace Tests.Pages
{
    public class LogInPage : BasePage
    {
        public UpWebElement Username => Driver.FindElement(By.Name("username"));

        public UpWebElement Password => Driver.FindElement(By.Name("password"));

        public UpWebElement LogInButton => Driver.FindElement(By.CssSelector(".loginbtn"));


        public override string pageUrl { get; set; } = "https://www.phptravels.net/login";

        public LogInPage FillUsername(string username)
        {
            Username.Click();
            Username.Clear();
            Username.SendKeys(username);

            return this;
        }

        public LogInPage FillPassword(string password)
        {
            Password.Click();
            Password.Clear();
            Password.SendKeys(password);

            return this;
        }

        public LogInPage LogIn(string username, string password)
        {
            FillUsername(username);
            FillPassword(password);
            LogInButton.Click();

            return this;
        }
    }
}
