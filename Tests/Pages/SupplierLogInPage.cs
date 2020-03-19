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
    class SupplierLogInPage : BasePage

    {
        public override string pageUrl { get; set; } = "https://www.phptravels.net/supplier/";

        public UpWebElement EmailInputField => Driver.FindElement(By.Name("email"));

        public UpWebElement PasswordInputField => Driver.FindElement(By.Name("password"));

        public UpWebElement LogInButton => Driver.FindElement(By.CssSelector(".btn.btn-primary.fadeIn.animated"));

      

        public UpWebElement ProfileButton => Driver.FindElement(By.CssSelector(".btn.btn-success.btn-sm.btn-block"));

        public UpWebElement FirstNameInputField => Driver.FindElement(By.Name("fname"));

        public UpWebElement Email1InputField => Driver.FindElement(By.Name("email"));

        public UpWebElement PhoneInputField => Driver.FindElement(By.Name("mobile"));

        public UpWebElement Address1InputField => Driver.FindElement(By.Name("address1"));

        public UpWebElement LastNameInputField => Driver.FindElement(By.Name("lname"));

        public UpWebElement Password1InputField => Driver.FindElement(By.Name("password"));

       

        public UpWebElement Address2InputField => Driver.FindElement(By.Name("address2"));

        public UpWebElement SubmitButton => Driver.FindElement(By.CssSelector(".btn-primary"));

        public SupplierLogInPage EmailFillIn(string email)
        {
            EmailInputField.Click();
            EmailInputField.Clear();
            EmailInputField.SendKeys(email);

            return this;
        }

        public SupplierLogInPage PasswordFillIn(String password)
        {
            PasswordInputField.Click();
            PasswordInputField.Clear();
            PasswordInputField.SendKeys(password);

            return this;
        }
           
        public SupplierLogInPage SupplierLogIn(String email,string password)
        {
            EmailFillIn(email);
            PasswordFillIn(password);

            return this;

        }

        public SupplierLogInPage FirstNameFillIn(String firstname)
        {
            FirstNameInputField.Click();
            FirstNameInputField.Clear();
            FirstNameInputField.SendKeys(firstname);

            return this;

        }

        public SupplierLogInPage LastNameFillIn(string lastname)
        {

            LastNameInputField.Click();
            LastNameInputField.Clear();
            LastNameInputField.SendKeys(lastname);

            return this;
        }

        public SupplierLogInPage Email1FillIn(string email)
        {
            Email1InputField.Click();
            Email1InputField.Clear();
            Email1InputField.SendKeys(email);

            return this;

        }

        public SupplierLogInPage Address1FillIn(String address)
        {
            Address1InputField.Click();
            Address1InputField.Clear();
            Address1InputField.SendKeys(address);

            return this;

        }

        public SupplierLogInPage Address2FillIn(String address)
        {
            Address2InputField.Click();
            Address2InputField.Clear();
            Address2InputField.SendKeys(address);

            return this;

        }
       
        public SupplierLogInPage PhoneFillIn(String phone)
        {
            PhoneInputField.Click();
            PhoneInputField.Clear();
            PhoneInputField.SendKeys(phone);

            return this;
        }  

        public SupplierLogInPage Password1FillIn(String password)
        {

            Password1InputField.Click();
            Password1InputField.Clear();
            Password1InputField.SendKeys(password);

            return this;

        }

       

        public SupplierLogInVeryfying LogInSupplier(string email,string password, string firstname, string lastname, string address, string phone, string email1,string password1)
        {
            EmailFillIn(email);
            PasswordFillIn(password);
            LogInButton.Click();
            ProfileButton.Click();
            FirstNameFillIn(firstname);
            LastNameFillIn(lastname);
            Email1FillIn(email1);
            Password1FillIn(password1);
            Address1FillIn(address);
            Address2FillIn(address);
            PhoneFillIn(phone);
            SubmitButton.Click();

            return new SupplierLogInVeryfying() { Driver = Driver };
        }
    }
}
