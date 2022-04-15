using System;
using TechTalk.SpecFlow;
using Microsoft.Extensions.Configuration;
using FrontEnd.Infra.Webdriver;
using System.Threading;
using FrontEnd.Steps.Context;
using System.IO;
using TechTalk.SpecFlow.Infrastructure;
using OpenQA.Selenium;


namespace FrontEnd.Steps
{
    [Binding]
    public class GenericHooks : BaseStep
    {
        private readonly ISpecFlowOutputHelper _specFlowOutputHelper;
        private readonly Browser _browser;

        public GenericHooks(BaseContext baseContext,Browser browser, ISpecFlowOutputHelper specFlowOutputHelper ): base (baseContext){
            _browser = browser;
            _specFlowOutputHelper = specFlowOutputHelper;
        }

        [Before]
        public void GenericBefore(BrowserFactory browserFactory, ISpecFlowOutputHelper specFlowOutputHelper)
        {

            string env = Environment.GetEnvironmentVariable("ENVIRONMENT", EnvironmentVariableTarget.User);
            if (env == null)
                env = "PROD";
            var configurationBuilder = new ConfigurationBuilder();

            if (env == "DES")
            configurationBuilder.AddJsonFile("DEV.json");
            else if (env=="PROD")
            configurationBuilder.AddJsonFile("PROD.json");
            baseContext.configuration = configurationBuilder.Build();
        }

        [Before("B")]
        public void BBefore(){}
      
        [AfterStep("BB")]

        public void TakeScreenshotAfterEachStep()
        {

            if (_browser.Current is ITakesScreenshot screenshotTaker)
            {
                var filename = Path.ChangeExtension(Path.GetRandomFileName(), "png");

                screenshotTaker.GetScreenshot().SaveAsFile(filename);

                _specFlowOutputHelper.AddAttachment(filename);
            }
        }
        [After("After")]

        public void BAfter()
        {
            Thread.Sleep(100);
            Browser.WebDriver.Close();
            Browser.WebDriver.Dispose();
            Browser.WebDriver.Quit();
        }
    }
}