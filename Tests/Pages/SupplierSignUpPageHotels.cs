using BaseSetup.Page;
using BaseSetup.UpgradedSelenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SupportClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Pages
{
    public class SupplierSignUpPageHotels : BasePage

    {
        public override string pageUrl { get; set; } = "https://www.phptravels.net/supplier-register/";

       
        
        public UpWebElement Hotels => Driver.FindElement(By.Id("hotels"));

        public UpWebElement HotelNameInputField => Driver.FindElement(By.Name("itemname"));

        public UpWebElement FullNameInputField => Driver.FindElement(By.Name("fname"));

        public UpWebElement LastNameInputField => Driver.FindElement(By.Name("lname"));

        public UpWebElement EmailInputField => Driver.FindElement(By.Name("email"));

        public UpWebElement PhoneInputField => Driver.FindElement(By.Name("mobile"));

        public UpWebElement StateInputField => Driver.FindElement(By.Name("state"));

        public UpWebElement CityInputField => Driver.FindElement(By.Name("city"));

        public UpWebElement Address1InputField => Driver.FindElement(By.Name("address1"));

        public UpWebElement Address2InputField => Driver.FindElement(By.Name("address2"));

        public UpWebElement CountrySelection => Driver.FindElement(By.Name("country"));

        public UpWebElement RegisterButton => Driver.FindElement(By.CssSelector(".center-block"));
        
        public SupplierSignUpPageHotels HotelNameFillIn(string name)
        {
            HotelNameInputField.Click();
            HotelNameInputField.Clear();
            HotelNameInputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(10));
            return this;
        }
       public SupplierSignUpPageHotels FullNameFillIn(string fullname)
        {
            FullNameInputField.Click();
            FullNameInputField.Clear();
            FullNameInputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(10));

            return this;

        }

        public SupplierSignUpPageHotels LastNameFillIn(String lastname)
        {
            LastNameInputField.Click();
            LastNameInputField.Clear();
            LastNameInputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(10));

            return this;
 
        }

        public SupplierSignUpPageHotels EmailFillIn(String email)
        {
            EmailInputField.Click();
            EmailInputField.Clear();
            EmailInputField.SendKeys(RandomDataGenerator.RandomEmailAddress());

            return this;


        }


       public SupplierSignUpPageHotels PhoneFillIn(string phone)
        {

            PhoneInputField.Click();
            PhoneInputField.Clear();
            PhoneInputField.SendKeys(RandomDataGenerator.RandomAlphaNumericString(10));
            return this;

        }

        public SupplierSignUpPageHotels StateFillIn(string state)
        {

            StateInputField.Click();
            StateInputField.Clear();
            StateInputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(15));

            return this;
        }

        public SupplierSignUpPageHotels CityFillIn(string city)
        {
            CityInputField.Click();
            CityInputField.Clear();
            CityInputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(15));
            return this;

        }

        public SupplierSignUpPageHotels AddressFillIn(string address)
        {

            Address1InputField.Click();
            Address1InputField.Clear();
            Address1InputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(15));


            Address2InputField.Click();
            Address2InputField.Clear();
            Address2InputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(15));

            return this;
            
        }

        public SupplierSignUpPageHotels SelectCountry()
        {
            CountrySelection.Click();
            CountrySelection.SendKeys(Keys.Down);
            CountrySelection.SendKeys(Keys.Down);
            CountrySelection.SendKeys(Keys.Enter);

            return this;
        }
        public SignUpSupplierTourVeryfying SupplierSignUp()
        {

            Hotels.Click();
            HotelNameFillIn(RandomDataGenerator.RandomStringOnlyLetters(15));
            FullNameFillIn(RandomDataGenerator.RandomStringOnlyLetters(15));
            LastNameFillIn(RandomDataGenerator.RandomStringOnlyLetters(15));
            EmailFillIn(RandomDataGenerator.RandomEmailAddress());
            PhoneFillIn(RandomDataGenerator.RandomAlphaNumericString(10));
            CityFillIn(RandomDataGenerator.RandomStringOnlyLetters(15));
            StateFillIn(RandomDataGenerator.RandomStringOnlyLetters(15));
            AddressFillIn(RandomDataGenerator.RandomStringOnlyLetters(15));
            SelectCountry();






            RegisterButton.Click();

            return new SignUpSupplierTourVeryfying() { Driver = Driver };
        }
    }

}
