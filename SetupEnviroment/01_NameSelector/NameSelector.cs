
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;

class NameSelector
{
    public static void DoExample()
    {

        /*Always to initialize.*/
        IWebDriver driver = new ChromeDriver(); //Open Chrome
        driver.Navigate().GoToUrl("http://testing.todorvachev.com/selectors/name/"); //Open the URL

        IWebElement nameElement = driver.FindElement(By.Name("myName"));
        nameElement.SendKeys("Hello World"); //Type the text.

        /*Check the element exist in the page*/
        if (nameElement.Displayed)
        {
            GreenMessage("Yes, I can see the element.");
        }

        else
        {
            //System.Console.WriteLine
             RedMessage("No, I can't see the element.");
        }

        Thread.Sleep(3000); //Timer
        driver.Quit();
    }


    /*To add color to console text "System.Console.WriteLine();*/
    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White; //This line print the last text.
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White; //This line print the last text.
    }
}

