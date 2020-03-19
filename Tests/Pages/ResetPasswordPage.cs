using BaseSetup.Page;
using BaseSetup.UpgradedSelenium;
using OpenQA.Selenium;
using SupportClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Pages
{
  public  class ResetPasswordPage : BasePage
    {
        public override string pageUrl { get; set; } = "https://www.phptravels.net/login";

        //public UpWebElement Password => Driver.FindElement(By.Name("password"));
        public UpWebElement ForgetPassword => Driver.FindElement(By.CssSelector("[href*='#ForgetPassword']"));

        public UpWebElement EmailinputField => Driver.FindElement(By.Id("resetemail"));

        public UpWebElement ResetButton => Driver.FindElement(By.CssSelector(".resetbtn"));

        public ResetPasswordPage FillInEmailField(string email)
        {
            EmailinputField.Click();
            EmailinputField.Clear();
           
            EmailinputField.SendKeys(RandomDataGenerator.RandomEmailAddress());
            return this;
        }

        public ResetPasswordVeryfying ResetPassword()
        {
            ForgetPassword.Click();
            FillInEmailField(RandomDataGenerator.RandomEmailAddress());
            ResetButton.Click();

            return new ResetPasswordVeryfying() { Driver = Driver };
        }

    }
}