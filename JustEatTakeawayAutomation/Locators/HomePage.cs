using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustEatTakeawayAutomation
{
    public partial class HomePage
    {
        #region Home Page Locators
        public static By JobTitleInput = By.Name("typehead");
        public static By Sales = By.XPath("//span[@class='au-target phs-Sales']");

        public static By SearchButton = By.Id("ph-search-backdrop");

        #endregion

        #region Search Page Locators
        public static By RefineYourSearch = By.XPath("//ppc-content[normalize-space()='Refine your search']");

        public static By Country = By.Id("CountryAccordion");
        public static By Netherlands = By.Id("country_phs_Netherlands1");
        public static By Germany = By.XPath("//span[normalize-space()='Germany']");

        public static By Lbl_Netherlands = By.XPath("//span[@class='facet-tag']");
        public static By Lbl_Sales = By.XPath("//span[@class='facet-tag au-target']");
        public static By Lbl_Count = By.XPath("//span[@class='result-count au-target']");

        #endregion
    }
}
