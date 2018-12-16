using System;
using System.Collections.Generic;
using System.Text;
using BaseSetup.Browser;
using BaseSetup.UpgradedSelenium;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BaseSetup.Test
{
    public class UiTestBase
    {
        public UpWebDriver Driver { get; set; }

        [OneTimeSetUp]
        public virtual void OneTimeSetUp()
        {
            BeforeAll();
        }

        [OneTimeTearDown]
        public virtual void OneTimeTearDown()
        {
            AfterAll();
        }

        [SetUp]
        public virtual void SetUp()
        {
            DriverInit();
            BeforeEach();
        }

        [TearDown]
        public virtual void TearDown()
        {
            AfterEach();
            Driver.Dispose();
        }

        public virtual void BeforeAll()
        {

        }

        public virtual void AfterAll()
        {

        }

        public virtual void BeforeEach()
        {

        }

        public virtual void AfterEach()
        {

        }

        public void DriverInit()
        {
            Driver = new BrowserFactory().CreateDriver();
        }
    }
}
