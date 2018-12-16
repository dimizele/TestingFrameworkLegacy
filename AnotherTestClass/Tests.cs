using BaseSetup.Browser;
using BaseSetup.Test;
using NUnit.Framework;
using Tests.Pages;

namespace Tests.Tests
{
    [TestFixture]
    public class LogInPageTests : UiTestBase
    {
        private readonly string username = "user@phptravels.com";
        private readonly string password = "demouser";

        public override void BeforeEach()
        {
            Driver.Manage().Window.Maximize();
        }

        [Test]
        public void LogInToHomePage()
        {
            Driver.GoToPage<LogInPage>()
                .LogIn(username, password);
        }
    }
}
