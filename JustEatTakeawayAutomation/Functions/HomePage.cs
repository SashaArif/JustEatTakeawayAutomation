using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustEatTakeawayAutomation
{
    public partial class HomePage
    {
        public void SearchJobTitle(string jobTitle)
        {
            WebDriver.driver.FindElement(JobTitleInput).SendKeys(jobTitle);
            WebDriver.driver.FindElement(SearchButton).Click();

            ScrollToElement(WebDriver.driver,WebDriver.driver.FindElement(Country));

            WebDriver.driver.FindElement(Country).Click();
            WebDriver.driver.FindElement(Netherlands).Click();

            Assert.AreEqual("Netherlands", WebDriver.driver.FindElement(Lbl_Netherlands).Text);
        }

        public void SelectJobTitle(string jobTitle)
        {
            WebDriver.driver.FindElement(JobTitleInput).Click();
            WebDriver.driver.FindElement(Sales).Click();

            ScrollToElement(WebDriver.driver, WebDriver.driver.FindElement(Country));
            Assert.AreEqual(jobTitle, WebDriver.driver.FindElement(Lbl_Sales).Text);

            ScrollToElement(WebDriver.driver, WebDriver.driver.FindElement(Country));
            WebDriver.driver.FindElement(Country).Click();
            Thread.Sleep(1000);
            WebDriver.driver.FindElement(Germany).Click();
            Thread.Sleep(1000);
            Assert.AreEqual("20", WebDriver.driver.FindElement(Lbl_Count).Text);
        }

        public static void ScrollToElement(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'});", element);
            Thread.Sleep(4000);
        }
    }
}
