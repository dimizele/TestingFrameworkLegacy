using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseSetup.Page;
using OpenQA.Selenium;

namespace Tests.Pages
{
    public class LogInPage : BasePage
    {
        public IWebElement Username => Driver.FindElement(By.Id("txtUsername"));

        public IWebElement Password => Driver.FindElement(By.Id("txtPassword"));

        public IWebElement LogInButton => Driver.FindElement(By.Id("btnLogin"));


        public override string pageUrl { get; set; } = "http://opensource.demo.orangehrmlive.com/";

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
