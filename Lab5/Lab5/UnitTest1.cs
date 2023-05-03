using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lab5
{
    public class Tests
    {
        private IWebDriver driver = new ChromeDriver(@"C:\Users\mbsdi\.nuget\packages\selenium.webdriver.chromedriver\112.0.5615.4900\");

        private readonly By _RegisterButton = By.XPath("//span[text()='Зарегистрироваться']");// Ссылка на кнопку Зарегистрироваться

        private readonly By _SaveEntryCheckBox = By.XPath("//span[text()='Сохранить вход']");// Ссылка на элемент чекбокса

        private readonly By _PhoneNumberInput = By.XPath("//input[@name='phone']"); //Ссылка на элемент поля с вводом номера для регистрации

        private readonly By _ContinueButton = By.XPath("//span[text()='Продолжить']");// Ссылка на кнопку Продолжить

        //Метод преднастроек автотеста
        [SetUp]
        public void Setup() 
        { 
            driver.Navigate().GoToUrl("https://www.kstu.ru/"); //Переходим на нужный нам сайт
            driver.Manage().Window.Maximize(); //Увеличиваем окно браузера на всь экран
        }

        //Метод настроек автотеста
        [Test]
        public void Test1()
        {
            //Кликаем на кнопку регистрации на странице
            var register = driver.FindElement(_RegisterButton);
            register.Click();

            //Клик по снятию галочки в чекбоксе для отмены сорханения входа
            var saveEntry = driver.FindElement(_SaveEntryCheckBox);
            saveEntry.Click();

            //Вводим номер телефона в поле для ввода номера телефона
            var phoneNumber = driver.FindElement(_PhoneNumberInput);
            phoneNumber.SendKeys("9173886570");


            //Нажимаем на кнопку продолжить
            var continueButton = driver.FindElement(_ContinueButton);
            continueButton.Click();
        }


        //Метод Постнастроек автотеста
        [TearDown]
        public void TearDown()
        {

        }
    }
}