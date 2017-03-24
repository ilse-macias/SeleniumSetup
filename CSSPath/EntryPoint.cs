using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;

class EntryPoint
{
    static void Main()
    {
        string url = "http://testing.todvachev.com/selectors/css-path/";
        string cssPath = "#post-108 > div > figure > img";
        string xPath = ".//*[@id='post-108']/div/figure/img"; 

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        /** Copy selector: Copy CSS path **/
        /** Copy xpath: It's the same that "Copy CSS" but is uglier **/

        IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));
        IWebElement xPathElement = driver.FindElement(By.XPath(xPath)); //IE has a poor support for xPath

        //CSS Path
        if (cssPathElement.Displayed)
        {
            GreenMessage("I can see CSS Path Element");
        }

        else
        {
            RedMessage("I can't see CSS Path Element");
        }

        //xPath
        if (xPathElement.Displayed)
        {
            GreenMessage("I can see xPath Element");
        }

        else
        {
            RedMessage("I can't see xPath Element");
        }
        //test
        Thread.Sleep(3000);
        driver.Close();
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
