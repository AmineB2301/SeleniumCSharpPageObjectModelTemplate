using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumCSharpPageObjectModelTemplate.PageObjects
{
    public class HomePage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.ClassName, Using = "ico-register")]
        private IWebElement RegisterLnk { get; set; }

        [FindsBy(How = How.ClassName, Using = "ico-login")]
        private IWebElement LoginLnk { get; set; }

        public HomePage(IWebDriver fDriver)
        {
            this._driver = fDriver;
            PageFactory.InitElements(_driver, this);
        }

        public void GoToRegistrationPage()
        {
            RegisterLnk.Click();
        }

        public void GoToLoginPage()
        {
            LoginLnk.Click();
        }
    }
}
