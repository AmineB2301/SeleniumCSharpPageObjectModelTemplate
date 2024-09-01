using NUnit.Framework;
using SeleniumCSharpPageObjectModelTemplate.BasePage;

namespace SeleniumCSharpPageObjectModelTemplate.Tests
{
    public class LoginTests : BaseClass
    {
        [Test]
        public void ValidLogin()
        {
            _homePage.GoToLoginPage();
        }
    }
}