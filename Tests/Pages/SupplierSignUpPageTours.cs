using BaseSetup.Page;
using BaseSetup.UpgradedSelenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportClient.Helpers;

namespace Tests.Pages
{
    class SupplierSignUpPageTours :BasePage
    {
        public override string pageUrl { get; set; } = "https://www.phptravels.net/supplier-register/";

        public UpWebElement Tours => Driver.FindElement(By.Id("tours"));

        public UpWebElement HotelNameInputField => Driver.FindElement(By.Name("itemname"));

        public UpWebElement FullNameInputField => Driver.FindElement(By.Name("fname"));

        public UpWebElement LastNameInputField => Driver.FindElement(By.Name("lname"));

        public UpWebElement EmailInputField => Driver.FindElement(By.Name("email"));

        public UpWebElement PhoneInputField => Driver.FindElement(By.Name("mobile"));

        public UpWebElement StateInputField => Driver.FindElement(By.Name("state"));

        public UpWebElement CityInputField => Driver.FindElement(By.Name("city"));

        public UpWebElement Address1InputField => Driver.FindElement(By.Name("address1"));

        public UpWebElement Address2InputField => Driver.FindElement(By.Name("address2"));

        public UpWebElement CountrySelectField => Driver.FindElement(By.Name("country"));

        public UpWebElement RegisterButton => Driver.FindElement(By.CssSelector(".center-block"));

        //TODO: Odvoj gi name email subject i message vo posebni funkcii, posle povikaj gi vo ovaa
        public SupplierSignUpPageTours HotelNameFillIn(String hotel)
        {
            HotelNameInputField.Click();
            HotelNameInputField.Clear();
            HotelNameInputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(15));
            return this;


        }

        public SupplierSignUpPageTours FullNameFillIn(String name)
        {

            FullNameInputField.Click();
            FullNameInputField.Clear();
            FullNameInputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(15));

            return this;
        }

        public SupplierSignUpPageTours LastNameFillIn(String lastname)
        {
            LastNameInputField.Click();
            LastNameInputField.Clear();
            LastNameInputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(20));

            return this;

        }
           
        public SupplierSignUpPageTours EmailFiilIn(String email)
        {
            EmailInputField.Click();
            EmailInputField.Clear();
            EmailInputField.SendKeys(RandomDataGenerator.RandomEmailAddress());

            return this;
        }
           
        public SupplierSignUpPageTours PhoneFillIn(String phone)
        {
            PhoneInputField.Click();
            PhoneInputField.Clear();
            PhoneInputField.SendKeys(RandomDataGenerator.RandomAlphaNumericString(15));

            return this;
        }
        
        public SupplierSignUpPageTours StateFillIn(String state)
        {
            StateInputField.Click();
            StateInputField.Clear();
            StateInputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(10));

            return this;
        }
            
        public SupplierSignUpPageTours SelectCountry()
        {
            CountrySelectField.Click();
            CountrySelectField.SendKeys(Keys.Down);
            CountrySelectField.SendKeys(Keys.Down);
            CountrySelectField.SendKeys(Keys.Down);
            CountrySelectField.SendKeys(Keys.Enter);

            return this;
        }
            
        public SupplierSignUpPageTours CityFillIn(String city)
        {
            CityInputField.Click();
            CityInputField.Clear();
            CityInputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(15));

            return this;
        }
            
        public SupplierSignUpPageTours Addres1FillIn(string address)
        {
            Address1InputField.Click();
            Address1InputField.Clear();
            Address1InputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(15));

            return this;
        }
       
        public SupplierSignUpPageTours Address2FillIn(String address)
        {

            Address2InputField.Click();
            Address2InputField.Clear();
            Address2InputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(15));

            return this;
        }

        

        public SignUpSupplierTourVeryfying SignUpSupplierTour()
        {
            Tours.Click();
            HotelNameFillIn(RandomDataGenerator.RandomStringOnlyLetters(15));
            FullNameFillIn(RandomDataGenerator.RandomStringOnlyLetters(15));
            LastNameFillIn(RandomDataGenerator.RandomStringOnlyLetters(15));
            EmailFiilIn(RandomDataGenerator.RandomEmailAddress());
            PhoneFillIn(RandomDataGenerator.RandomAlphaNumericString(15));
            StateFillIn(RandomDataGenerator.RandomStringOnlyLetters(15));
            CityFillIn(RandomDataGenerator.RandomStringOnlyLetters(15));
            SelectCountry();
            Addres1FillIn(RandomDataGenerator.RandomStringOnlyLetters(15));
            Address2FillIn(RandomDataGenerator.RandomStringOnlyLetters(15));
            RegisterButton.Click();


            return new SignUpSupplierTourVeryfying() { Driver = Driver };
        }
        
    }
}
