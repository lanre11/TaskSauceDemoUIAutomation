using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoUIAutomation.SetUp
{
    public class Context
    {
        private IObjectContainer _objectContainer;
        private IWebDriver _driver;
        string baseUrl = "https://www.saucedemo.com/";

        public Context(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
            _driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
        }

        public void LoadApplication()
        {
            
            
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            _driver.Navigate().GoToUrl(baseUrl);
            _driver.Manage().Window.Maximize();
        }

        public void CloseApplication()
        {
            _driver.Quit();
        }
    }
}
