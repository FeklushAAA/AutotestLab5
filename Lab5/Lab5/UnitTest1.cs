using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lab5
{
    public class Tests
    {
        private IWebDriver driver = new ChromeDriver(@"C:\Users\mbsdi\.nuget\packages\selenium.webdriver.chromedriver\112.0.5615.4900\");

        private readonly By _RegisterButton = By.XPath("//span[text()='������������������']");// ������ �� ������ ������������������

        private readonly By _SaveEntryCheckBox = By.XPath("//span[text()='��������� ����']");// ������ �� ������� ��������

        private readonly By _PhoneNumberInput = By.XPath("//input[@name='phone']"); //������ �� ������� ���� � ������ ������ ��� �����������

        private readonly By _ContinueButton = By.XPath("//span[text()='����������']");// ������ �� ������ ����������

        //����� ������������ ���������
        [SetUp]
        public void Setup() 
        { 
            driver.Navigate().GoToUrl("https://www.kstu.ru/"); //��������� �� ������ ��� ����
            driver.Manage().Window.Maximize(); //����������� ���� �������� �� ��� �����
        }

        //����� �������� ���������
        [Test]
        public void Test1()
        {
            //������� �� ������ ����������� �� ��������
            var register = driver.FindElement(_RegisterButton);
            register.Click();

            //���� �� ������ ������� � �������� ��� ������ ���������� �����
            var saveEntry = driver.FindElement(_SaveEntryCheckBox);
            saveEntry.Click();

            //������ ����� �������� � ���� ��� ����� ������ ��������
            var phoneNumber = driver.FindElement(_PhoneNumberInput);
            phoneNumber.SendKeys("9173886570");


            //�������� �� ������ ����������
            var continueButton = driver.FindElement(_ContinueButton);
            continueButton.Click();
        }


        //����� ������������ ���������
        [TearDown]
        public void TearDown()
        {

        }
    }
}