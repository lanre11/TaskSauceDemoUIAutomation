using System;
using TechTalk.SpecFlow;
using SauceDemoUIAutomation.Pages;
using SauceDemoUIAutomation.SetUp;
using NUnit.Framework;


namespace SauceDemoUIAutomation.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private Context _context;
        private LoginPage _loginPage;
        

        public LoginStepDefinitions(Context context, LoginPage loginPage)
        {
            _context = context;
            _loginPage = loginPage;
            
        }

        [Given(@"that Sauce Demo application is launched")]
        public void GivenThatSauceDemoApplicationIsLaunched()
        {
            _context.LoadApplication();
        }

        [When(@"a user fills-in username field with (.*)")]
        public void WhenAUserFills_InUsernameFieldWithStandard_User(string username)
        {
            _loginPage.FillUsernameField(username);
        }

        [When(@"a user fills-in password field with (.*)")]
        public void WhenAUserFills_InPasswordFieldWithSecret_Sauce(string password)
        {
            _loginPage.FillPasswordField(password);
        }

        [When(@"a user clicks on the login button")]
        public void WhenAUserClicksOnTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [When(@"a user clicks on Sauce Labs Fleece Jacket")]
        public void WhenAUserClicksOnSauceLabsFleeceJacket()
        {
            _loginPage.ClickProduct();
        }

        [When(@"a user clicks on the add to cart button")]
        public void WhenAUserClicksOnTheAddToCartButton()
        {
            _loginPage.ClickAddToCartButton();
        }

        [When(@"a user clicks on the cart button")]
        public void WhenAUserClicksOnTheCartButton()
        {
            _loginPage.ClickCartButton();
        }

        [Then(@"a user should be able to see the product in the cart")]
        public void ThenAUserShouldBeAbleToSeeTheProductInTheCart()
        {
            string actualResult = _loginPage.VerifyCartPage();
        }

        [AfterScenario]

        public void CloseApplication()
        {
            _context.CloseApplication();
        }
    }
}
