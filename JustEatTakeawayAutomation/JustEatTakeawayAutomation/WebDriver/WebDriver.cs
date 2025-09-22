using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustEatTakeawayAutomation
{
    public class WebDriver
    {
        public static IWebDriver driver {  get; set; }

        public static IWebDriver CreateDriver(string browser)
        {

            switch (browser.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "safari":
                    driver = new SafariDriver();
                    break;
                default:
                    throw new ArgumentException("Browser not supported: " + browser);
            }

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://careers.justeattakeaway.com/global/en/home");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            return driver;
        }

    }
}
