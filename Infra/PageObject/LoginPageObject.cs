using OpenQA.Selenium;
using FrontEnd.Infra.Webdriver;
using System.Threading;
using NUnit.Framework;


namespace FrontEnd.Infra.PageObject
{
    public class LoginPageObject
    {
        private IWebElement Email { get {return Browser.WebDriver.FindElement(By.XPath("//*[@id='__next']/div/div[2]/div/div[1]/form/div[1]/input"));}}
        private IWebElement Senha { get {return Browser.WebDriver.FindElement(By.XPath("//*[@id='__next']/div/div[2]/div/div[1]/form/div[2]/div/input"));}}
        private IWebElement exemploContains { get {return Browser.WebDriver.FindElement(By.XPath("//*[contains(@title, 'email')]"));}}
        private IWebElement acessar { get {return Browser.WebDriver.FindElement(By.XPath("//*[@id='__next']/div/div[2]/div/div[1]/form/div[3]/button[1]"));}}
        private IWebElement bemVindo { get {return Browser.WebDriver.FindElement(By.XPath("//*[@id='__next']/div/div[2]/div/div[2]/p[2]"));}}


        public void UserPassword(string email, string senha)
        {
            Thread.Sleep(50);
            this.Email.SendKeys(email);
            this.Senha.SendKeys(senha);
            this.acessar.Click();
            
        }
        public void BemVindo()
        {
            var textBemVindo = "bem vindo ao BugBank :)";
            var textoEsperado = bemVindo;
            Assert.AreEqual(textBemVindo, textoEsperado); 
        }
    }


}