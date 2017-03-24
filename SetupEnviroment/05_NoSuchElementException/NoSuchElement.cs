using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;

class NoSuchElement
{

    /************************************/
    /* No Such Element Exception means: */
    /* - the console "crashes".         */
    /* - The element doesn't exist.     */
    /************************************/

    public static void DoExample()
    {
        string url = "http://testing.todvachev.com/selectors/css-path/";
        string cssPath = "#post-108 > div > fig img"; //break a selector.
        string xPath = ".//*[@id='post-108']/div/figure/img";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        /** Copy selector: Copy CSS path **/
        /** Copy xpath: It's the same that "Copy CSS" but is uglier **/
        //test
        IWebElement cssPathElement; //The driver find an initiation element outside TRY-CATCH block; it needs to move the initiation element inside into TRY-CATCH block
        IWebElement xPathElement = driver.FindElement(By.XPath(xPath)); //IE has a poor support for xPath

        /**********************************************************************************************/
        /* Try-Catch block is necessary to do because there is an exception when a selector is broken.*/
        /* So the different is:                                                                       */
        /* - TRY add the IF                                                                           */
        /* - CATCH add the ELSE (when there is an exception)                                          */
        /**********************************************************************************************/

        try
        {
            //CSS path
            cssPathElement =  driver.FindElement(By.CssSelector(cssPath));  

            if (cssPathElement.Displayed)
            {
                GreenMessage("I can see CSS Path Element");
            }
           
        }
        catch(NoSuchElementException) //The exception should be changed to "NoSuchElementException".
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
