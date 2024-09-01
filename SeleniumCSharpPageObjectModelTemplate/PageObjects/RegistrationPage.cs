using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumCSharpPageObjectModelTemplate.PageObjects
{
    public class RegistrationPage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.ClassName, Using = "")]
        private IWebElement Txt { get; set; }

        public RegistrationPage(IWebDriver fDriver)
        {
            this._driver = fDriver;
            PageFactory.InitElements(_driver, this);
        }

        public void Register()
        {
        }
    }
}
