using OpenQA.Selenium;

namespace SeleniumCSharpNetCore
{
    internal class SelectElement
    {
        private IWebElement webElement;

        public SelectElement(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        internal void SelectByValue(string value)
        {
            throw new NotImplementedException();
        }

        internal void SelectByText(string text)
        {
            throw new NotImplementedException();
        }
    }
}