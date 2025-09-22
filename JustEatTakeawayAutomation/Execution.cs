namespace JustEatTakeawayAutomation
{

    [TestFixture]
    public class Execution : WebDriver
    {
        HomePage homePage = new HomePage();
        public static TestContext MyTestContext
        {
            get
            {
                return TestContext.CurrentContext;
            }
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Console.WriteLine("Execution Started");
        }

        [SetUp]
        public void Setup()
        {
            CreateDriver("chrome");
        }

        [Test]
        public void SearchJobTitle_TC()
        {
            homePage.SearchJobTitle("Test");
        }

        [Test]
        public void SearchJobCategorySales_TC()
        {
            homePage.SelectJobTitle("Sales");
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}


