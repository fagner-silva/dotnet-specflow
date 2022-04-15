using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FrontEnd.Infra.Webdriver
{
    public class BrowserFactory 
    {
        public static IWebDriver CreateWebDriver()
        {
            
            IWebDriver webDriver;
            ChromeOptions chromeOptions = new ChromeOptions();
            //chromeOptions.AddArgument("--incognito");
            //chromeOptions.AddArgument("--headless");
            new DriverManager().SetUpDriver(new ChromeConfig());
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            return webDriver;
        }

    }
}