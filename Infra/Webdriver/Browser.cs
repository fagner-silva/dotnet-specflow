using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow.Infrastructure;
using OpenQA.Selenium.Chrome;

namespace FrontEnd.Infra.Webdriver
{
    public class Browser : IDisposable
    {
        private readonly ISpecFlowOutputHelper _specFlowOutputHelper;
        private readonly Lazy<IWebDriver> _currentWebDriverLazy;
        private bool _isDisposed;
        private static IWebDriver webDriver = null;

        public IWebDriver Current => _currentWebDriverLazy.Value;


        public Browser(ISpecFlowOutputHelper specFlowOutputHelper)
        {
            _specFlowOutputHelper = specFlowOutputHelper;
            _currentWebDriverLazy = new Lazy<IWebDriver>(WebDriver);
        }


        public static IWebDriver WebDriver{
            get {
                if (webDriver == null)
                    webDriver = BrowserFactory.CreateWebDriver();
                    return webDriver;
            }
        }

        public void Dispose(){
              if (_isDisposed)
            {
                return;
            }

            if (_currentWebDriverLazy.IsValueCreated)
            {
                Current.Quit();

                _specFlowOutputHelper.WriteLine("Browser closed");
            }

            _isDisposed = true;
        }
    }
}