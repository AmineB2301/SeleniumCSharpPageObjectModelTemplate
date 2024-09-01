using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumCSharpPageObjectModelTemplate.PageObjects
{
    public class LoginPage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.ClassName, Using = "")]
        private IWebElement Txt { get; set; }

        public LoginPage(IWebDriver fDriver)
        {
            this._driver = fDriver;
            PageFactory.InitElements(_driver, this);
        }

        public void Login()
        {
        }
    }
}
