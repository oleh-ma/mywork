using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace DebugleTests.PageObjects
{
    public class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            this._driver = driver;
        }
        By _userLogin = By.XPath("/html/body/div[3]/div[3]/div[3]/div[2]/div[1]/div[3]/form/ul/li[1]/p[2]/input");
        By _userPassword = By.XPath("/html/body/div[3]/div[3]/div[3]/div[2]/div[1]/div[3]/form/ul/li[1]/input");
        By _select = By.XPath("/html/body/div[3]/div[3]/div[3]/div[2]/div[1]/div[3]/form/ul/li[2]/p/select");
        By _loginButton = By.XPath("/html/body/div[3]/div[3]/div[3]/div[2]/div[1]/div[3]/form/p/input");
        By _sendLetter = By.XPath("/html/body/div[1]/div[6]/div[1]/div[1]/p/a");
        By _sendTo = By.Id("to");
        By _sendLetterButton = By.XPath("/html/body/div[4]/div[6]/div[1]/div[1]/p[1]/input[1]");
        By _letterTheme = By.XPath("/html/body/div[4]/div[6]/div[1]/div[1]/div[1]/div/form/div[5]/div[2]/span/input[1]");
        By _incomming = By.XPath("/html/body/div[1]/div[6]/div[2]/div/div/div[2]/div[2]/div[3]/ul/li[1]/a");
        By _text = By.XPath("/html/body/div[4]/div[6]/div[1]/div[1]/div[2]/textarea");
        By res = By.XPath("/html/body/div[1]/div[6]/div[2]/div[1]/div[2]/div[3]/ul/li[1]/a/ins");

        public HomePage typeUserLogin(string Login)
        {
            _driver.FindElement(_userLogin).SendKeys(Login);
            return this;
        }
        public HomePage typeUserPassword(string Password)
        {
            _driver.FindElement(_userPassword).SendKeys(Password);
            return this;
        }
        public HomePage typeUserSelect(string Select)
        {
            IWebElement Elem = _driver.FindElement(_select);
            var iSelect = new SelectElement(Elem);
            iSelect.SelectByText(Select);
            return this;
        }
        public HomePage clickLoginButton()
        {
            _driver.FindElement(_loginButton).Click();
            return this;
        }
        public HomePage ClickSendLetter()
        {
            _driver.FindElement(_sendLetter).Click();
            return this;
        }
        public HomePage SendLetterTo(string Login)
        {
            _driver.FindElement(_sendTo).SendKeys(Login);
            return this;
        }
        public HomePage ClickingSendLetter()
        {
            _driver.FindElement(_sendLetterButton).Click();
            return this;
        }
        public HomePage SendLetterTheme(string Theme)
        {
            _driver.FindElement(_letterTheme).SendKeys(Theme);
            return this;
        }
        public HomePage ClickingIncomming()
        {
            _driver.FindElement(_incomming).Click();
            return this;
        }
        public HomePage EnterText(string Text)
        {
            _driver.FindElement(_text).SendKeys(Text);
            return this;
        }
        public int Result()
        {
             int result = Convert.ToInt32(_driver.FindElement(res).Text);
            return result;
        }
    }
}
