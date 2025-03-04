using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V131.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoUIAutomation.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private By usernameField = By.Id("user-name");
        private By passwordField = By.CssSelector("input[type*= 'password']");
        private By LoginButton = By.Id("login-button");
        private By product = By.Id("item_5_title_link");
        private By addToCartButton = By.Id("add-to-cart");
        private By cartButton = By.Id("shopping_cart_container");
        private By cartPage = By.CssSelector("span[class= 'title']");

        public void FillUsernameField(string username)
        {
            IWebElement usernameLocator = _driver.FindElement(usernameField);
            usernameLocator.Clear();
            usernameLocator.SendKeys(username);
        }

        public void FillPasswordField(string password)
        {
            IWebElement passwordLocator = _driver.FindElement(passwordField);
            passwordLocator.Clear();
            passwordLocator.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _driver.FindElement(LoginButton).Click();
        }

        public void ClickProduct()
        {
            _driver.FindElement(product).Click();
        }

        public void ClickAddToCartButton()
        {
            _driver.FindElement(addToCartButton).Click();
        }

        public void ClickCartButton()
        {
            _driver.FindElement(cartButton).Click();
        }

        public string VerifyCartPage()
        {
            return _driver.FindElement(cartPage).Text.Trim();
        }

    }

    
}
