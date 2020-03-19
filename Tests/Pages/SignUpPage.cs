using BaseSetup.Page;
using BaseSetup.UpgradedSelenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SupportClient.Helpers;

namespace Tests.Pages
{
   public class SignUpPage : BasePage
    { 
        public UpWebElement FirstNameInputField => Driver.FindElement(By.Name("firstname"));

        public UpWebElement LastNameInputField => Driver.FindElement(By.Name("lastname"));

        public UpWebElement MobileNumberInputField => Driver.FindElement(By.Name("phone"));

        public UpWebElement EmailInputField => Driver.FindElement(By.Name("email"));

        public UpWebElement PasswordInputField => Driver.FindElement(By.Name("password"));

        public UpWebElement ConfirmPasswordInputField => Driver.FindElement(By.Name("confirmpassword"));

        public UpWebElement SignUpButton => Driver.FindElement(By.CssSelector(".btn-lg"));

        public override string pageUrl { get; set; } = "https://www.phptravels.net/register/";


        public SignUpPage FillName(string firstName)
        {
            FirstNameInputField.Click();
            FirstNameInputField.Clear();
            FirstNameInputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(10));

            return this;

        }

        public SignUpPage FillLastName(string lastName)
        {
            LastNameInputField.Click();
            LastNameInputField.Clear();
            LastNameInputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(10));

            return this;
        }

        public SignUpPage FillMobileNumber(string number)
        {
            MobileNumberInputField.Click();
            MobileNumberInputField.Clear();
            MobileNumberInputField.SendKeys(RandomDataGenerator.RandomAlphaNumericString(10));
            return this;
        }

        public SignUpPage FillEmail(string email)
        {
             EmailInputField.Click();
             EmailInputField.Clear();
             EmailInputField.SendKeys(email);
            return this;
        }

        public SignUpPage FillInPassword(string password)
        {
            PasswordInputField.Click();
            PasswordInputField.Clear();
            PasswordInputField.SendKeys(password);
            return this;
        }
        public SignUpPage FillInConfirmPassword(string password)
        {
            ConfirmPasswordInputField.Click();
            ConfirmPasswordInputField.Clear();
            ConfirmPasswordInputField.SendKeys(password);
            return this;
        }

        public SignUpVerifyingPage SignUp(string email,string password)
        {
            FillName(RandomDataGenerator.RandomStringOnlyLetters(10));
            FillLastName(RandomDataGenerator.RandomStringOnlyLetters(10));
            FillMobileNumber(RandomDataGenerator.RandomAlphaNumericString(10));
            FillEmail(email);
            FillInPassword(password);
            FillInConfirmPassword(password);
            SignUpButton.Click();


            return new SignUpVerifyingPage() { Driver = Driver };
        }
        
    }
}
