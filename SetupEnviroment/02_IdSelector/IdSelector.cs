
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class IdSelector
{
    public static void DoExample()
    {
        string url = "http://testing.todorvachev.com/selectors/id/";
        string IDSelector = "testImage";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        IWebElement IDElement = driver.FindElement(By.Id(IDSelector));


        //Boolean, if an element is displayed.
        if (IDElement.Displayed)
        {
            GreenMessage("Yes, I can see it!");
        }

        else
        { 
            RedMessage("Nope, it's not there");
        }
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
