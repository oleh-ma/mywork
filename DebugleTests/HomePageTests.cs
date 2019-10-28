using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using DebugleTests.PageObjects;
using System.Threading;

namespace DebugleTests
{
    public class HomePageTests
    {
        private string _correctLogin = "devedtest@i.ua";
        private string _correctPassword = "qwerty123456";
        private string _homePageUrl = "https://www.i.ua/";
        private string _select = "i.ua";
        private string _theme = "test";
        private string _text = "Hello World!";

        [Fact]
        public void LoginWithCorrectLoginAndPassword()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(_homePageUrl);
            HomePage home = new HomePage(driver);
            home.typeUserLogin(_correctLogin);
            home.typeUserPassword(_correctPassword);
            home.typeUserSelect(_select);
            home.clickLoginButton();
            int result = home.Result();
            int _actResult = result;
            home.ClickSendLetter();
            home.SendLetterTo(_correctLogin);
            home.SendLetterTheme(_theme);
            home.EnterText(_text);
            home.ClickingSendLetter();
            home.ClickingIncomming();
            int actResult = home.Result();
            Assert.Contains(Convert.ToString(result), Convert.ToString(actResult +1));

        }
    }
}
