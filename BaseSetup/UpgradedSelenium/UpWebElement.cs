using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;

namespace BaseSetup.UpgradedSelenium
{
    public class UpWebElement : IWebElement, IWrapsElement
    {
        protected UpWebDriver upDriver;
        protected IWebElement element;


        public UpWebElement(UpWebDriver driver, IWebElement element)
        {
            this.upDriver = driver;
            this.element = element;
        }

        public UpWebElement(UpWebDriver driver, By elementLocator)
        {
            this.upDriver = driver;
            element = this.upDriver.FindElement(elementLocator);
        }

        public UpWebDriver UpDriver
        {
            get
            {
                return upDriver;
            }
        }

        public IWebElement WrappedElement
        {
            get { return element; }
        }

        public UpWebElement FindElement(By by)
        {
            upDriver.WaitForDocumentState();
            upDriver.WaitForjQuery();
            upDriver.WaitForAngular();
            return new UpWebElement(upDriver, element.FindElement(by));
        }

        public ReadOnlyCollection<UpWebElement> FindElements(By by)
        {
            upDriver.WaitForDocumentState();
            upDriver.WaitForjQuery();
            upDriver.WaitForAngular();
            return new ReadOnlyCollection<UpWebElement>(element.FindElements(by).Select(el => new UpWebElement(upDriver, el)).ToList());
        }

        IWebElement ISearchContext.FindElement(By by)
        {
            upDriver.WaitForDocumentState();
            upDriver.WaitForjQuery();
            upDriver.WaitForAngular();
            return FindElement(by);
        }

        ReadOnlyCollection<IWebElement> ISearchContext.FindElements(By by)
        {
            upDriver.WaitForDocumentState();
            upDriver.WaitForjQuery();
            upDriver.WaitForAngular();

            return new ReadOnlyCollection<IWebElement>(element.FindElements(by).Select(el => new UpWebElement(upDriver, el) as IWebElement).ToList());
        }

        public void Clear()
        {
            upDriver.WaitForDocumentState();
            upDriver.WaitForjQuery();
            upDriver.WaitForAngular();
            element.Clear();
        }

        public void SendKeys(string text)
        {
            upDriver.WaitForDocumentState();
            upDriver.WaitForjQuery();
            upDriver.WaitForAngular();
            element.SendKeys(text);
        }

        public void Submit()
        {
            upDriver.WaitForDocumentState();
            upDriver.WaitForjQuery();
            upDriver.WaitForAngular();
            element.Submit();
        }

        public void Click()
        {
            upDriver.WaitForDocumentState();
            upDriver.WaitForjQuery();
            upDriver.WaitForAngular();
            element.Click();
        }

        public string GetAttribute(string attributeName)
        {
            upDriver.WaitForDocumentState();
            upDriver.WaitForjQuery();
            upDriver.WaitForAngular();
            return element.GetAttribute(attributeName);
        }

        public string GetProperty(string propertyName)
        {
            upDriver.WaitForDocumentState();
            upDriver.WaitForjQuery();
            upDriver.WaitForAngular();
            return element.GetProperty(propertyName);
        }

        public string GetCssValue(string propertyName)
        {
            upDriver.WaitForDocumentState();
            upDriver.WaitForjQuery();
            upDriver.WaitForAngular();
            return element.GetCssValue(propertyName);
        }

        public string TagName
        {
            get
            {
                upDriver.WaitForDocumentState();
                upDriver.WaitForjQuery();
                upDriver.WaitForAngular();
                return element.TagName;
            }
        }

        public string Text
        {
            get
            {
                upDriver.WaitForDocumentState();
                upDriver.WaitForjQuery();
                upDriver.WaitForAngular();
                return element.Text;
            }
        }

        public bool Enabled
        {
            get
            {
                upDriver.WaitForDocumentState();
                upDriver.WaitForjQuery();
                upDriver.WaitForAngular();
                return element.Enabled;
            }
        }

        public bool Selected
        {
            get
            {
                upDriver.WaitForDocumentState();
                upDriver.WaitForjQuery();
                upDriver.WaitForAngular();
                return element.Selected;
            }
        }

        public Point Location
        {
            get
            {
                upDriver.WaitForDocumentState();
                upDriver.WaitForjQuery();
                upDriver.WaitForAngular();
                return element.Location;
            }
        }

        public Size Size
        {
            get
            {
                upDriver.WaitForDocumentState();
                upDriver.WaitForjQuery();
                upDriver.WaitForAngular();
                return element.Size;
            }
        }

        public bool Displayed
        {
            get
            {
                upDriver.WaitForDocumentState();
                upDriver.WaitForjQuery();
                upDriver.WaitForAngular();
                return element.Displayed;
            }
        }
    }
}
