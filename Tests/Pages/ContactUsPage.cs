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
    class ContactUsPage : BasePage
    {
        public override string pageUrl { get; set; } = "https://www.phptravels.net/contact-us";

        public UpWebElement NameInputField => Driver.FindElement(By.Name("contact_name"));

        public UpWebElement EmailInputField => Driver.FindElement(By.Name("contact_email"));

        public UpWebElement SubjectInputField => Driver.FindElement(By.Name("contact_subject"));

        public UpWebElement MessageInputField => Driver.FindElement(By.Name("contact_message"));

        public UpWebElement SubmitButton => Driver.FindElement(By.Name("submit_contact"));


        public ContactUsPage NameFillIn(string name)
        {
            NameInputField.Click();
            NameInputField.Clear();
            NameInputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(6));

            return this;


        }

        public ContactUsPage EmailFillIn(string email)
        {
            EmailInputField.Click();
            EmailInputField.Clear();
            EmailInputField.SendKeys(RandomDataGenerator.RandomEmailAddress());

            return this;

        }
        
        public ContactUsPage SubjectFillIn(string subject)
        {

            SubjectInputField.Click();
            SubjectInputField.Clear();
            SubjectInputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(6));

            return this;
        }


        public ContactUsPage MessageFillIn(string message)
        {
            MessageInputField.Click();
            MessageInputField.Clear();
            MessageInputField.SendKeys(RandomDataGenerator.RandomStringOnlyLetters(15));

            return this;
        }

        public ContactUsPage PopulateContactInfo()
        {
            NameFillIn(RandomDataGenerator.RandomStringOnlyLetters(10));
            EmailFillIn(RandomDataGenerator.RandomEmailAddress());
            SubjectFillIn(RandomDataGenerator.RandomStringOnlyLetters(15));
            MessageFillIn(RandomDataGenerator.RandomStringOnlyLetters(20));

            return this;
           
        }


        public ContactUsVerifying ContactUs()
        {

            PopulateContactInfo();
            SubmitButton.Click();

            return new ContactUsVerifying() { Driver = Driver };
        }
    }
}
