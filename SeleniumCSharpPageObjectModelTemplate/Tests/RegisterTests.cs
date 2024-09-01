using NUnit.Framework;
using SeleniumCSharpPageObjectModelTemplate.BasePage;

namespace SeleniumCSharpPageObjectModelTemplate.Tests
{
    public class RegisterTests : BaseClass
    {
        [Test]
        public void ValidRegisatration()
        {
            _homePage.GoToRegistrationPage();
        }
    }
}