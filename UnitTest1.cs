using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CsharpSelenium2022
{
    public class Tests
    {
     public   IWebDriver Driver;
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();

           
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            Driver.FindElement(By.CssSelector("#maincont > div:nth-child(3) > div:nth-child(5) > div:nth-child(2) > div.awe-ajaxcheckboxlist-field.awe-field > div > ul > li:nth-child(1) > label > div.o-chk > div > div")).Click();
            var comboControl = Driver.FindElement(By.CssSelector("#maincont > div:nth-child(3) > div:nth-child(2) > div:nth-child(2) > div.einput > div > div"));
            comboControl.Clear();
            comboControl.SendKeys("Almond");


            Console.WriteLine("test1");
            Assert.Pass();
        }
    }
}