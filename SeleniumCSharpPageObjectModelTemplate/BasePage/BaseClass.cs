using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpPageObjectModelTemplate.PageObjects;
using SeleniumCSharpPageObjectModelTemplate.Utils;

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
        private ConfigurationManager _configurationManager;
        private string _baseUrl;

        [SetUp]
        public void Init()
        {
            _configurationManager = new ConfigurationManager();
            _baseUrl = _configurationManager.GetConfigValue("baseUrl");

            _options = new ChromeOptions();
            //_options.AddArgument("--incognito");
            //_options.AddArgument("user-data-dir=C:\\Users\\Amine\\AppData\\Local\\Google\\Chrome\\User Data");
            //_options.AddArgument("profile-directory=Profile 3");
            _options.AddArgument("--headless");
            _options.AddArgument("start-maximized"); // open Browser in maximized mode
            _options.AddArgument("disable-infobars"); // disabling infobars
            _options.AddArgument("--disable-extensions"); // disabling extensions
            _options.AddArgument("--disable-gpu"); // applicable to windows os only
            _options.AddArgument("--disable-dev-shm-usage"); // overcome limited resource problems
            _options.AddArgument("--no-sandbox"); // Bypass OS security model
            _options.AddArgument("--disable-popup-blocking"); // Bypass popup
            
            _driver = new ChromeDriver(_options);

            _homePage = new HomePage(_driver);
            _registrationPage = new RegistrationPage(_driver);
            _loginPage = new LoginPage(_driver);
            
            _driver.Navigate().GoToUrl(_baseUrl);
        }
    }
}