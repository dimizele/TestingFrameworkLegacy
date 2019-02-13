using BaseSetup.Page;
using BaseSetup.UpgradedSelenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SupportClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Pages
{
    class MyProfilePage : BasePage
    {

        public override string pageUrl { get; set; } = "https://www.phptravels.net/account";

        public UpWebElement MyProfile => Driver.FindElement(By.CssSelector("[href='#profile']"));

        public UpWebElement FirstNameInputField => Driver.FindElement(By.Name("firstname"));

        public UpWebElement LastNameInputField => Driver.FindElement(By.Name("lastname"));

        public UpWebElement PhoneInputField => Driver.FindElement(By.Name("phone"));

        public UpWebElement EmailInputField => Driver.FindElement(By.Name("email"));

        public UpWebElement PasswordInputField => Driver.FindElement(By.Name("password"));

        public UpWebElement ConfirmPasswordInputField => Driver.FindElement(By.Name("confirmpassword"));

        public UpWebElement Address1InputField => Driver.FindElement(By.Name("address1"));

        public UpWebElement Address2InputField => Driver.FindElement(By.Name("address2"));

        public UpWebElement CityInputField => Driver.FindElement(By.Name("city"));

        public UpWebElement StateInputField => Driver.FindElement(By.Name("state"));

        public UpWebElement PostalCodeInputField => Driver.FindElement(By.Name("zip"));
        
        public UpWebElement CountryInputField => Driver.FindElement(By.Name("country")).FindElement(By.CssSelector("option[value='3']"));
     
        public UpWebElement SubmitButton => Driver.FindElement(By.CssSelector(".updateprofile"));

        


        public MyProfilePage PersonalInformations(String phone)
        {
            PhoneInputField.Click();
            PhoneInputField.Clear();
            PhoneInputField.SendKeys(RandomDataGenerator.RandomAlphaNumericString(8));
            return this;
        }
        //TODO: Odvoj gi name email subject i message vo posebni funkcii, posle povikaj gi vo ovaa
        public MyProfilePage EmailFillIn(string email)
        {
            EmailInputField.Click();
            EmailInputField.Clear();
            EmailInputField.SendKeys(RandomDataGenerator.RandomEmailAddress());
            return this;
        }
        public MyProfilePage PasswordFillIn(string password)
        {
            PasswordInputField.Click();
            PasswordInputField.Clear();
            PasswordInputField.SendKeys(RandomDataGenerator.RandomAlphaNumericString(8));
            return this;

        }
        public MyProfilePage ConfirmPasswordFillIn(string password)
        {
            ConfirmPasswordInputField.Click();
            ConfirmPasswordInputField.Clear();
            ConfirmPasswordInputField.SendKeys(RandomDataGenerator.RandomAlphaNumericString(8));

            return this;
        }
        
      public MyProfilePage Address1FillIn(string address)
        {
            Address1InputField.Click();
            Address1InputField.Clear();
            Address1InputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(20));
            return this;
        }


        public MyProfilePage Address2FillIn(string address)
        {
            Address2InputField.Click();
            Address2InputField.Clear();
            Address2InputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(20));
            return this;
        }

      

       public MyProfilePage CityCountryPostalCode(string city,string state,string zip) {

            CityInputField.Click();
        CityInputField.Clear();
        CityInputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(15));

        StateInputField.Click();
        StateInputField.Clear();
        StateInputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(15));

        PostalCodeInputField.Click();
        PostalCodeInputField.Clear();
            PostalCodeInputField.SendKeys(RandomDataGenerator.RandomAlphaNumericString(8));

           
            

            return this;
        }
        
        public MyProfilePageVeryfying UpdateProfile()
        {
            MyProfile.Click();
            PersonalInformations(RandomDataGenerator.RandomAlphaNumericString(8));
            EmailFillIn(RandomDataGenerator.RandomEmailAddress());
            PasswordFillIn(RandomDataGenerator.RandomAlphaNumericString(8));
            ConfirmPasswordFillIn(RandomDataGenerator.RandomAlphaNumericString(8));
            
            Address1FillIn(RandomDataGenerator.RandomStringOnlyLetters(20));
            Address1FillIn(RandomDataGenerator.RandomStringOnlyLetters(20));
            CityCountryPostalCode(RandomDataGenerator.RandomStringOnlyLetters(15), RandomDataGenerator.RandomStringOnlyLetters(15), RandomDataGenerator.RandomAlphaNumericString(8));
            SubmitButton.Click();

            return new MyProfilePageVeryfying() { Driver = Driver };
        }
    }
}
