using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{

    static void Main()
    {
        string url = "http://testing.todorvachev.com/selectors/class-name/";
        string className = "testClass";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        IWebElement NameElement = driver.FindElement(By.ClassName(className));
        Console.WriteLine(NameElement.Text); //Checking the text is visible. If there not exist classname the app will stop (crash)

        Thread.Sleep(3000);
        driver.Quit();
    }
}
