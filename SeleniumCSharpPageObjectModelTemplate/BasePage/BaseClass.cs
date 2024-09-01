using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpPageObjectModelTemplate.PageObjects;

namespace SeleniumCSharpPageObjectModelTemplate.BasePage
{
    /// <summary>
    /// Initialise the driver, Setup driver & contains re-usable methods
    /// </summary>
    public class BaseClass
    {
        public static IWebDriver _driver;
        public static ChromeOptions _options;
        public static HomePage _homePage;
        public static RegistrationPage _registrationPage;
        public static LoginPage _loginPage;

        private string _baseUrl = "https://demowebshop.tricentis.com/";

        [SetUp]
        public void Init()
        {
            _options = new ChromeOptions();

            _options.AddArgument("--disable-popup-blocking");
            _options.AddArgument("--disable-extensions");
            _options.AddArgument("--incognito");
            //_options.AddArgument("user-data-dir=C:\\Users\\<VotreNom>\\AppData\\Local\\Google\\Chrome\\User Data");
            // Spécifiez le nom du profil spécifique à utiliser (si vous avez plusieurs profils)
            //_options.AddArgument("profile-directory=Default"); // Remplacez "Default" par le nom de votre profil

            _driver = new ChromeDriver(_options);

            _homePage = new HomePage(_driver);
            _registrationPage = new RegistrationPage(_driver);
            _loginPage = new LoginPage(_driver);
            
            _driver.Navigate().GoToUrl(_baseUrl);

            _driver.Manage().Window.Maximize();
        }
    }
}
